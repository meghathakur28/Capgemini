namespace WinSerializeDemo
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
            this.EmployeeID = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.Label();
            this.btnBinSerialize = new System.Windows.Forms.Button();
            this.btnBinDeSeriallize = new System.Windows.Forms.Button();
            this.btnXMLSerialize = new System.Windows.Forms.Button();
            this.btnXMLDeSerialize = new System.Windows.Forms.Button();
            this.btnSOAPSerialize = new System.Windows.Forms.Button();
            this.btnSOAPDeSerialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeID
            // 
            this.EmployeeID.AutoSize = true;
            this.EmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeID.Location = new System.Drawing.Point(228, 140);
            this.EmployeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(92, 16);
            this.EmployeeID.TabIndex = 0;
            this.EmployeeID.Text = "EmployeeID";
            this.EmployeeID.Click += new System.EventHandler(this.label1_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(228, 182);
            this.Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(48, 16);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name";
            this.Name.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(336, 137);
            this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(148, 22);
            this.txtEmployeeID.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(336, 182);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 22);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(336, 225);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(148, 22);
            this.txtSalary.TabIndex = 6;
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary.Location = new System.Drawing.Point(228, 229);
            this.Salary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(52, 16);
            this.Salary.TabIndex = 4;
            this.Salary.Text = "Salary";
            this.Salary.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnBinSerialize
            // 
            this.btnBinSerialize.Location = new System.Drawing.Point(91, 294);
            this.btnBinSerialize.Name = "btnBinSerialize";
            this.btnBinSerialize.Size = new System.Drawing.Size(164, 23);
            this.btnBinSerialize.TabIndex = 7;
            this.btnBinSerialize.Text = "Bin Serialize";
            this.btnBinSerialize.UseVisualStyleBackColor = true;
            this.btnBinSerialize.Click += new System.EventHandler(this.btnBinSerialize_Click);
            // 
            // btnBinDeSeriallize
            // 
            this.btnBinDeSeriallize.Location = new System.Drawing.Point(91, 345);
            this.btnBinDeSeriallize.Name = "btnBinDeSeriallize";
            this.btnBinDeSeriallize.Size = new System.Drawing.Size(164, 23);
            this.btnBinDeSeriallize.TabIndex = 8;
            this.btnBinDeSeriallize.Text = "Bin DeSerialize";
            this.btnBinDeSeriallize.UseVisualStyleBackColor = true;
            this.btnBinDeSeriallize.Click += new System.EventHandler(this.btnBinDeSeriallize_Click);
            // 
            // btnXMLSerialize
            // 
            this.btnXMLSerialize.Location = new System.Drawing.Point(290, 294);
            this.btnXMLSerialize.Name = "btnXMLSerialize";
            this.btnXMLSerialize.Size = new System.Drawing.Size(151, 23);
            this.btnXMLSerialize.TabIndex = 9;
            this.btnXMLSerialize.Text = "XML Serialize";
            this.btnXMLSerialize.UseVisualStyleBackColor = true;
            this.btnXMLSerialize.Click += new System.EventHandler(this.btnXMLSerialize_Click);
            // 
            // btnXMLDeSerialize
            // 
            this.btnXMLDeSerialize.Location = new System.Drawing.Point(290, 345);
            this.btnXMLDeSerialize.Name = "btnXMLDeSerialize";
            this.btnXMLDeSerialize.Size = new System.Drawing.Size(151, 23);
            this.btnXMLDeSerialize.TabIndex = 10;
            this.btnXMLDeSerialize.Text = "XML DeSerialize";
            this.btnXMLDeSerialize.UseVisualStyleBackColor = true;
            this.btnXMLDeSerialize.Click += new System.EventHandler(this.btnXMLDeSerialize_Click);
            // 
            // btnSOAPSerialize
            // 
            this.btnSOAPSerialize.Location = new System.Drawing.Point(508, 294);
            this.btnSOAPSerialize.Name = "btnSOAPSerialize";
            this.btnSOAPSerialize.Size = new System.Drawing.Size(169, 23);
            this.btnSOAPSerialize.TabIndex = 11;
            this.btnSOAPSerialize.Text = "SOAP Serialize";
            this.btnSOAPSerialize.UseVisualStyleBackColor = true;
            this.btnSOAPSerialize.Click += new System.EventHandler(this.btnSOAPSerialize_Click);
            // 
            // btnSOAPDeSerialize
            // 
            this.btnSOAPDeSerialize.Location = new System.Drawing.Point(508, 345);
            this.btnSOAPDeSerialize.Name = "btnSOAPDeSerialize";
            this.btnSOAPDeSerialize.Size = new System.Drawing.Size(169, 23);
            this.btnSOAPDeSerialize.TabIndex = 12;
            this.btnSOAPDeSerialize.Text = "SOAP De Serialize";
            this.btnSOAPDeSerialize.UseVisualStyleBackColor = true;
            this.btnSOAPDeSerialize.Click += new System.EventHandler(this.btnSOAPDeSeriallize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.btnSOAPDeSerialize);
            this.Controls.Add(this.btnSOAPSerialize);
            this.Controls.Add(this.btnXMLDeSerialize);
            this.Controls.Add(this.btnXMLSerialize);
            this.Controls.Add(this.btnBinDeSeriallize);
            this.Controls.Add(this.btnBinSerialize);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.EmployeeID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            //this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeID;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.Button btnBinDeSeriallize;
        private System.Windows.Forms.Button btnXMLSerialize;
        private System.Windows.Forms.Button btnXMLDeSerialize;
        private System.Windows.Forms.Button btnSOAPSerialize;
        private System.Windows.Forms.Button btnSOAPDeSerialize;
        private System.Windows.Forms.Button btnBinSerialize;
    }
}

