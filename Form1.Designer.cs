
namespace Eclerx.Question4.Jatin
{
    partial class lblEmployeeDetails
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
            this.lblEmpNo = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblEmpSal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnAddNew = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.txtEmpNo = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpSalary = new System.Windows.Forms.TextBox();
            this.GPEmpType = new System.Windows.Forms.GroupBox();
            this.RadioConsultant = new System.Windows.Forms.RadioButton();
            this.RadioPayroll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GPEmpType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmpNo
            // 
            this.lblEmpNo.AutoSize = true;
            this.lblEmpNo.Location = new System.Drawing.Point(0, 25);
            this.lblEmpNo.Name = "lblEmpNo";
            this.lblEmpNo.Size = new System.Drawing.Size(103, 20);
            this.lblEmpNo.TabIndex = 0;
            this.lblEmpNo.Text = "Employee No";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(0, 75);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(125, 20);
            this.lblEmpName.TabIndex = 1;
            this.lblEmpName.Text = "Employee Name";
            // 
            // lblEmpSal
            // 
            this.lblEmpSal.AutoSize = true;
            this.lblEmpSal.Location = new System.Drawing.Point(0, 123);
            this.lblEmpSal.Name = "lblEmpSal";
            this.lblEmpSal.Size = new System.Drawing.Size(53, 20);
            this.lblEmpSal.TabIndex = 2;
            this.lblEmpSal.Text = "Salary";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(793, 221);
            this.dataGridView1.TabIndex = 8;
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.Location = new System.Drawing.Point(283, 188);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Size = new System.Drawing.Size(90, 33);
            this.BtnAddNew.TabIndex = 9;
            this.BtnAddNew.Text = "Add New";
            this.BtnAddNew.UseVisualStyleBackColor = true;
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(415, 188);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(91, 33);
            this.BtnReset.TabIndex = 10;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.Location = new System.Drawing.Point(170, 23);
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.Size = new System.Drawing.Size(203, 26);
            this.txtEmpNo.TabIndex = 11;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(170, 69);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(203, 26);
            this.txtEmpName.TabIndex = 12;
            // 
            // txtEmpSalary
            // 
            this.txtEmpSalary.Location = new System.Drawing.Point(170, 123);
            this.txtEmpSalary.Name = "txtEmpSalary";
            this.txtEmpSalary.Size = new System.Drawing.Size(203, 26);
            this.txtEmpSalary.TabIndex = 13;
            // 
            // GPEmpType
            // 
            this.GPEmpType.Controls.Add(this.RadioConsultant);
            this.GPEmpType.Controls.Add(this.RadioPayroll);
            this.GPEmpType.Location = new System.Drawing.Point(480, 25);
            this.GPEmpType.Name = "GPEmpType";
            this.GPEmpType.Size = new System.Drawing.Size(227, 124);
            this.GPEmpType.TabIndex = 14;
            this.GPEmpType.TabStop = false;
            this.GPEmpType.Text = "Employee Type";
            // 
            // RadioConsultant
            // 
            this.RadioConsultant.AutoSize = true;
            this.RadioConsultant.Location = new System.Drawing.Point(6, 85);
            this.RadioConsultant.Name = "RadioConsultant";
            this.RadioConsultant.Size = new System.Drawing.Size(111, 24);
            this.RadioConsultant.TabIndex = 1;
            this.RadioConsultant.TabStop = true;
            this.RadioConsultant.Text = "Consultant";
            this.RadioConsultant.UseVisualStyleBackColor = true;
            // 
            // RadioPayroll
            // 
            this.RadioPayroll.AutoSize = true;
            this.RadioPayroll.Location = new System.Drawing.Point(6, 44);
            this.RadioPayroll.Name = "RadioPayroll";
            this.RadioPayroll.Size = new System.Drawing.Size(80, 24);
            this.RadioPayroll.TabIndex = 0;
            this.RadioPayroll.TabStop = true;
            this.RadioPayroll.Text = "Payroll";
            this.RadioPayroll.UseVisualStyleBackColor = true;
            // 
            // lblEmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GPEmpType);
            this.Controls.Add(this.txtEmpSalary);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtEmpNo);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnAddNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblEmpSal);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.lblEmpNo);
            this.Name = "lblEmployeeDetails";
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.lblEmployeeDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GPEmpType.ResumeLayout(false);
            this.GPEmpType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpNo;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblEmpSal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAddNew;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.TextBox txtEmpNo;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpSalary;
        private System.Windows.Forms.GroupBox GPEmpType;
        private System.Windows.Forms.RadioButton RadioConsultant;
        private System.Windows.Forms.RadioButton RadioPayroll;
    }
}

