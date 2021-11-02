
namespace DataBaseApp
{
    partial class DataCRUDForm
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
            this.dgData = new System.Windows.Forms.DataGridView();
            this.lblEmpno = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtEmpno = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtHireDate = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgData
            // 
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(7, 305);
            this.dgData.Name = "dgData";
            this.dgData.RowHeadersWidth = 62;
            this.dgData.RowTemplate.Height = 33;
            this.dgData.Size = new System.Drawing.Size(787, 116);
            this.dgData.TabIndex = 0;
            // 
            // lblEmpno
            // 
            this.lblEmpno.AutoSize = true;
            this.lblEmpno.Location = new System.Drawing.Point(153, 47);
            this.lblEmpno.Name = "lblEmpno";
            this.lblEmpno.Size = new System.Drawing.Size(69, 25);
            this.lblEmpno.TabIndex = 1;
            this.lblEmpno.Text = "Empno";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(153, 99);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(95, 25);
            this.lblEmpName.TabIndex = 2;
            this.lblEmpName.Text = "EmpName";
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Location = new System.Drawing.Point(153, 157);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(81, 25);
            this.lblHireDate.TabIndex = 3;
            this.lblHireDate.Text = "HireDate";
            this.lblHireDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(153, 211);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(59, 25);
            this.lblSalary.TabIndex = 4;
            this.lblSalary.Text = "Salary";
            // 
            // txtEmpno
            // 
            this.txtEmpno.Location = new System.Drawing.Point(321, 47);
            this.txtEmpno.Name = "txtEmpno";
            this.txtEmpno.Size = new System.Drawing.Size(150, 31);
            this.txtEmpno.TabIndex = 5;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(321, 96);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(150, 31);
            this.txtEmpName.TabIndex = 6;
            // 
            // txtHireDate
            // 
            this.txtHireDate.Location = new System.Drawing.Point(321, 154);
            this.txtHireDate.Name = "txtHireDate";
            this.txtHireDate.Size = new System.Drawing.Size(150, 31);
            this.txtHireDate.TabIndex = 7;
            this.txtHireDate.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(321, 211);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(150, 31);
            this.txtSalary.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(25, 252);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 34);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(153, 252);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(112, 34);
            this.btnAddEmp.TabIndex = 10;
            this.btnAddEmp.Text = "Add Emp";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(643, 252);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 34);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // DataCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtHireDate);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtEmpno);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblHireDate);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.lblEmpno);
            this.Controls.Add(this.dgData);
            this.Name = "DataCRUDForm";
            this.Text = "DataCRUDForm";
            this.Load += new System.EventHandler(this.DataCRUDForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.Label lblEmpno;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtEmpno;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtHireDate;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnSearch;
    }
}