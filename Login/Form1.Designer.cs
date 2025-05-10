namespace Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCustomerOperations = new Button();
            buttonEmployeeOperations = new Button();
            panelCustomerOperations = new Panel();
            panelQueryTicket = new Panel();
            dataGridViewQueryTicket = new DataGridView();
            textBoxDeneme = new TextBox();
            comboBoxTicketStatusQueryTicket = new ComboBox();
            buttonQueryTicketsQueryTicket = new Button();
            textBoxEmailQueryTicket = new TextBox();
            textBoxLastNameQueryTicket = new TextBox();
            textBoxFirstNameQueryTicket = new TextBox();
            buttonBackToCustomerOperationsFromQueryTicket = new Button();
            buttonQueryTicket = new Button();
            panelCreateTicket = new Panel();
            buttonBackToCustomerOperationsFromCreateTicket = new Button();
            buttonSubmitCreateTicket = new Button();
            textBoxSubjectCreateTicket = new TextBox();
            textBoxDescriptionCreateTicket = new TextBox();
            comboBoxCategoryNameCreateTicket = new ComboBox();
            textBoxEmailCreateTicket = new TextBox();
            textBoxLastNameCreateTicket = new TextBox();
            textBoxFirstNameCreateTicket = new TextBox();
            buttonBackToMainFromCustomerOperations = new Button();
            buttonCreateTicket = new Button();
            panelEmployeeOperations = new Panel();
            panelEmployeeLoggedIn = new Panel();
            dataGridViewAssignedTicketsLoggedIn = new DataGridView();
            labelAssignedTicketsLoggedIn = new Label();
            buttonLogOut = new Button();
            labelWelcomeLoggedIn = new Label();
            textBoxPassword = new TextBox();
            textBoxUsernameOrEmail = new TextBox();
            buttonBackToMainFromEmployeeOperations = new Button();
            buttonEmployeeLogin = new Button();
            panelCustomerOperations.SuspendLayout();
            panelQueryTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewQueryTicket).BeginInit();
            panelCreateTicket.SuspendLayout();
            panelEmployeeOperations.SuspendLayout();
            panelEmployeeLoggedIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssignedTicketsLoggedIn).BeginInit();
            SuspendLayout();
            // 
            // buttonCustomerOperations
            // 
            buttonCustomerOperations.Location = new Point(50, 50);
            buttonCustomerOperations.Name = "buttonCustomerOperations";
            buttonCustomerOperations.Size = new Size(200, 200);
            buttonCustomerOperations.TabIndex = 0;
            buttonCustomerOperations.Text = "Customer Operations";
            buttonCustomerOperations.UseVisualStyleBackColor = true;
            buttonCustomerOperations.Click += buttonCustomerOperations_Click;
            // 
            // buttonEmployeeOperations
            // 
            buttonEmployeeOperations.Location = new Point(300, 50);
            buttonEmployeeOperations.Name = "buttonEmployeeOperations";
            buttonEmployeeOperations.Size = new Size(200, 200);
            buttonEmployeeOperations.TabIndex = 1;
            buttonEmployeeOperations.Text = "Employee Operations";
            buttonEmployeeOperations.UseVisualStyleBackColor = true;
            buttonEmployeeOperations.Click += buttonEmployeeOperations_Click;
            // 
            // panelCustomerOperations
            // 
            panelCustomerOperations.Controls.Add(panelQueryTicket);
            panelCustomerOperations.Controls.Add(buttonQueryTicket);
            panelCustomerOperations.Controls.Add(panelCreateTicket);
            panelCustomerOperations.Controls.Add(buttonBackToMainFromCustomerOperations);
            panelCustomerOperations.Controls.Add(buttonCreateTicket);
            panelCustomerOperations.Enabled = false;
            panelCustomerOperations.Location = new Point(550, 50);
            panelCustomerOperations.Name = "panelCustomerOperations";
            panelCustomerOperations.Size = new Size(1347, 983);
            panelCustomerOperations.TabIndex = 2;
            panelCustomerOperations.Visible = false;
            // 
            // panelQueryTicket
            // 
            panelQueryTicket.Controls.Add(dataGridViewQueryTicket);
            panelQueryTicket.Controls.Add(textBoxDeneme);
            panelQueryTicket.Controls.Add(comboBoxTicketStatusQueryTicket);
            panelQueryTicket.Controls.Add(buttonQueryTicketsQueryTicket);
            panelQueryTicket.Controls.Add(textBoxEmailQueryTicket);
            panelQueryTicket.Controls.Add(textBoxLastNameQueryTicket);
            panelQueryTicket.Controls.Add(textBoxFirstNameQueryTicket);
            panelQueryTicket.Controls.Add(buttonBackToCustomerOperationsFromQueryTicket);
            panelQueryTicket.Enabled = false;
            panelQueryTicket.Location = new Point(18, 267);
            panelQueryTicket.Name = "panelQueryTicket";
            panelQueryTicket.Size = new Size(985, 410);
            panelQueryTicket.TabIndex = 4;
            panelQueryTicket.Visible = false;
            // 
            // dataGridViewQueryTicket
            // 
            dataGridViewQueryTicket.AllowUserToAddRows = false;
            dataGridViewQueryTicket.AllowUserToDeleteRows = false;
            dataGridViewQueryTicket.AllowUserToOrderColumns = true;
            dataGridViewQueryTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewQueryTicket.Location = new Point(14, 141);
            dataGridViewQueryTicket.Name = "dataGridViewQueryTicket";
            dataGridViewQueryTicket.RowHeadersWidth = 51;
            dataGridViewQueryTicket.Size = new Size(955, 251);
            dataGridViewQueryTicket.TabIndex = 4;
            dataGridViewQueryTicket.Visible = false;
            // 
            // textBoxDeneme
            // 
            textBoxDeneme.Location = new Point(14, 87);
            textBoxDeneme.Name = "textBoxDeneme";
            textBoxDeneme.Size = new Size(955, 27);
            textBoxDeneme.TabIndex = 6;
            // 
            // comboBoxTicketStatusQueryTicket
            // 
            comboBoxTicketStatusQueryTicket.FormattingEnabled = true;
            comboBoxTicketStatusQueryTicket.Items.AddRange(new object[] { "Open", "Close", "All" });
            comboBoxTicketStatusQueryTicket.Location = new Point(473, 28);
            comboBoxTicketStatusQueryTicket.Name = "comboBoxTicketStatusQueryTicket";
            comboBoxTicketStatusQueryTicket.Size = new Size(151, 28);
            comboBoxTicketStatusQueryTicket.TabIndex = 5;
            comboBoxTicketStatusQueryTicket.Text = "Ticket Status";
            comboBoxTicketStatusQueryTicket.SelectedIndexChanged += comboBoxTicketStatusQueryTicket_SelectedIndexChanged;
            // 
            // buttonQueryTicketsQueryTicket
            // 
            buttonQueryTicketsQueryTicket.Location = new Point(651, 28);
            buttonQueryTicketsQueryTicket.Name = "buttonQueryTicketsQueryTicket";
            buttonQueryTicketsQueryTicket.Size = new Size(94, 29);
            buttonQueryTicketsQueryTicket.TabIndex = 4;
            buttonQueryTicketsQueryTicket.Text = "Query";
            buttonQueryTicketsQueryTicket.UseVisualStyleBackColor = true;
            buttonQueryTicketsQueryTicket.Click += buttonQueryTicketsQueryTicket_Click;
            // 
            // textBoxEmailQueryTicket
            // 
            textBoxEmailQueryTicket.Location = new Point(316, 27);
            textBoxEmailQueryTicket.Name = "textBoxEmailQueryTicket";
            textBoxEmailQueryTicket.PlaceholderText = "Email";
            textBoxEmailQueryTicket.Size = new Size(125, 27);
            textBoxEmailQueryTicket.TabIndex = 3;
            textBoxEmailQueryTicket.TextChanged += textBoxEmailQueryTicket_TextChanged;
            // 
            // textBoxLastNameQueryTicket
            // 
            textBoxLastNameQueryTicket.Location = new Point(166, 27);
            textBoxLastNameQueryTicket.Name = "textBoxLastNameQueryTicket";
            textBoxLastNameQueryTicket.PlaceholderText = "Last Name";
            textBoxLastNameQueryTicket.Size = new Size(125, 27);
            textBoxLastNameQueryTicket.TabIndex = 2;
            textBoxLastNameQueryTicket.TextChanged += textBoxLastNameQueryTicket_TextChanged;
            // 
            // textBoxFirstNameQueryTicket
            // 
            textBoxFirstNameQueryTicket.Location = new Point(14, 27);
            textBoxFirstNameQueryTicket.Name = "textBoxFirstNameQueryTicket";
            textBoxFirstNameQueryTicket.PlaceholderText = "First Name";
            textBoxFirstNameQueryTicket.Size = new Size(125, 27);
            textBoxFirstNameQueryTicket.TabIndex = 1;
            textBoxFirstNameQueryTicket.TextChanged += textBoxFirstNameQueryTicket_TextChanged;
            // 
            // buttonBackToCustomerOperationsFromQueryTicket
            // 
            buttonBackToCustomerOperationsFromQueryTicket.Location = new Point(888, 3);
            buttonBackToCustomerOperationsFromQueryTicket.Name = "buttonBackToCustomerOperationsFromQueryTicket";
            buttonBackToCustomerOperationsFromQueryTicket.Size = new Size(94, 29);
            buttonBackToCustomerOperationsFromQueryTicket.TabIndex = 0;
            buttonBackToCustomerOperationsFromQueryTicket.Text = "Back";
            buttonBackToCustomerOperationsFromQueryTicket.UseVisualStyleBackColor = true;
            buttonBackToCustomerOperationsFromQueryTicket.Click += buttonBackToCustomerOperationsFromQueryTicket_Click;
            // 
            // buttonQueryTicket
            // 
            buttonQueryTicket.Location = new Point(250, 0);
            buttonQueryTicket.Name = "buttonQueryTicket";
            buttonQueryTicket.Size = new Size(200, 200);
            buttonQueryTicket.TabIndex = 0;
            buttonQueryTicket.Text = "Query Ticket";
            buttonQueryTicket.UseVisualStyleBackColor = true;
            buttonQueryTicket.Click += buttonQueryTicket_Click;
            // 
            // panelCreateTicket
            // 
            panelCreateTicket.Controls.Add(buttonBackToCustomerOperationsFromCreateTicket);
            panelCreateTicket.Controls.Add(buttonSubmitCreateTicket);
            panelCreateTicket.Controls.Add(textBoxSubjectCreateTicket);
            panelCreateTicket.Controls.Add(textBoxDescriptionCreateTicket);
            panelCreateTicket.Controls.Add(comboBoxCategoryNameCreateTicket);
            panelCreateTicket.Controls.Add(textBoxEmailCreateTicket);
            panelCreateTicket.Controls.Add(textBoxLastNameCreateTicket);
            panelCreateTicket.Controls.Add(textBoxFirstNameCreateTicket);
            panelCreateTicket.Enabled = false;
            panelCreateTicket.Location = new Point(18, 267);
            panelCreateTicket.Name = "panelCreateTicket";
            panelCreateTicket.Size = new Size(600, 410);
            panelCreateTicket.TabIndex = 3;
            panelCreateTicket.Visible = false;
            // 
            // buttonBackToCustomerOperationsFromCreateTicket
            // 
            buttonBackToCustomerOperationsFromCreateTicket.Location = new Point(500, 0);
            buttonBackToCustomerOperationsFromCreateTicket.Name = "buttonBackToCustomerOperationsFromCreateTicket";
            buttonBackToCustomerOperationsFromCreateTicket.Size = new Size(94, 29);
            buttonBackToCustomerOperationsFromCreateTicket.TabIndex = 13;
            buttonBackToCustomerOperationsFromCreateTicket.Text = "Back";
            buttonBackToCustomerOperationsFromCreateTicket.UseVisualStyleBackColor = true;
            buttonBackToCustomerOperationsFromCreateTicket.Click += buttonBackToCustomerOperationsFromCreateTicket_Click;
            // 
            // buttonSubmitCreateTicket
            // 
            buttonSubmitCreateTicket.Location = new Point(250, 180);
            buttonSubmitCreateTicket.Name = "buttonSubmitCreateTicket";
            buttonSubmitCreateTicket.Size = new Size(94, 29);
            buttonSubmitCreateTicket.TabIndex = 12;
            buttonSubmitCreateTicket.Text = "Submit";
            buttonSubmitCreateTicket.UseVisualStyleBackColor = true;
            buttonSubmitCreateTicket.Click += buttonSubmitCreateTicket_Click;
            // 
            // textBoxSubjectCreateTicket
            // 
            textBoxSubjectCreateTicket.Location = new Point(250, 0);
            textBoxSubjectCreateTicket.Name = "textBoxSubjectCreateTicket";
            textBoxSubjectCreateTicket.PlaceholderText = "Subject";
            textBoxSubjectCreateTicket.Size = new Size(125, 27);
            textBoxSubjectCreateTicket.TabIndex = 11;
            // 
            // textBoxDescriptionCreateTicket
            // 
            textBoxDescriptionCreateTicket.Location = new Point(250, 60);
            textBoxDescriptionCreateTicket.Name = "textBoxDescriptionCreateTicket";
            textBoxDescriptionCreateTicket.PlaceholderText = "Description";
            textBoxDescriptionCreateTicket.Size = new Size(125, 27);
            textBoxDescriptionCreateTicket.TabIndex = 10;
            // 
            // comboBoxCategoryNameCreateTicket
            // 
            comboBoxCategoryNameCreateTicket.FormattingEnabled = true;
            comboBoxCategoryNameCreateTicket.Items.AddRange(new object[] { "Technical Issue", "Billing", "Account Support", "Feature Request", "General Inquiry" });
            comboBoxCategoryNameCreateTicket.Location = new Point(250, 120);
            comboBoxCategoryNameCreateTicket.Name = "comboBoxCategoryNameCreateTicket";
            comboBoxCategoryNameCreateTicket.Size = new Size(151, 28);
            comboBoxCategoryNameCreateTicket.TabIndex = 9;
            comboBoxCategoryNameCreateTicket.Text = "Category Name";
            // 
            // textBoxEmailCreateTicket
            // 
            textBoxEmailCreateTicket.Location = new Point(0, 120);
            textBoxEmailCreateTicket.Name = "textBoxEmailCreateTicket";
            textBoxEmailCreateTicket.PlaceholderText = "Email";
            textBoxEmailCreateTicket.Size = new Size(125, 27);
            textBoxEmailCreateTicket.TabIndex = 8;
            textBoxEmailCreateTicket.TextChanged += textBoxEmailCreateTicket_TextChanged;
            // 
            // textBoxLastNameCreateTicket
            // 
            textBoxLastNameCreateTicket.Location = new Point(0, 60);
            textBoxLastNameCreateTicket.Name = "textBoxLastNameCreateTicket";
            textBoxLastNameCreateTicket.PlaceholderText = "Last Name";
            textBoxLastNameCreateTicket.Size = new Size(125, 27);
            textBoxLastNameCreateTicket.TabIndex = 7;
            // 
            // textBoxFirstNameCreateTicket
            // 
            textBoxFirstNameCreateTicket.Location = new Point(0, 0);
            textBoxFirstNameCreateTicket.Name = "textBoxFirstNameCreateTicket";
            textBoxFirstNameCreateTicket.PlaceholderText = "First Name";
            textBoxFirstNameCreateTicket.Size = new Size(125, 27);
            textBoxFirstNameCreateTicket.TabIndex = 0;
            // 
            // buttonBackToMainFromCustomerOperations
            // 
            buttonBackToMainFromCustomerOperations.Location = new Point(1250, 3);
            buttonBackToMainFromCustomerOperations.Name = "buttonBackToMainFromCustomerOperations";
            buttonBackToMainFromCustomerOperations.Size = new Size(94, 29);
            buttonBackToMainFromCustomerOperations.TabIndex = 2;
            buttonBackToMainFromCustomerOperations.Text = "Back";
            buttonBackToMainFromCustomerOperations.UseVisualStyleBackColor = true;
            buttonBackToMainFromCustomerOperations.Click += buttonBackToMainFromCustomerOperations_Click;
            // 
            // buttonCreateTicket
            // 
            buttonCreateTicket.Location = new Point(0, 0);
            buttonCreateTicket.Name = "buttonCreateTicket";
            buttonCreateTicket.Size = new Size(200, 200);
            buttonCreateTicket.TabIndex = 1;
            buttonCreateTicket.Text = "Create Ticket";
            buttonCreateTicket.UseVisualStyleBackColor = true;
            buttonCreateTicket.Click += buttonCreateTicket_Click;
            // 
            // panelEmployeeOperations
            // 
            panelEmployeeOperations.Controls.Add(panelEmployeeLoggedIn);
            panelEmployeeOperations.Controls.Add(textBoxPassword);
            panelEmployeeOperations.Controls.Add(textBoxUsernameOrEmail);
            panelEmployeeOperations.Controls.Add(buttonBackToMainFromEmployeeOperations);
            panelEmployeeOperations.Controls.Add(buttonEmployeeLogin);
            panelEmployeeOperations.Enabled = false;
            panelEmployeeOperations.Location = new Point(550, 50);
            panelEmployeeOperations.Name = "panelEmployeeOperations";
            panelEmployeeOperations.Size = new Size(1347, 983);
            panelEmployeeOperations.TabIndex = 3;
            panelEmployeeOperations.Visible = false;
            // 
            // panelEmployeeLoggedIn
            // 
            panelEmployeeLoggedIn.Controls.Add(dataGridViewAssignedTicketsLoggedIn);
            panelEmployeeLoggedIn.Controls.Add(labelAssignedTicketsLoggedIn);
            panelEmployeeLoggedIn.Controls.Add(buttonLogOut);
            panelEmployeeLoggedIn.Controls.Add(labelWelcomeLoggedIn);
            panelEmployeeLoggedIn.Enabled = false;
            panelEmployeeLoggedIn.Location = new Point(0, 0);
            panelEmployeeLoggedIn.Name = "panelEmployeeLoggedIn";
            panelEmployeeLoggedIn.Size = new Size(1344, 977);
            panelEmployeeLoggedIn.TabIndex = 4;
            panelEmployeeLoggedIn.Visible = false;
            // 
            // dataGridViewAssignedTicketsLoggedIn
            // 
            dataGridViewAssignedTicketsLoggedIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAssignedTicketsLoggedIn.Location = new Point(30, 113);
            dataGridViewAssignedTicketsLoggedIn.Name = "dataGridViewAssignedTicketsLoggedIn";
            dataGridViewAssignedTicketsLoggedIn.RowHeadersWidth = 51;
            dataGridViewAssignedTicketsLoggedIn.Size = new Size(1210, 243);
            dataGridViewAssignedTicketsLoggedIn.TabIndex = 3;
            dataGridViewAssignedTicketsLoggedIn.Visible = false;
            // 
            // labelAssignedTicketsLoggedIn
            // 
            labelAssignedTicketsLoggedIn.AutoSize = true;
            labelAssignedTicketsLoggedIn.Location = new Point(30, 90);
            labelAssignedTicketsLoggedIn.Name = "labelAssignedTicketsLoggedIn";
            labelAssignedTicketsLoggedIn.Size = new Size(118, 20);
            labelAssignedTicketsLoggedIn.TabIndex = 2;
            labelAssignedTicketsLoggedIn.Text = "Assigned Tickets";
            // 
            // buttonLogOut
            // 
            buttonLogOut.Location = new Point(1251, 1);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(94, 29);
            buttonLogOut.TabIndex = 1;
            buttonLogOut.Text = "Log Out";
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // labelWelcomeLoggedIn
            // 
            labelWelcomeLoggedIn.AutoSize = true;
            labelWelcomeLoggedIn.Location = new Point(30, 21);
            labelWelcomeLoggedIn.Name = "labelWelcomeLoggedIn";
            labelWelcomeLoggedIn.Size = new Size(71, 20);
            labelWelcomeLoggedIn.TabIndex = 0;
            labelWelcomeLoggedIn.Text = "Welcome";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(3, 97);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(140, 27);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // textBoxUsernameOrEmail
            // 
            textBoxUsernameOrEmail.Location = new Point(3, 48);
            textBoxUsernameOrEmail.Name = "textBoxUsernameOrEmail";
            textBoxUsernameOrEmail.PlaceholderText = "E-mail";
            textBoxUsernameOrEmail.Size = new Size(140, 27);
            textBoxUsernameOrEmail.TabIndex = 2;
            textBoxUsernameOrEmail.TextChanged += textBoxUsernameOrEmail_TextChanged;
            // 
            // buttonBackToMainFromEmployeeOperations
            // 
            buttonBackToMainFromEmployeeOperations.Location = new Point(215, 21);
            buttonBackToMainFromEmployeeOperations.Name = "buttonBackToMainFromEmployeeOperations";
            buttonBackToMainFromEmployeeOperations.Size = new Size(94, 29);
            buttonBackToMainFromEmployeeOperations.TabIndex = 1;
            buttonBackToMainFromEmployeeOperations.Text = "Back";
            buttonBackToMainFromEmployeeOperations.UseVisualStyleBackColor = true;
            buttonBackToMainFromEmployeeOperations.Click += buttonBackToMainFromEmployeeOperations_Click;
            // 
            // buttonEmployeeLogin
            // 
            buttonEmployeeLogin.Location = new Point(49, 151);
            buttonEmployeeLogin.Name = "buttonEmployeeLogin";
            buttonEmployeeLogin.Size = new Size(94, 29);
            buttonEmployeeLogin.TabIndex = 0;
            buttonEmployeeLogin.Text = "Login";
            buttonEmployeeLogin.UseVisualStyleBackColor = true;
            buttonEmployeeLogin.Click += buttonEmployeeLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panelCustomerOperations);
            Controls.Add(buttonCustomerOperations);
            Controls.Add(buttonEmployeeOperations);
            Controls.Add(panelEmployeeOperations);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panelCustomerOperations.ResumeLayout(false);
            panelQueryTicket.ResumeLayout(false);
            panelQueryTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewQueryTicket).EndInit();
            panelCreateTicket.ResumeLayout(false);
            panelCreateTicket.PerformLayout();
            panelEmployeeOperations.ResumeLayout(false);
            panelEmployeeOperations.PerformLayout();
            panelEmployeeLoggedIn.ResumeLayout(false);
            panelEmployeeLoggedIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssignedTicketsLoggedIn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCustomerOperations;
        private Button buttonEmployeeOperations;
        private Panel panelCustomerOperations;
        private Button buttonCreateTicket;
        private Button buttonQueryTicket;
        private Button buttonBackToMainFromCustomerOperations;
        private Panel panelEmployeeOperations;
        private Button buttonEmployeeLogin;
        private Button buttonBackToMainFromEmployeeOperations;
        private TextBox textBoxPassword;
        private TextBox textBoxUsernameOrEmail;
        private Panel panelCreateTicket;
        private TextBox textBoxFirstNameCreateTicket;
        private TextBox textBoxEmailCreateTicket;
        private TextBox textBoxLastNameCreateTicket;
        private ComboBox comboBoxCategoryNameCreateTicket;
        private TextBox textBoxDescriptionCreateTicket;
        private TextBox textBoxSubjectCreateTicket;
        private Button buttonSubmitCreateTicket;
        private Button buttonBackToCustomerOperationsFromCreateTicket;
        private Panel panelQueryTicket;
        private Button buttonBackToCustomerOperationsFromQueryTicket;
        private TextBox textBoxEmailQueryTicket;
        private TextBox textBoxLastNameQueryTicket;
        private TextBox textBoxFirstNameQueryTicket;
        private Button buttonQueryTicketsQueryTicket;
        private ComboBox comboBoxTicketStatusQueryTicket;
        private TextBox textBoxDeneme;
        private DataGridView dataGridViewQueryTicket;
        private Panel panelEmployeeLoggedIn;
        private Label labelWelcomeLoggedIn;
        private Button buttonLogOut;
        private Label labelAssignedTicketsLoggedIn;
        private DataGridView dataGridViewAssignedTicketsLoggedIn;
    }
}
