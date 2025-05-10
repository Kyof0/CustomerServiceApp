using Microsoft.Data.SqlClient;
using Dapper;
using System.Windows.Forms;
using BCrypt.Net;
namespace Login
{
    class Database
    {
        string connectionString = "Server=SP-AORUS;Database=CustomerServiceDB;Trusted_Connection=True;TrustServerCertificate=true;";
        public Database()
        {
        }
        public bool CreateTicket(string _firstname, string _lastname, string _email, string _subject, string _description, string _categoryname)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    var sql = """
                          SELECT[CustomerID]
                          FROM [CustomerServiceDB].[dbo].[Customers]
                          WHERE FirstName = @firstname AND LastName = @lastname AND Email = @email
                          """;
                    var _customerID = connection.Query<string>(sql, new { firstname = _firstname, lastname = _lastname, email = _email });
                    int _priorityID = 0;
                    int _categoryID = 0;
                    switch (_categoryname)
                    {
                        case "Technical Issue":
                            _categoryID = 1;
                            _priorityID = 3;
                            break;
                        case "Billing":
                            _categoryID = 2;
                            _priorityID = 3;
                            break;
                        case "Account Support":
                            _categoryID = 3;
                            _priorityID = 2;
                            break;
                        case "Feature Request":
                            _categoryID = 4;
                            _priorityID = 1;
                            break;
                        case "General Inquiry":
                            _categoryID = 5;
                            _priorityID = 1;
                            break;
                    }
                    DateTime now = DateTime.Now;
                    string _createdDate = (now.ToString("yyyy-MM-dd HH:mm:ss"));
                    sql = """
                          INSERT INTO Tickets (CustomerID, Subject, Description, StatusID, PriorityID, CategoryID, SourceID, CreatedDate)
                          VALUES(@customerID, @subject, @description, 1, @priorityID, @categoryID, 3, @createdDate);
                          SELECT SCOPE_IDENTITY();
                    """;
                    var _ticketID = connection.Query<int>(sql, new { customerID = _customerID, subject = _subject, description = _description, priorityID = _priorityID, categoryID = _categoryID, createdDate = _createdDate });

                    //Assign ticket to agent
                    sql = """
                    SELECT a.AgentID
                        ,COUNT(CASE WHEN ts.StatusName = 'Open' THEN 1 END) AS [OpenTicketCount]
                    FROM CustomerServiceDB.dbo.Agents a
                    LEFT JOIN CustomerServiceDB.dbo.TicketAssignments ta ON a.AgentID = ta.AgentID
                    LEFT JOIN CustomerServiceDB.dbo.Tickets t ON t.TicketID = ta.TicketID
                    LEFT JOIN CustomerServiceDB.dbo.TicketStatuses ts ON t.StatusID = ts.StatusID
                    GROUP BY a.AgentID;
                    """;
                    var _agentAssignments = connection.Query<AgentAssignments>(sql);
                    int? _agentIDWithLowestCount = _agentAssignments.OrderBy(x => x.OpenTicketCount).FirstOrDefault()?.AgentID;
                    sql = """
                    INSERT INTO TicketAssignments (TicketID, AgentID, AssignedDate)
                    VALUES (@ticketID,@agentID,@assignedDate)
                    """;
                    connection.Execute(sql, new { ticketID = _ticketID, agentID = _agentIDWithLowestCount, assignedDate = _createdDate });
                    return true;
                }
                catch (SqlException _sqlEx)
                {
                    MessageBox.Show("{" + _sqlEx.ToString() + "}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public void QueryTicket(string _firstname, string _lastname, string _email, string _ticketstatus, DataGridView _DTWTicket)
        {
            using(var connection = new SqlConnection(connectionString))
            {
                var _statusID = "";
                switch (_ticketstatus)
                {
                    case "Open":
                        _statusID = "1";
                        break;
                    case "Close":
                        _statusID = "2";
                        break;
                    case "All":
                        _statusID = "1 OR t.StatusID = 2";
                        break;
                }
                var sql = """
                                        SELECT t.TicketID
                          ,c.FirstName
                    	  ,c.LastName
                    	  ,c.Email
                          ,t.Subject
                          ,t.Description
                          ,ts.StatusName
                          ,tp.PriorityName
                          ,tc.CategoryName
                          ,tso.SourceType
                          ,CreatedDate
                          ,UpdatedDate FROM Tickets t
                    LEFT JOIN Customers c ON c.CustomerID = t.CustomerID
                    LEFT JOIN TicketStatuses ts ON ts.StatusID = t.StatusID
                    LEFT JOIN TicketPriorities tp ON tp.PriorityID = t.PriorityID
                    LEFT JOIN TicketCategories tc ON tc.CategoryID = t.CategoryID
                    LEFT JOIN TicketSource tso ON tso.SourceID = t.SourceID
                    WHERE c.FirstName = @firstname AND c.LastName = @lastname AND c.Email = @email AND (t.StatusID = @statusID)
                    """;
                var _ticketList = connection.Query<Ticket>(sql, new { firstname = _firstname, lastname = _lastname, email = _email, statusID = _statusID }).ToList();
                if (_ticketList is null)
                {
                    return;
                }
                string[] row = [];
                _DTWTicket.ColumnCount = 12; 
                _DTWTicket.Columns[0].Name = "Ticket ID";
                _DTWTicket.Columns[1].Name = "First Name";
                _DTWTicket.Columns[2].Name = "Last Name";
                _DTWTicket.Columns[3].Name = "Email";
                _DTWTicket.Columns[4].Name = "Subject";
                _DTWTicket.Columns[5].Name = "Description";
                _DTWTicket.Columns[6].Name = "Status";
                _DTWTicket.Columns[7].Name = "Priority";
                _DTWTicket.Columns[8].Name = "Category";
                _DTWTicket.Columns[9].Name = "Source";
                _DTWTicket.Columns[10].Name = "Created Date";
                _DTWTicket.Columns[11].Name = "Updated Date";
                foreach (Ticket _ticket in _ticketList)
                {
                    row = _ticket.GetValues();
                    _DTWTicket.Rows.Add(row);
                }
                _DTWTicket.Visible = true;
            }

        }
        public LoggedAgent VerifyPassword(string _email, string _password)
        {
            LoggedAgent _loggedAgent = new LoggedAgent();
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var sql = """
                        SELECT [UserID]
                            ,[FirstName]
                            ,[LastName]
                            ,[PasswordHash]
                        FROM [CustomerServiceDB].[dbo].[Users]
                        WHERE Email = @email
                        """;
                    var user = connection.Query<(int,string,string,string)>(sql, new {email = _email}).ToList();
                    if(user.Count < 1)
                    {
                        return _loggedAgent;
                    }
                    bool isValid = BCrypt.Net.BCrypt.Verify(_password, user[0].Item4);
                    if (isValid)
                    {
                        sql = """
                            SELECT [AgentID]
                            FROM [CustomerServiceDB].[dbo].[Agents]
                            WHERE UserID = @userID
                            """;
                        var _agentID = connection.Query<int>(sql, new { userID = user[0].Item1 }).ToList();
                        DateTime now = DateTime.Now;
                        string _lastLogin = (now.ToString("yyyy-MM-dd HH:mm:ss"));
                        sql = """                  
                            UPDATE Users SET LastLogin = @lastLogin WHERE UserID = @userID
                            """;
                        connection.Execute(sql,new {lastLogin = _lastLogin, userID = user[0].Item1});
                        _loggedAgent.SetValues(_agentID[0], user[0].Item2, user[0].Item3);
                        return _loggedAgent;
                    }
                }
            }
            catch (SqlException _sqlEx)
            {
                Console.WriteLine("Something went wrong: " + _sqlEx.Message);
            }
            _loggedAgent.SetValues();
            return _loggedAgent;
        }
        public void QueryAssignedTicket(string _statusName, int _agentID, DataGridView _DGWAssignedTicket)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var sql = """
                      SELECT t.TicketID
                    	  ,c.FirstName
                    	  ,c.LastName
                    	  ,t.Subject
                    	  ,t.Description
                    	  ,tc.CategoryName
                    	  ,tso.SourceType
                    	  ,tp.PriorityName
                    	  ,ts.StatusName
                    	  ,t.CreatedDate
                          ,t.UpdatedDate
                      FROM CustomerServiceDB.dbo.TicketAssignments ta
                      LEFT JOIN Tickets t ON ta.TicketID = t.TicketID
                      LEFT JOIN TicketStatuses ts ON t.StatusID = ts.StatusID
                      LEFT JOIN TicketPriorities tp ON t.PriorityID = tp.PriorityID
                      LEFT JOIN TicketCategories tc ON t.CategoryID = tc.CategoryID
                      LEFT JOIN TicketSource tso ON t.SourceID = tso.SourceID
                      LEFT JOIN Customers c ON c.CustomerID = t.CustomerID
                      WHERE ts.StatusID = @statusName AND ta.AgentID = @agentID
                    """;
                var _assignedTicketList = connection.Query<AssignedTicket>(sql, new {statusName = 1, agentID = _agentID}).ToList();
                if (_assignedTicketList is null)
                {
                    return;
                }
                string[] row = [];
                _DGWAssignedTicket.ColumnCount = 11;
                _DGWAssignedTicket.Columns[0].Name = "Ticket ID";
                _DGWAssignedTicket.Columns[1].Name = "First Name";
                _DGWAssignedTicket.Columns[2].Name = "Last Name";
                _DGWAssignedTicket.Columns[3].Name = "Subject";
                _DGWAssignedTicket.Columns[4].Name = "Description";
                _DGWAssignedTicket.Columns[5].Name = "Category";
                _DGWAssignedTicket.Columns[6].Name = "Source";
                _DGWAssignedTicket.Columns[7].Name = "Priority";
                _DGWAssignedTicket.Columns[8].Name = "Status";
                _DGWAssignedTicket.Columns[9].Name = "Created Date";
                _DGWAssignedTicket.Columns[10].Name = "Updated Date";
                foreach (AssignedTicket _assignedTicket in _assignedTicketList)
                {
                    row = _assignedTicket.GetValues();
                    _DGWAssignedTicket.Rows.Add(row);
                }
                _DGWAssignedTicket.Visible = true;
            }
        }
    }
    class AgentAssignments
    {
        public int? AgentID;
        public int? OpenTicketCount;
    }
    class LoggedAgent
    {
        public int _agentID;
        public string _agentName;
        public string _agentSurname;
        public void SetValues(int id = -1, string name = "", string surname = "")
        {
            _agentID = id;
            _agentName = name;
            _agentSurname = surname;
        }
    }
    public class Ticket
    {
        public string? TicketID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public string? StatusName { get; set; }
        public string? PriorityName { get; set; }
        public string? CategoryName { get; set; }
        public string? SourceType { get; set; }
        public string? CreatedDate { get; set; }
        public string? UpdatedDate { get; set; }
        public string[] GetValues()
        {
            return [TicketID, FirstName, LastName, Email, Subject, Description, StatusName, PriorityName, CategoryName, SourceType, CreatedDate, UpdatedDate];
        }
    }
    public class AssignedTicket
    {
        public string? TicketID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public string? CategoryName { get; set; }
        public string? SourceType { get; set; }
        public string? PriorityName { get; set; }
        public string? StatusName { get; set; }
        public string? CreatedDate { get; set; }
        public string? UpdatedDate { get; set; }
        public string[] GetValues()
        {
            return [TicketID, FirstName, LastName, Subject, Description, CategoryName, SourceType, PriorityName, StatusName, CreatedDate, UpdatedDate];
        }
    }
}