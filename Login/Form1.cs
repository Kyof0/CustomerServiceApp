using BCrypt.Net;
using Microsoft.IdentityModel.Tokens;
using System.Net.Mail;
namespace Login
{
    public partial class Form1 : Form
    {
        Database db;
        int agentID;
        string agentName;
        string agentSurname;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new Database();
        }

        private void buttonEmployeeOperations_Click(object sender, EventArgs e)
        {
            if (panelCustomerOperations.Visible || panelCustomerOperations.Enabled)
            {
                return;
            }
            panelEmployeeOperations.Enabled = true;
            panelEmployeeOperations.Visible = true;
        }

        private void buttonCustomerOperations_Click(object sender, EventArgs e)
        {
            if (panelEmployeeOperations.Visible || panelEmployeeOperations.Enabled)
            {
                return;
            }
            panelCustomerOperations.Enabled = true;
            panelCustomerOperations.Visible = true;
        }

        private void buttonQueryTicket_Click(object sender, EventArgs e)
        {
            if (panelCreateTicket.Enabled == true || panelCreateTicket.Visible == true)
            {
                return;
            }
            panelQueryTicket.Enabled = true;
            panelQueryTicket.Visible = true;
        }

        private void buttonQueryTicketsQueryTicket_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFirstNameQueryTicket.Text))
            {
                textBoxDeneme.Text = textBoxFirstNameQueryTicket.Text;
                textBoxFirstNameQueryTicket.Text = "error";
                textBoxFirstNameQueryTicket.BackColor = Color.Red;
                return;
            }
            if (string.IsNullOrEmpty(textBoxLastNameQueryTicket.Text))
            {
                textBoxDeneme.Text = textBoxLastNameQueryTicket.Text;
                textBoxLastNameQueryTicket.Text = "error";
                textBoxLastNameQueryTicket.BackColor = Color.Red;
                return;
            }
            if (!IsValid(textBoxEmailQueryTicket, 'e'))
            {
                textBoxDeneme.Text = textBoxEmailQueryTicket.Text;
                textBoxEmailQueryTicket.Text = "error";
                return;
            }
            if (comboBoxTicketStatusQueryTicket.SelectedItem is null || string.IsNullOrEmpty(comboBoxTicketStatusQueryTicket.SelectedItem.ToString()))
            {
                textBoxDeneme.Text = "status id";
                comboBoxTicketStatusQueryTicket.Text = "error";
                comboBoxTicketStatusQueryTicket.BackColor = Color.Red;
                return;
            }
            dataGridViewQueryTicket.Rows.Clear();
            var _firstname = textBoxFirstNameQueryTicket.Text;
            var _lastname = textBoxLastNameQueryTicket.Text;
            var _email = textBoxEmailQueryTicket.Text;
            var _ticketstatus = comboBoxTicketStatusQueryTicket.SelectedItem.ToString();
            //textBoxDeneme.Text = _firstname + "1" + _lastname + "2" + _email + "3" + _ticketstatus + "4";
            db.QueryTicket(_firstname, _lastname, _email, _ticketstatus, dataGridViewQueryTicket);
        }
        private void buttonBackToCustomerOperationsFromQueryTicket_Click(object sender, EventArgs e)
        {
            panelQueryTicket.Visible = false;
            panelQueryTicket.Enabled = false;
        }
        private void buttonCreateTicket_Click(object sender, EventArgs e)
        {
            if (panelQueryTicket.Enabled == true || panelQueryTicket.Visible == true)
            {
                return;
            }
            panelCreateTicket.Enabled = true;
            panelCreateTicket.Visible = true;
        }

        private void buttonSubmitCreateTicket_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFirstNameCreateTicket.Text) || string.IsNullOrEmpty(textBoxLastNameCreateTicket.Text) || string.IsNullOrEmpty(textBoxSubjectCreateTicket.Text) || string.IsNullOrEmpty(textBoxDescriptionCreateTicket.Text) || comboBoxCategoryNameCreateTicket.SelectedItem is null || string.IsNullOrEmpty(comboBoxCategoryNameCreateTicket.SelectedItem.ToString()) || !IsValid(textBoxEmailCreateTicket, 'e'))
            {
                return;
            }
            var _firstname = textBoxFirstNameCreateTicket.Text;
            var _lastname = textBoxLastNameCreateTicket.Text;
            var _email = textBoxEmailCreateTicket.Text;
            var _subject = textBoxSubjectCreateTicket.Text;
            var _description = textBoxDescriptionCreateTicket.Text;
            var _categoryname = comboBoxCategoryNameCreateTicket.SelectedItem.ToString();
            if(db.CreateTicket(_firstname, _lastname, _email, _subject, _description, _categoryname))
            {
                MessageBox.Show("Ticket created successfully");
            }
        }

        private void buttonBackToCustomerOperationsFromCreateTicket_Click(object sender, EventArgs e)
        {
            panelCreateTicket.Visible = false;
            panelCreateTicket.Enabled = false;

        }

        private void buttonBackToMainFromCustomerOperations_Click(object sender, EventArgs e)
        {
            panelCustomerOperations.Visible = false;
            panelCustomerOperations.Enabled = false;
        }

        private void buttonBackToMainFromEmployeeOperations_Click(object sender, EventArgs e)
        {
            panelEmployeeOperations.Visible = false;
            panelEmployeeOperations.Enabled = false;
        }

        private void buttonEmployeeLogin_Click(object sender, EventArgs e)
        {
            if (IsValid(textBoxUsernameOrEmail, 'e') || IsValid(textBoxPassword, 'p'))
            {
                Auth();
            }
        }

        private void textBoxEmailCreateTicket_TextChanged(object sender, EventArgs e)
        {
            textBoxEmailCreateTicket.BackColor = Color.White;
        }

        private void textBoxUsernameOrEmail_TextChanged(object sender, EventArgs e)
        {
            textBoxUsernameOrEmail.BackColor = Color.White;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.BackColor = Color.White;
        }

        private void textBoxFirstNameQueryTicket_TextChanged(object sender, EventArgs e)
        {
            textBoxFirstNameQueryTicket.BackColor = Color.White;
        }

        private void textBoxLastNameQueryTicket_TextChanged(object sender, EventArgs e)
        {
            textBoxLastNameQueryTicket.BackColor = Color.White;
        }

        private void textBoxEmailQueryTicket_TextChanged(object sender, EventArgs e)
        {
            textBoxEmailQueryTicket.BackColor = Color.White;
        }

        private void comboBoxTicketStatusQueryTicket_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTicketStatusQueryTicket.BackColor = Color.White;
        }
        void Auth()
        {
            var _loggedAgent = db.VerifyPassword(textBoxUsernameOrEmail.Text, textBoxPassword.Text);
            agentID = _loggedAgent._agentID;
            agentName = _loggedAgent._agentName;
            agentSurname = _loggedAgent._agentSurname;
            if (agentID > 0 && agentName != "" && agentSurname != "")
            {
                labelWelcomeLoggedIn.Text = "Welcome, " + agentName + " " + agentSurname;
                panelEmployeeLoggedIn.Enabled = true;
                panelEmployeeLoggedIn.Visible = true;
                db.QueryAssignedTicket("Open", agentID, dataGridViewAssignedTicketsLoggedIn);
            }
            else
            {
                textBoxUsernameOrEmail.Text = "";
                textBoxPassword.Text = "";
                textBoxPassword.BackColor = Color.Red;
                textBoxUsernameOrEmail.BackColor = Color.Red;
                textBoxUsernameOrEmail.PlaceholderText = "invalid entry";
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            agentID = -1;
            agentName = "";
            agentSurname = "";
            panelEmployeeLoggedIn.Visible = false;
            panelEmployeeLoggedIn.Enabled = false;
            dataGridViewAssignedTicketsLoggedIn.Rows.Clear();
        }

        bool IsValid(TextBox tb, char c)
        {
            if (c == 'e')
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    tb.BackColor = Color.Red;
                    return false;
                }
                try
                {
                    var test = new MailAddress(tb.Text);
                }
                catch (FormatException ex)
                {
                    tb.BackColor = Color.Red;
                    return false;
                }
                return true;
            }
            if (c == 'p')
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    tb.BackColor = Color.Red;
                    return false;
                }
                if (tb.Text.Length > 3)
                {
                    return true;
                }
                else
                {
                    tb.BackColor = Color.Red;
                    return false;
                }
            }
            return false;
        }
    }
}
