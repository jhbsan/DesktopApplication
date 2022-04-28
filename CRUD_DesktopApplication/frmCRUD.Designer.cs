namespace CRUD_DesktopApplication
{
    partial class frmCRUD
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
            this.btnGoBack = new System.Windows.Forms.Button();
            this.gpCreate = new System.Windows.Forms.GroupBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnFetchEmployeeDetails = new System.Windows.Forms.Button();
            this.btnUpdateEmployeeDetails = new System.Windows.Forms.Button();
            this.btnDeleteEmployeDetails = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.DojPicker = new System.Windows.Forms.DateTimePicker();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnSaveEmployeeDetails = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgEmployeesShow = new System.Windows.Forms.DataGridView();
            this.gpFetch = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.btnFetchByID = new System.Windows.Forms.Button();
            this.dgFetchID = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgFetchAllEmployees = new System.Windows.Forms.DataGridView();
            this.btnFetchAllEmployeeDetails = new System.Windows.Forms.Button();
            this.GpUpdate = new System.Windows.Forms.GroupBox();
            this.dgUpdateResult = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblUpdateResult = new System.Windows.Forms.Label();
            this.txtFullNameforUpdate = new System.Windows.Forms.TextBox();
            this.txtEmailforUpdate = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.GpDelete = new System.Windows.Forms.GroupBox();
            this.lblDeleteResult = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DgDelete = new System.Windows.Forms.DataGridView();
            this.gpCreate.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployeesShow)).BeginInit();
            this.gpFetch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFetchID)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFetchAllEmployees)).BeginInit();
            this.GpUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUpdateResult)).BeginInit();
            this.GpDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(559, 9);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(118, 22);
            this.btnGoBack.TabIndex = 0;
            this.btnGoBack.Text = "Back to Main Form";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // gpCreate
            // 
            this.gpCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpCreate.BackColor = System.Drawing.Color.White;
            this.gpCreate.Controls.Add(this.gpFetch);
            this.gpCreate.Controls.Add(this.dgEmployeesShow);
            this.gpCreate.Controls.Add(this.btnExit);
            this.gpCreate.Controls.Add(this.btnSaveEmployeeDetails);
            this.gpCreate.Controls.Add(this.txtSalary);
            this.gpCreate.Controls.Add(this.txtEmailAddress);
            this.gpCreate.Controls.Add(this.txtDepartment);
            this.gpCreate.Controls.Add(this.DojPicker);
            this.gpCreate.Controls.Add(this.txtFullName);
            this.gpCreate.Controls.Add(this.label6);
            this.gpCreate.Controls.Add(this.label5);
            this.gpCreate.Controls.Add(this.label4);
            this.gpCreate.Controls.Add(this.label3);
            this.gpCreate.Controls.Add(this.label2);
            this.gpCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCreate.Location = new System.Drawing.Point(36, 124);
            this.gpCreate.Name = "gpCreate";
            this.gpCreate.Size = new System.Drawing.Size(641, 404);
            this.gpCreate.TabIndex = 1;
            this.gpCreate.TabStop = false;
            this.gpCreate.Text = "Add Employee Details [ Create Operation]";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(12, 20);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(141, 26);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "Add Employee Details";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnFetchEmployeeDetails
            // 
            this.btnFetchEmployeeDetails.Location = new System.Drawing.Point(170, 20);
            this.btnFetchEmployeeDetails.Name = "btnFetchEmployeeDetails";
            this.btnFetchEmployeeDetails.Size = new System.Drawing.Size(156, 26);
            this.btnFetchEmployeeDetails.TabIndex = 3;
            this.btnFetchEmployeeDetails.Text = "Fetch All Employee Details";
            this.btnFetchEmployeeDetails.UseVisualStyleBackColor = true;
            this.btnFetchEmployeeDetails.Click += new System.EventHandler(this.btnFetchEmployeeDetails_Click);
            // 
            // btnUpdateEmployeeDetails
            // 
            this.btnUpdateEmployeeDetails.Location = new System.Drawing.Point(341, 20);
            this.btnUpdateEmployeeDetails.Name = "btnUpdateEmployeeDetails";
            this.btnUpdateEmployeeDetails.Size = new System.Drawing.Size(141, 26);
            this.btnUpdateEmployeeDetails.TabIndex = 4;
            this.btnUpdateEmployeeDetails.Text = "Update Employee Details";
            this.btnUpdateEmployeeDetails.UseVisualStyleBackColor = true;
            this.btnUpdateEmployeeDetails.Click += new System.EventHandler(this.btnUpdateEmployeeDetails_Click);
            // 
            // btnDeleteEmployeDetails
            // 
            this.btnDeleteEmployeDetails.Location = new System.Drawing.Point(497, 20);
            this.btnDeleteEmployeDetails.Name = "btnDeleteEmployeDetails";
            this.btnDeleteEmployeDetails.Size = new System.Drawing.Size(141, 26);
            this.btnDeleteEmployeDetails.TabIndex = 5;
            this.btnDeleteEmployeDetails.Text = "Delete Employee Details";
            this.btnDeleteEmployeDetails.UseVisualStyleBackColor = true;
            this.btnDeleteEmployeDetails.Click += new System.EventHandler(this.btnDeleteEmployeDetails_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAddEmployee);
            this.panel1.Controls.Add(this.btnDeleteEmployeDetails);
            this.panel1.Controls.Add(this.btnFetchEmployeeDetails);
            this.panel1.Controls.Add(this.btnUpdateEmployeeDetails);
            this.panel1.Location = new System.Drawing.Point(24, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 63);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Performing CRUD Operations on Employee Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date of Joining";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Salary";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(186, 30);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(239, 21);
            this.txtFullName.TabIndex = 1;
            // 
            // DojPicker
            // 
            this.DojPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DojPicker.Location = new System.Drawing.Point(186, 67);
            this.DojPicker.Name = "DojPicker";
            this.DojPicker.Size = new System.Drawing.Size(239, 21);
            this.DojPicker.TabIndex = 2;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(186, 103);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(239, 21);
            this.txtDepartment.TabIndex = 3;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(186, 137);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(239, 21);
            this.txtEmailAddress.TabIndex = 4;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(186, 171);
            this.txtSalary.MaxLength = 8;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(239, 21);
            this.txtSalary.TabIndex = 5;
            // 
            // btnSaveEmployeeDetails
            // 
            this.btnSaveEmployeeDetails.Location = new System.Drawing.Point(101, 202);
            this.btnSaveEmployeeDetails.Name = "btnSaveEmployeeDetails";
            this.btnSaveEmployeeDetails.Size = new System.Drawing.Size(167, 28);
            this.btnSaveEmployeeDetails.TabIndex = 6;
            this.btnSaveEmployeeDetails.Text = "Save Employee Details";
            this.btnSaveEmployeeDetails.UseVisualStyleBackColor = true;
            this.btnSaveEmployeeDetails.Click += new System.EventHandler(this.btnSaveEmployeeDetails_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(295, 202);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 28);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Close and Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgEmployeesShow
            // 
            this.dgEmployeesShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployeesShow.Location = new System.Drawing.Point(24, 234);
            this.dgEmployeesShow.Name = "dgEmployeesShow";
            this.dgEmployeesShow.Size = new System.Drawing.Size(603, 163);
            this.dgEmployeesShow.TabIndex = 8;
            // 
            // gpFetch
            // 
            this.gpFetch.Controls.Add(this.GpUpdate);
            this.gpFetch.Controls.Add(this.btnFetchAllEmployeeDetails);
            this.gpFetch.Controls.Add(this.panel2);
            this.gpFetch.Controls.Add(this.dgFetchID);
            this.gpFetch.Controls.Add(this.btnFetchByID);
            this.gpFetch.Controls.Add(this.txtEmployeeID);
            this.gpFetch.Controls.Add(this.label9);
            this.gpFetch.Controls.Add(this.label8);
            this.gpFetch.Controls.Add(this.label7);
            this.gpFetch.Location = new System.Drawing.Point(1, -2);
            this.gpFetch.Name = "gpFetch";
            this.gpFetch.Size = new System.Drawing.Size(638, 401);
            this.gpFetch.TabIndex = 9;
            this.gpFetch.TabStop = false;
            this.gpFetch.Text = "Fetch All Employee Details OR Fetch Employee Details by ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Employee ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(90, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(180, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Fetch Employee Details by ID";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(109, 52);
            this.txtEmployeeID.MaxLength = 8;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(131, 21);
            this.txtEmployeeID.TabIndex = 6;
            // 
            // btnFetchByID
            // 
            this.btnFetchByID.Location = new System.Drawing.Point(258, 48);
            this.btnFetchByID.Name = "btnFetchByID";
            this.btnFetchByID.Size = new System.Drawing.Size(70, 28);
            this.btnFetchByID.TabIndex = 10;
            this.btnFetchByID.Text = "Search";
            this.btnFetchByID.UseVisualStyleBackColor = true;
            this.btnFetchByID.Click += new System.EventHandler(this.btnFetchByID_Click);
            // 
            // dgFetchID
            // 
            this.dgFetchID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFetchID.Location = new System.Drawing.Point(18, 88);
            this.dgFetchID.Name = "dgFetchID";
            this.dgFetchID.Size = new System.Drawing.Size(603, 61);
            this.dgFetchID.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgFetchAllEmployees);
            this.panel2.Location = new System.Drawing.Point(17, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 207);
            this.panel2.TabIndex = 12;
            // 
            // dgFetchAllEmployees
            // 
            this.dgFetchAllEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFetchAllEmployees.Location = new System.Drawing.Point(-1, -1);
            this.dgFetchAllEmployees.Name = "dgFetchAllEmployees";
            this.dgFetchAllEmployees.Size = new System.Drawing.Size(603, 203);
            this.dgFetchAllEmployees.TabIndex = 12;
            // 
            // btnFetchAllEmployeeDetails
            // 
            this.btnFetchAllEmployeeDetails.Location = new System.Drawing.Point(33, 155);
            this.btnFetchAllEmployeeDetails.Name = "btnFetchAllEmployeeDetails";
            this.btnFetchAllEmployeeDetails.Size = new System.Drawing.Size(265, 28);
            this.btnFetchAllEmployeeDetails.TabIndex = 13;
            this.btnFetchAllEmployeeDetails.Text = "Get All Employee Details";
            this.btnFetchAllEmployeeDetails.UseVisualStyleBackColor = true;
            this.btnFetchAllEmployeeDetails.Click += new System.EventHandler(this.btnFetchAllEmployeeDetails_Click);
            // 
            // GpUpdate
            // 
            this.GpUpdate.Controls.Add(this.GpDelete);
            this.GpUpdate.Controls.Add(this.label16);
            this.GpUpdate.Controls.Add(this.label15);
            this.GpUpdate.Controls.Add(this.txtEmailforUpdate);
            this.GpUpdate.Controls.Add(this.txtFullNameforUpdate);
            this.GpUpdate.Controls.Add(this.lblUpdateResult);
            this.GpUpdate.Controls.Add(this.dgUpdateResult);
            this.GpUpdate.Controls.Add(this.btnUpdate);
            this.GpUpdate.Controls.Add(this.txtUpdate);
            this.GpUpdate.Controls.Add(this.label11);
            this.GpUpdate.Controls.Add(this.label12);
            this.GpUpdate.Location = new System.Drawing.Point(0, 2);
            this.GpUpdate.Name = "GpUpdate";
            this.GpUpdate.Size = new System.Drawing.Size(638, 401);
            this.GpUpdate.TabIndex = 14;
            this.GpUpdate.TabStop = false;
            this.GpUpdate.Text = "Update Employee Details";
            // 
            // dgUpdateResult
            // 
            this.dgUpdateResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUpdateResult.Location = new System.Drawing.Point(18, 88);
            this.dgUpdateResult.Name = "dgUpdateResult";
            this.dgUpdateResult.Size = new System.Drawing.Size(603, 304);
            this.dgUpdateResult.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(550, 52);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 28);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(109, 37);
            this.txtUpdate.MaxLength = 8;
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(131, 21);
            this.txtUpdate.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(90, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Employee ID";
            // 
            // lblUpdateResult
            // 
            this.lblUpdateResult.AutoSize = true;
            this.lblUpdateResult.ForeColor = System.Drawing.Color.Green;
            this.lblUpdateResult.Location = new System.Drawing.Point(25, 67);
            this.lblUpdateResult.Name = "lblUpdateResult";
            this.lblUpdateResult.Size = new System.Drawing.Size(0, 15);
            this.lblUpdateResult.TabIndex = 12;
            // 
            // txtFullNameforUpdate
            // 
            this.txtFullNameforUpdate.Location = new System.Drawing.Point(315, 15);
            this.txtFullNameforUpdate.MaxLength = 200;
            this.txtFullNameforUpdate.Name = "txtFullNameforUpdate";
            this.txtFullNameforUpdate.Size = new System.Drawing.Size(220, 21);
            this.txtFullNameforUpdate.TabIndex = 16;
            // 
            // txtEmailforUpdate
            // 
            this.txtEmailforUpdate.Location = new System.Drawing.Point(315, 56);
            this.txtEmailforUpdate.MaxLength = 200;
            this.txtEmailforUpdate.Name = "txtEmailforUpdate";
            this.txtEmailforUpdate.Size = new System.Drawing.Size(220, 21);
            this.txtEmailforUpdate.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(245, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 15);
            this.label15.TabIndex = 18;
            this.label15.Text = "Full Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(251, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 15);
            this.label16.TabIndex = 19;
            this.label16.Text = "Email ID";
            // 
            // GpDelete
            // 
            this.GpDelete.Controls.Add(this.DgDelete);
            this.GpDelete.Controls.Add(this.lblDeleteResult);
            this.GpDelete.Controls.Add(this.label10);
            this.GpDelete.Controls.Add(this.btnDelete);
            this.GpDelete.Controls.Add(this.txtDelete);
            this.GpDelete.Controls.Add(this.label13);
            this.GpDelete.Controls.Add(this.label14);
            this.GpDelete.Location = new System.Drawing.Point(5, 0);
            this.GpDelete.Name = "GpDelete";
            this.GpDelete.Size = new System.Drawing.Size(633, 399);
            this.GpDelete.TabIndex = 20;
            this.GpDelete.TabStop = false;
            this.GpDelete.Text = "Delete Employee Details";
            // 
            // lblDeleteResult
            // 
            this.lblDeleteResult.AutoSize = true;
            this.lblDeleteResult.ForeColor = System.Drawing.Color.Red;
            this.lblDeleteResult.Location = new System.Drawing.Point(340, 46);
            this.lblDeleteResult.Name = "lblDeleteResult";
            this.lblDeleteResult.Size = new System.Drawing.Size(0, 15);
            this.lblDeleteResult.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(334, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 15);
            this.label10.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(258, 33);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 28);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(109, 37);
            this.txtDelete.MaxLength = 8;
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(131, 21);
            this.txtDelete.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(90, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Employee ID";
            // 
            // DgDelete
            // 
            this.DgDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDelete.Location = new System.Drawing.Point(17, 66);
            this.DgDelete.Name = "DgDelete";
            this.DgDelete.Size = new System.Drawing.Size(599, 322);
            this.DgDelete.TabIndex = 14;
            // 
            // frmCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 540);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gpCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD Operations on Employee Table";
            this.Load += new System.EventHandler(this.frmCRUD_Load);
            this.gpCreate.ResumeLayout(false);
            this.gpCreate.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployeesShow)).EndInit();
            this.gpFetch.ResumeLayout(false);
            this.gpFetch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFetchID)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFetchAllEmployees)).EndInit();
            this.GpUpdate.ResumeLayout(false);
            this.GpUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUpdateResult)).EndInit();
            this.GpDelete.ResumeLayout(false);
            this.GpDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.GroupBox gpCreate;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnFetchEmployeeDetails;
        private System.Windows.Forms.Button btnUpdateEmployeeDetails;
        private System.Windows.Forms.Button btnDeleteEmployeDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgEmployeesShow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveEmployeeDetails;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.DateTimePicker DojPicker;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpFetch;
        private System.Windows.Forms.Button btnFetchAllEmployeeDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgFetchAllEmployees;
        private System.Windows.Forms.DataGridView dgFetchID;
        private System.Windows.Forms.Button btnFetchByID;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox GpUpdate;
        private System.Windows.Forms.Label lblUpdateResult;
        private System.Windows.Forms.DataGridView dgUpdateResult;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEmailforUpdate;
        private System.Windows.Forms.TextBox txtFullNameforUpdate;
        private System.Windows.Forms.GroupBox GpDelete;
        private System.Windows.Forms.Label lblDeleteResult;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView DgDelete;
    }
}