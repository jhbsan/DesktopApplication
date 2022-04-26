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
            this.panel1.SuspendLayout();
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
            // 
            // btnFetchEmployeeDetails
            // 
            this.btnFetchEmployeeDetails.Location = new System.Drawing.Point(170, 20);
            this.btnFetchEmployeeDetails.Name = "btnFetchEmployeeDetails";
            this.btnFetchEmployeeDetails.Size = new System.Drawing.Size(156, 26);
            this.btnFetchEmployeeDetails.TabIndex = 3;
            this.btnFetchEmployeeDetails.Text = "Fetch All Employee Details";
            this.btnFetchEmployeeDetails.UseVisualStyleBackColor = true;
            // 
            // btnUpdateEmployeeDetails
            // 
            this.btnUpdateEmployeeDetails.Location = new System.Drawing.Point(341, 20);
            this.btnUpdateEmployeeDetails.Name = "btnUpdateEmployeeDetails";
            this.btnUpdateEmployeeDetails.Size = new System.Drawing.Size(141, 26);
            this.btnUpdateEmployeeDetails.TabIndex = 4;
            this.btnUpdateEmployeeDetails.Text = "Update Employee Details";
            this.btnUpdateEmployeeDetails.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmployeDetails
            // 
            this.btnDeleteEmployeDetails.Location = new System.Drawing.Point(497, 20);
            this.btnDeleteEmployeDetails.Name = "btnDeleteEmployeDetails";
            this.btnDeleteEmployeDetails.Size = new System.Drawing.Size(141, 26);
            this.btnDeleteEmployeDetails.TabIndex = 5;
            this.btnDeleteEmployeDetails.Text = "Delete Employee Details";
            this.btnDeleteEmployeDetails.UseVisualStyleBackColor = true;
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
            this.Name = "frmCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD Operations on Employee Table";
            this.panel1.ResumeLayout(false);
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
    }
}