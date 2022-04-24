namespace DesktopApp
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
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnStudentDataInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblInsertResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.BackColor = System.Drawing.Color.LightCoral;
            this.btnTestConnection.ForeColor = System.Drawing.Color.White;
            this.btnTestConnection.Location = new System.Drawing.Point(138, 21);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(195, 35);
            this.btnTestConnection.TabIndex = 0;
            this.btnTestConnection.Text = "Test DB Connection ";
            this.btnTestConnection.UseVisualStyleBackColor = false;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblResult.Location = new System.Drawing.Point(135, 63);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 18);
            this.lblResult.TabIndex = 1;
            // 
            // btnStudentDataInsert
            // 
            this.btnStudentDataInsert.Location = new System.Drawing.Point(65, 200);
            this.btnStudentDataInsert.Name = "btnStudentDataInsert";
            this.btnStudentDataInsert.Size = new System.Drawing.Size(213, 31);
            this.btnStudentDataInsert.TabIndex = 3;
            this.btnStudentDataInsert.Text = "Insert Data into Student Table";
            this.btnStudentDataInsert.UseVisualStyleBackColor = true;
            this.btnStudentDataInsert.Click += new System.EventHandler(this.btnStudentDataInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Note: Student ID is Generated Automatically";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(107, 131);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(182, 22);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(107, 160);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(182, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblInsertResult
            // 
            this.lblInsertResult.AutoSize = true;
            this.lblInsertResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblInsertResult.Location = new System.Drawing.Point(62, 234);
            this.lblInsertResult.Name = "lblInsertResult";
            this.lblInsertResult.Size = new System.Drawing.Size(0, 15);
            this.lblInsertResult.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(294, 200);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 31);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 365);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblInsertResult);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStudentDataInsert);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnTestConnection);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DbTesting using NHibernate Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnStudentDataInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblInsertResult;
        private System.Windows.Forms.Button btnClear;
    }
}

