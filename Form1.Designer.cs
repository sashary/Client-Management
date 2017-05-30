namespace ClientManagement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageOverview = new System.Windows.Forms.TabPage();
            this.lblClientAmountNumber = new System.Windows.Forms.Label();
            this.lblClientAmount = new System.Windows.Forms.Label();
            this.lnklblLatestClient = new System.Windows.Forms.LinkLabel();
            this.lblLatestClient = new System.Windows.Forms.Label();
            this.tabPageAddClient = new System.Windows.Forms.TabPage();
            this.btnAddClientAdd = new System.Windows.Forms.Button();
            this.cmBoxAddClientOccupation = new System.Windows.Forms.ComboBox();
            this.txtbxAddClientEmail = new System.Windows.Forms.TextBox();
            this.lblAddClientEmail = new System.Windows.Forms.Label();
            this.lblAddClientOccupation = new System.Windows.Forms.Label();
            this.txtbxAddClientAddress = new System.Windows.Forms.TextBox();
            this.lblAddClientAddress = new System.Windows.Forms.Label();
            this.txtbxAddClientDOB = new System.Windows.Forms.TextBox();
            this.lblAddClientDOB = new System.Windows.Forms.Label();
            this.txtbxAddClientLName = new System.Windows.Forms.TextBox();
            this.lblAddClientLName = new System.Windows.Forms.Label();
            this.txtbxAddClientFName = new System.Windows.Forms.TextBox();
            this.lblAddClientFName = new System.Windows.Forms.Label();
            this.tabPageModifyClient = new System.Windows.Forms.TabPage();
            this.btnEditClientDelete = new System.Windows.Forms.Button();
            this.txtbxEditClientID = new System.Windows.Forms.TextBox();
            this.lblEditClientID = new System.Windows.Forms.Label();
            this.btnEditClientSave = new System.Windows.Forms.Button();
            this.cmBoxEditClientOccupation = new System.Windows.Forms.ComboBox();
            this.txtbxEditClientEmail = new System.Windows.Forms.TextBox();
            this.lblEditClientEmail = new System.Windows.Forms.Label();
            this.lblEditClientOccupation = new System.Windows.Forms.Label();
            this.txtbxEditClientAddress = new System.Windows.Forms.TextBox();
            this.lblEditClientAddress = new System.Windows.Forms.Label();
            this.txtbxEditClientDOB = new System.Windows.Forms.TextBox();
            this.lblEditClientDOB = new System.Windows.Forms.Label();
            this.txtbxEditClientLName = new System.Windows.Forms.TextBox();
            this.lblEditClientLName = new System.Windows.Forms.Label();
            this.txtbxEditClientFName = new System.Windows.Forms.TextBox();
            this.lblEditClientFName = new System.Windows.Forms.Label();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.lstbxSearch = new System.Windows.Forms.ListBox();
            this.lblSearchInstruction2 = new System.Windows.Forms.Label();
            this.btnSearchEdit = new System.Windows.Forms.Button();
            this.txtbxSearchEdit = new System.Windows.Forms.TextBox();
            this.lblSearchInstruction1 = new System.Windows.Forms.Label();
            this.btnSearchDB = new System.Windows.Forms.Button();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl.SuspendLayout();
            this.tabPageOverview.SuspendLayout();
            this.tabPageAddClient.SuspendLayout();
            this.tabPageModifyClient.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageOverview);
            this.tabControl.Controls.Add(this.tabPageAddClient);
            this.tabControl.Controls.Add(this.tabPageModifyClient);
            this.tabControl.Controls.Add(this.tabPageSearch);
            this.tabControl.Location = new System.Drawing.Point(0, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(35, 22);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(663, 382);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabStop = false;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.OnTabIndexChange);
            // 
            // tabPageOverview
            // 
            this.tabPageOverview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPageOverview.Controls.Add(this.lblClientAmountNumber);
            this.tabPageOverview.Controls.Add(this.lblClientAmount);
            this.tabPageOverview.Controls.Add(this.lnklblLatestClient);
            this.tabPageOverview.Controls.Add(this.lblLatestClient);
            this.tabPageOverview.Location = new System.Drawing.Point(4, 60);
            this.tabPageOverview.Name = "tabPageOverview";
            this.tabPageOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOverview.Size = new System.Drawing.Size(655, 318);
            this.tabPageOverview.TabIndex = 0;
            this.tabPageOverview.Text = "Overview";
            this.tabPageOverview.UseVisualStyleBackColor = true;
            // 
            // lblClientAmountNumber
            // 
            this.lblClientAmountNumber.AutoSize = true;
            this.lblClientAmountNumber.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAmountNumber.Location = new System.Drawing.Point(386, 151);
            this.lblClientAmountNumber.Name = "lblClientAmountNumber";
            this.lblClientAmountNumber.Size = new System.Drawing.Size(22, 24);
            this.lblClientAmountNumber.TabIndex = 4;
            this.lblClientAmountNumber.Text = "0";
            // 
            // lblClientAmount
            // 
            this.lblClientAmount.AutoSize = true;
            this.lblClientAmount.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAmount.Location = new System.Drawing.Point(385, 112);
            this.lblClientAmount.Name = "lblClientAmount";
            this.lblClientAmount.Size = new System.Drawing.Size(174, 24);
            this.lblClientAmount.TabIndex = 3;
            this.lblClientAmount.Text = "Amount of Clients";
            // 
            // lnklblLatestClient
            // 
            this.lnklblLatestClient.AutoSize = true;
            this.lnklblLatestClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblLatestClient.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lnklblLatestClient.Location = new System.Drawing.Point(55, 151);
            this.lnklblLatestClient.Name = "lnklblLatestClient";
            this.lnklblLatestClient.Size = new System.Drawing.Size(57, 24);
            this.lnklblLatestClient.TabIndex = 2;
            this.lnklblLatestClient.TabStop = true;
            this.lnklblLatestClient.Text = "None";
            this.lnklblLatestClient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblLatestClient_LinkClicked);
            // 
            // lblLatestClient
            // 
            this.lblLatestClient.AutoSize = true;
            this.lblLatestClient.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatestClient.Location = new System.Drawing.Point(54, 112);
            this.lblLatestClient.Name = "lblLatestClient";
            this.lblLatestClient.Size = new System.Drawing.Size(125, 24);
            this.lblLatestClient.TabIndex = 1;
            this.lblLatestClient.Text = "Latest Client";
            // 
            // tabPageAddClient
            // 
            this.tabPageAddClient.Controls.Add(this.btnAddClientAdd);
            this.tabPageAddClient.Controls.Add(this.cmBoxAddClientOccupation);
            this.tabPageAddClient.Controls.Add(this.txtbxAddClientEmail);
            this.tabPageAddClient.Controls.Add(this.lblAddClientEmail);
            this.tabPageAddClient.Controls.Add(this.lblAddClientOccupation);
            this.tabPageAddClient.Controls.Add(this.txtbxAddClientAddress);
            this.tabPageAddClient.Controls.Add(this.lblAddClientAddress);
            this.tabPageAddClient.Controls.Add(this.txtbxAddClientDOB);
            this.tabPageAddClient.Controls.Add(this.lblAddClientDOB);
            this.tabPageAddClient.Controls.Add(this.txtbxAddClientLName);
            this.tabPageAddClient.Controls.Add(this.lblAddClientLName);
            this.tabPageAddClient.Controls.Add(this.txtbxAddClientFName);
            this.tabPageAddClient.Controls.Add(this.lblAddClientFName);
            this.tabPageAddClient.Location = new System.Drawing.Point(4, 60);
            this.tabPageAddClient.Name = "tabPageAddClient";
            this.tabPageAddClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddClient.Size = new System.Drawing.Size(655, 318);
            this.tabPageAddClient.TabIndex = 1;
            this.tabPageAddClient.Text = "Add Client";
            this.tabPageAddClient.UseVisualStyleBackColor = true;
            // 
            // btnAddClientAdd
            // 
            this.btnAddClientAdd.Location = new System.Drawing.Point(231, 239);
            this.btnAddClientAdd.Name = "btnAddClientAdd";
            this.btnAddClientAdd.Size = new System.Drawing.Size(107, 62);
            this.btnAddClientAdd.TabIndex = 17;
            this.btnAddClientAdd.TabStop = false;
            this.btnAddClientAdd.Text = "Add";
            this.btnAddClientAdd.UseVisualStyleBackColor = true;
            this.btnAddClientAdd.Click += new System.EventHandler(this.btnAddClientAdd_Click);
            // 
            // cmBoxAddClientOccupation
            // 
            this.cmBoxAddClientOccupation.FormattingEnabled = true;
            this.cmBoxAddClientOccupation.Items.AddRange(new object[] {
            "Student",
            "Employed",
            "Unemployed"});
            this.cmBoxAddClientOccupation.Location = new System.Drawing.Point(31, 190);
            this.cmBoxAddClientOccupation.Name = "cmBoxAddClientOccupation";
            this.cmBoxAddClientOccupation.Size = new System.Drawing.Size(205, 21);
            this.cmBoxAddClientOccupation.TabIndex = 16;
            this.cmBoxAddClientOccupation.TabStop = false;
            // 
            // txtbxAddClientEmail
            // 
            this.txtbxAddClientEmail.Location = new System.Drawing.Point(339, 190);
            this.txtbxAddClientEmail.Name = "txtbxAddClientEmail";
            this.txtbxAddClientEmail.Size = new System.Drawing.Size(205, 20);
            this.txtbxAddClientEmail.TabIndex = 11;
            this.txtbxAddClientEmail.TabStop = false;
            // 
            // lblAddClientEmail
            // 
            this.lblAddClientEmail.AutoSize = true;
            this.lblAddClientEmail.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddClientEmail.Location = new System.Drawing.Point(336, 169);
            this.lblAddClientEmail.Name = "lblAddClientEmail";
            this.lblAddClientEmail.Size = new System.Drawing.Size(42, 17);
            this.lblAddClientEmail.TabIndex = 10;
            this.lblAddClientEmail.Text = "Email";
            // 
            // lblAddClientOccupation
            // 
            this.lblAddClientOccupation.AutoSize = true;
            this.lblAddClientOccupation.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddClientOccupation.Location = new System.Drawing.Point(28, 169);
            this.lblAddClientOccupation.Name = "lblAddClientOccupation";
            this.lblAddClientOccupation.Size = new System.Drawing.Size(80, 17);
            this.lblAddClientOccupation.TabIndex = 8;
            this.lblAddClientOccupation.Text = "Occupation";
            // 
            // txtbxAddClientAddress
            // 
            this.txtbxAddClientAddress.Location = new System.Drawing.Point(339, 125);
            this.txtbxAddClientAddress.Name = "txtbxAddClientAddress";
            this.txtbxAddClientAddress.Size = new System.Drawing.Size(205, 20);
            this.txtbxAddClientAddress.TabIndex = 7;
            this.txtbxAddClientAddress.TabStop = false;
            // 
            // lblAddClientAddress
            // 
            this.lblAddClientAddress.AutoSize = true;
            this.lblAddClientAddress.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddClientAddress.Location = new System.Drawing.Point(336, 104);
            this.lblAddClientAddress.Name = "lblAddClientAddress";
            this.lblAddClientAddress.Size = new System.Drawing.Size(58, 17);
            this.lblAddClientAddress.TabIndex = 6;
            this.lblAddClientAddress.Text = "Address";
            // 
            // txtbxAddClientDOB
            // 
            this.txtbxAddClientDOB.Location = new System.Drawing.Point(31, 125);
            this.txtbxAddClientDOB.Name = "txtbxAddClientDOB";
            this.txtbxAddClientDOB.Size = new System.Drawing.Size(205, 20);
            this.txtbxAddClientDOB.TabIndex = 5;
            this.txtbxAddClientDOB.TabStop = false;
            // 
            // lblAddClientDOB
            // 
            this.lblAddClientDOB.AutoSize = true;
            this.lblAddClientDOB.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddClientDOB.Location = new System.Drawing.Point(28, 104);
            this.lblAddClientDOB.Name = "lblAddClientDOB";
            this.lblAddClientDOB.Size = new System.Drawing.Size(191, 17);
            this.lblAddClientDOB.TabIndex = 4;
            this.lblAddClientDOB.Text = "Date of Birth (MM/DD/YYYY)";
            // 
            // txtbxAddClientLName
            // 
            this.txtbxAddClientLName.Location = new System.Drawing.Point(339, 55);
            this.txtbxAddClientLName.Name = "txtbxAddClientLName";
            this.txtbxAddClientLName.Size = new System.Drawing.Size(205, 20);
            this.txtbxAddClientLName.TabIndex = 3;
            this.txtbxAddClientLName.TabStop = false;
            // 
            // lblAddClientLName
            // 
            this.lblAddClientLName.AutoSize = true;
            this.lblAddClientLName.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddClientLName.Location = new System.Drawing.Point(336, 34);
            this.lblAddClientLName.Name = "lblAddClientLName";
            this.lblAddClientLName.Size = new System.Drawing.Size(76, 17);
            this.lblAddClientLName.TabIndex = 2;
            this.lblAddClientLName.Text = "Last Name";
            // 
            // txtbxAddClientFName
            // 
            this.txtbxAddClientFName.Location = new System.Drawing.Point(31, 55);
            this.txtbxAddClientFName.Name = "txtbxAddClientFName";
            this.txtbxAddClientFName.Size = new System.Drawing.Size(205, 20);
            this.txtbxAddClientFName.TabIndex = 1;
            this.txtbxAddClientFName.TabStop = false;
            // 
            // lblAddClientFName
            // 
            this.lblAddClientFName.AutoSize = true;
            this.lblAddClientFName.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddClientFName.Location = new System.Drawing.Point(28, 34);
            this.lblAddClientFName.Name = "lblAddClientFName";
            this.lblAddClientFName.Size = new System.Drawing.Size(76, 17);
            this.lblAddClientFName.TabIndex = 0;
            this.lblAddClientFName.Text = "First Name";
            // 
            // tabPageModifyClient
            // 
            this.tabPageModifyClient.Controls.Add(this.btnEditClientDelete);
            this.tabPageModifyClient.Controls.Add(this.txtbxEditClientID);
            this.tabPageModifyClient.Controls.Add(this.lblEditClientID);
            this.tabPageModifyClient.Controls.Add(this.btnEditClientSave);
            this.tabPageModifyClient.Controls.Add(this.cmBoxEditClientOccupation);
            this.tabPageModifyClient.Controls.Add(this.txtbxEditClientEmail);
            this.tabPageModifyClient.Controls.Add(this.lblEditClientEmail);
            this.tabPageModifyClient.Controls.Add(this.lblEditClientOccupation);
            this.tabPageModifyClient.Controls.Add(this.txtbxEditClientAddress);
            this.tabPageModifyClient.Controls.Add(this.lblEditClientAddress);
            this.tabPageModifyClient.Controls.Add(this.txtbxEditClientDOB);
            this.tabPageModifyClient.Controls.Add(this.lblEditClientDOB);
            this.tabPageModifyClient.Controls.Add(this.txtbxEditClientLName);
            this.tabPageModifyClient.Controls.Add(this.lblEditClientLName);
            this.tabPageModifyClient.Controls.Add(this.txtbxEditClientFName);
            this.tabPageModifyClient.Controls.Add(this.lblEditClientFName);
            this.tabPageModifyClient.Location = new System.Drawing.Point(4, 60);
            this.tabPageModifyClient.Name = "tabPageModifyClient";
            this.tabPageModifyClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModifyClient.Size = new System.Drawing.Size(655, 318);
            this.tabPageModifyClient.TabIndex = 2;
            this.tabPageModifyClient.Text = "Modify Client";
            this.tabPageModifyClient.UseVisualStyleBackColor = true;
            // 
            // btnEditClientDelete
            // 
            this.btnEditClientDelete.Location = new System.Drawing.Point(452, 238);
            this.btnEditClientDelete.Name = "btnEditClientDelete";
            this.btnEditClientDelete.Size = new System.Drawing.Size(92, 62);
            this.btnEditClientDelete.TabIndex = 32;
            this.btnEditClientDelete.TabStop = false;
            this.btnEditClientDelete.Text = "Delete";
            this.btnEditClientDelete.UseVisualStyleBackColor = true;
            this.btnEditClientDelete.Click += new System.EventHandler(this.btnEditClientDelete_Click);
            // 
            // txtbxEditClientID
            // 
            this.txtbxEditClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxEditClientID.Location = new System.Drawing.Point(31, 55);
            this.txtbxEditClientID.Name = "txtbxEditClientID";
            this.txtbxEditClientID.ReadOnly = true;
            this.txtbxEditClientID.Size = new System.Drawing.Size(205, 20);
            this.txtbxEditClientID.TabIndex = 31;
            this.txtbxEditClientID.TabStop = false;
            // 
            // lblEditClientID
            // 
            this.lblEditClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEditClientID.AutoSize = true;
            this.lblEditClientID.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditClientID.Location = new System.Drawing.Point(28, 34);
            this.lblEditClientID.Name = "lblEditClientID";
            this.lblEditClientID.Size = new System.Drawing.Size(23, 17);
            this.lblEditClientID.TabIndex = 30;
            this.lblEditClientID.Text = "ID";
            // 
            // btnEditClientSave
            // 
            this.btnEditClientSave.Location = new System.Drawing.Point(339, 239);
            this.btnEditClientSave.Name = "btnEditClientSave";
            this.btnEditClientSave.Size = new System.Drawing.Size(92, 62);
            this.btnEditClientSave.TabIndex = 29;
            this.btnEditClientSave.TabStop = false;
            this.btnEditClientSave.Text = "Save";
            this.btnEditClientSave.UseVisualStyleBackColor = true;
            this.btnEditClientSave.Click += new System.EventHandler(this.btnEditClientSave_Click);
            // 
            // cmBoxEditClientOccupation
            // 
            this.cmBoxEditClientOccupation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmBoxEditClientOccupation.FormattingEnabled = true;
            this.cmBoxEditClientOccupation.Items.AddRange(new object[] {
            "Student",
            "Employed",
            "Unemployed",
            "Unknown"});
            this.cmBoxEditClientOccupation.Location = new System.Drawing.Point(31, 260);
            this.cmBoxEditClientOccupation.Name = "cmBoxEditClientOccupation";
            this.cmBoxEditClientOccupation.Size = new System.Drawing.Size(205, 21);
            this.cmBoxEditClientOccupation.TabIndex = 28;
            this.cmBoxEditClientOccupation.TabStop = false;
            // 
            // txtbxEditClientEmail
            // 
            this.txtbxEditClientEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxEditClientEmail.Location = new System.Drawing.Point(339, 190);
            this.txtbxEditClientEmail.Name = "txtbxEditClientEmail";
            this.txtbxEditClientEmail.Size = new System.Drawing.Size(205, 20);
            this.txtbxEditClientEmail.TabIndex = 27;
            this.txtbxEditClientEmail.TabStop = false;
            // 
            // lblEditClientEmail
            // 
            this.lblEditClientEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEditClientEmail.AutoSize = true;
            this.lblEditClientEmail.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditClientEmail.Location = new System.Drawing.Point(336, 169);
            this.lblEditClientEmail.Name = "lblEditClientEmail";
            this.lblEditClientEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEditClientEmail.TabIndex = 26;
            this.lblEditClientEmail.Text = "Email";
            // 
            // lblEditClientOccupation
            // 
            this.lblEditClientOccupation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEditClientOccupation.AutoSize = true;
            this.lblEditClientOccupation.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditClientOccupation.Location = new System.Drawing.Point(28, 239);
            this.lblEditClientOccupation.Name = "lblEditClientOccupation";
            this.lblEditClientOccupation.Size = new System.Drawing.Size(80, 17);
            this.lblEditClientOccupation.TabIndex = 25;
            this.lblEditClientOccupation.Text = "Occupation";
            // 
            // txtbxEditClientAddress
            // 
            this.txtbxEditClientAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxEditClientAddress.Location = new System.Drawing.Point(339, 125);
            this.txtbxEditClientAddress.Name = "txtbxEditClientAddress";
            this.txtbxEditClientAddress.Size = new System.Drawing.Size(205, 20);
            this.txtbxEditClientAddress.TabIndex = 24;
            this.txtbxEditClientAddress.TabStop = false;
            // 
            // lblEditClientAddress
            // 
            this.lblEditClientAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEditClientAddress.AutoSize = true;
            this.lblEditClientAddress.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditClientAddress.Location = new System.Drawing.Point(336, 104);
            this.lblEditClientAddress.Name = "lblEditClientAddress";
            this.lblEditClientAddress.Size = new System.Drawing.Size(58, 17);
            this.lblEditClientAddress.TabIndex = 23;
            this.lblEditClientAddress.Text = "Address";
            // 
            // txtbxEditClientDOB
            // 
            this.txtbxEditClientDOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxEditClientDOB.Location = new System.Drawing.Point(31, 195);
            this.txtbxEditClientDOB.Name = "txtbxEditClientDOB";
            this.txtbxEditClientDOB.Size = new System.Drawing.Size(205, 20);
            this.txtbxEditClientDOB.TabIndex = 22;
            this.txtbxEditClientDOB.TabStop = false;
            // 
            // lblEditClientDOB
            // 
            this.lblEditClientDOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEditClientDOB.AutoSize = true;
            this.lblEditClientDOB.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditClientDOB.Location = new System.Drawing.Point(28, 174);
            this.lblEditClientDOB.Name = "lblEditClientDOB";
            this.lblEditClientDOB.Size = new System.Drawing.Size(191, 17);
            this.lblEditClientDOB.TabIndex = 21;
            this.lblEditClientDOB.Text = "Date of Birth (MM/DD/YYYY)";
            // 
            // txtbxEditClientLName
            // 
            this.txtbxEditClientLName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxEditClientLName.Location = new System.Drawing.Point(31, 125);
            this.txtbxEditClientLName.Name = "txtbxEditClientLName";
            this.txtbxEditClientLName.Size = new System.Drawing.Size(205, 20);
            this.txtbxEditClientLName.TabIndex = 20;
            this.txtbxEditClientLName.TabStop = false;
            // 
            // lblEditClientLName
            // 
            this.lblEditClientLName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEditClientLName.AutoSize = true;
            this.lblEditClientLName.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditClientLName.Location = new System.Drawing.Point(28, 104);
            this.lblEditClientLName.Name = "lblEditClientLName";
            this.lblEditClientLName.Size = new System.Drawing.Size(76, 17);
            this.lblEditClientLName.TabIndex = 19;
            this.lblEditClientLName.Text = "Last Name";
            // 
            // txtbxEditClientFName
            // 
            this.txtbxEditClientFName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxEditClientFName.Location = new System.Drawing.Point(339, 55);
            this.txtbxEditClientFName.Name = "txtbxEditClientFName";
            this.txtbxEditClientFName.Size = new System.Drawing.Size(205, 20);
            this.txtbxEditClientFName.TabIndex = 18;
            this.txtbxEditClientFName.TabStop = false;
            // 
            // lblEditClientFName
            // 
            this.lblEditClientFName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEditClientFName.AutoSize = true;
            this.lblEditClientFName.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditClientFName.Location = new System.Drawing.Point(336, 34);
            this.lblEditClientFName.Name = "lblEditClientFName";
            this.lblEditClientFName.Size = new System.Drawing.Size(76, 17);
            this.lblEditClientFName.TabIndex = 17;
            this.lblEditClientFName.Text = "First Name";
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.lstbxSearch);
            this.tabPageSearch.Controls.Add(this.lblSearchInstruction2);
            this.tabPageSearch.Controls.Add(this.btnSearchEdit);
            this.tabPageSearch.Controls.Add(this.txtbxSearchEdit);
            this.tabPageSearch.Controls.Add(this.lblSearchInstruction1);
            this.tabPageSearch.Controls.Add(this.btnSearchDB);
            this.tabPageSearch.Controls.Add(this.txtbxSearch);
            this.tabPageSearch.Controls.Add(this.lblSearch);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 60);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(655, 318);
            this.tabPageSearch.TabIndex = 3;
            this.tabPageSearch.Text = "Search";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // lstbxSearch
            // 
            this.lstbxSearch.FormattingEnabled = true;
            this.lstbxSearch.Location = new System.Drawing.Point(11, 68);
            this.lstbxSearch.Name = "lstbxSearch";
            this.lstbxSearch.Size = new System.Drawing.Size(269, 238);
            this.lstbxSearch.TabIndex = 27;
            this.lstbxSearch.TabStop = false;
            // 
            // lblSearchInstruction2
            // 
            this.lblSearchInstruction2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchInstruction2.AutoSize = true;
            this.lblSearchInstruction2.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchInstruction2.Location = new System.Drawing.Point(286, 147);
            this.lblSearchInstruction2.Name = "lblSearchInstruction2";
            this.lblSearchInstruction2.Size = new System.Drawing.Size(301, 17);
            this.lblSearchInstruction2.TabIndex = 26;
            this.lblSearchInstruction2.Text = "Type the ID and press Edit to modify the client";
            // 
            // btnSearchEdit
            // 
            this.btnSearchEdit.Location = new System.Drawing.Point(289, 198);
            this.btnSearchEdit.Name = "btnSearchEdit";
            this.btnSearchEdit.Size = new System.Drawing.Size(76, 32);
            this.btnSearchEdit.TabIndex = 25;
            this.btnSearchEdit.TabStop = false;
            this.btnSearchEdit.Text = "Edit";
            this.btnSearchEdit.UseVisualStyleBackColor = true;
            this.btnSearchEdit.Click += new System.EventHandler(this.btnSearchEdit_Click);
            // 
            // txtbxSearchEdit
            // 
            this.txtbxSearchEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxSearchEdit.Location = new System.Drawing.Point(289, 172);
            this.txtbxSearchEdit.Name = "txtbxSearchEdit";
            this.txtbxSearchEdit.Size = new System.Drawing.Size(269, 20);
            this.txtbxSearchEdit.TabIndex = 24;
            this.txtbxSearchEdit.TabStop = false;
            // 
            // lblSearchInstruction1
            // 
            this.lblSearchInstruction1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchInstruction1.AutoSize = true;
            this.lblSearchInstruction1.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchInstruction1.Location = new System.Drawing.Point(286, 122);
            this.lblSearchInstruction1.Name = "lblSearchInstruction1";
            this.lblSearchInstruction1.Size = new System.Drawing.Size(293, 17);
            this.lblSearchInstruction1.TabIndex = 23;
            this.lblSearchInstruction1.Text = "If a name shows up, an ID will follow with it. ";
            // 
            // btnSearchDB
            // 
            this.btnSearchDB.Location = new System.Drawing.Point(280, 34);
            this.btnSearchDB.Name = "btnSearchDB";
            this.btnSearchDB.Size = new System.Drawing.Size(59, 20);
            this.btnSearchDB.TabIndex = 22;
            this.btnSearchDB.TabStop = false;
            this.btnSearchDB.Text = "Search";
            this.btnSearchDB.UseVisualStyleBackColor = true;
            this.btnSearchDB.Click += new System.EventHandler(this.btnSearchDB_Click);
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxSearch.Location = new System.Drawing.Point(11, 34);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(269, 20);
            this.txtbxSearch.TabIndex = 20;
            this.txtbxSearch.TabStop = false;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(8, 12);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(519, 17);
            this.lblSearch.TabIndex = 19;
            this.lblSearch.Text = "Insert first name followed by a comma and last name (Ex: FirstName,LastName)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(663, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearDatabaseToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.editToolStripMenuItem.Text = "Database";
            // 
            // clearDatabaseToolStripMenuItem
            // 
            this.clearDatabaseToolStripMenuItem.Name = "clearDatabaseToolStripMenuItem";
            this.clearDatabaseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearDatabaseToolStripMenuItem.Text = "Clear Database";
            this.clearDatabaseToolStripMenuItem.Click += new System.EventHandler(this.clearDatabaseToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(663, 406);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Client Storage Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageOverview.ResumeLayout(false);
            this.tabPageOverview.PerformLayout();
            this.tabPageAddClient.ResumeLayout(false);
            this.tabPageAddClient.PerformLayout();
            this.tabPageModifyClient.ResumeLayout(false);
            this.tabPageModifyClient.PerformLayout();
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageOverview;
        private System.Windows.Forms.TabPage tabPageAddClient;
        private System.Windows.Forms.TabPage tabPageModifyClient;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.TextBox txtbxAddClientLName;
        private System.Windows.Forms.Label lblAddClientLName;
        private System.Windows.Forms.TextBox txtbxAddClientFName;
        private System.Windows.Forms.Label lblAddClientFName;
        private System.Windows.Forms.ComboBox cmBoxAddClientOccupation;
        private System.Windows.Forms.TextBox txtbxAddClientEmail;
        private System.Windows.Forms.Label lblAddClientEmail;
        private System.Windows.Forms.Label lblAddClientOccupation;
        private System.Windows.Forms.TextBox txtbxAddClientAddress;
        private System.Windows.Forms.Label lblAddClientAddress;
        private System.Windows.Forms.Label lblAddClientDOB;
        private System.Windows.Forms.TextBox txtbxAddClientDOB;
        private System.Windows.Forms.ComboBox cmBoxEditClientOccupation;
        private System.Windows.Forms.TextBox txtbxEditClientEmail;
        private System.Windows.Forms.Label lblEditClientEmail;
        private System.Windows.Forms.Label lblEditClientOccupation;
        private System.Windows.Forms.TextBox txtbxEditClientAddress;
        private System.Windows.Forms.Label lblEditClientAddress;
        private System.Windows.Forms.TextBox txtbxEditClientDOB;
        private System.Windows.Forms.Label lblEditClientDOB;
        private System.Windows.Forms.TextBox txtbxEditClientLName;
        private System.Windows.Forms.Label lblEditClientLName;
        private System.Windows.Forms.TextBox txtbxEditClientFName;
        private System.Windows.Forms.Label lblEditClientFName;
        private System.Windows.Forms.Button btnAddClientAdd;
        private System.Windows.Forms.Button btnEditClientSave;
        private System.Windows.Forms.Label lblLatestClient;
        private System.Windows.Forms.Label lblClientAmountNumber;
        private System.Windows.Forms.Label lblClientAmount;
        private System.Windows.Forms.LinkLabel lnklblLatestClient;
        private System.Windows.Forms.TextBox txtbxEditClientID;
        private System.Windows.Forms.Label lblEditClientID;
        private System.Windows.Forms.Button btnEditClientDelete;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnSearchDB;
        private System.Windows.Forms.TextBox txtbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblSearchInstruction2;
        private System.Windows.Forms.Button btnSearchEdit;
        private System.Windows.Forms.TextBox txtbxSearchEdit;
        private System.Windows.Forms.Label lblSearchInstruction1;
        private System.Windows.Forms.ListBox lstbxSearch;
    }
}

