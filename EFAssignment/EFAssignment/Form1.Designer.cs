
namespace EFAssignment
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.textUserPassWord = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnSignin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(115, 96);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(94, 25);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "UserName";
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.Location = new System.Drawing.Point(115, 176);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(87, 25);
            this.lblPassWord.TabIndex = 1;
            this.lblPassWord.Text = "Password";
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(260, 93);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(150, 31);
            this.textUserName.TabIndex = 2;
            this.textUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textUserPassWord
            // 
            this.textUserPassWord.Location = new System.Drawing.Point(260, 176);
            this.textUserPassWord.Name = "textUserPassWord";
            this.textUserPassWord.Size = new System.Drawing.Size(150, 31);
            this.textUserPassWord.TabIndex = 3;
            this.textUserPassWord.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(204, 250);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(47, 25);
            this.lblMsg.TabIndex = 4;
            this.lblMsg.Text = "Msg";
            // 
            // btnSignin
            // 
            this.btnSignin.Location = new System.Drawing.Point(223, 301);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(112, 34);
            this.btnSignin.TabIndex = 5;
            this.btnSignin.Text = "Signin";
            this.btnSignin.UseVisualStyleBackColor = true;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.textUserPassWord);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.lblPassWord);
            this.Controls.Add(this.lblUserName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.TextBox textUserPassWord;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnSignin;
    }
}

