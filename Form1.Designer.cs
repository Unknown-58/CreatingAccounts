using System.Drawing;
using System.Windows.Forms;

namespace Test
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.TextBox1_Label = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.Label();
            this.FirstName_Label = new System.Windows.Forms.TextBox();
            this.LastName_Label = new System.Windows.Forms.TextBox();
            this.Login_Label = new System.Windows.Forms.TextBox();
            this.ComboBox_Domain = new System.Windows.Forms.ComboBox();
            this.Email_Label = new System.Windows.Forms.TextBox();
            this.Password_Label = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.Domain = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button1.Location = new System.Drawing.Point(151, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBox1_Label
            // 
            this.TextBox1_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TextBox1_Label.Location = new System.Drawing.Point(12, 29);
            this.TextBox1_Label.Name = "TextBox1_Label";
            this.TextBox1_Label.Size = new System.Drawing.Size(220, 21);
            this.TextBox1_Label.TabIndex = 1;
            // 
            // NameText
            // 
            this.NameText.AutoSize = true;
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.NameText.Location = new System.Drawing.Point(8, 11);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 15);
            this.NameText.TabIndex = 2;
            this.NameText.Text = "Фамилия и Имя";
            // 
            // FirstName_Label
            // 
            this.FirstName_Label.BackColor = System.Drawing.SystemColors.Control;
            this.FirstName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FirstName_Label.Location = new System.Drawing.Point(13, 69);
            this.FirstName_Label.Name = "FirstName_Label";
            this.FirstName_Label.ReadOnly = true;
            this.FirstName_Label.Size = new System.Drawing.Size(119, 20);
            this.FirstName_Label.TabIndex = 3;
            this.FirstName_Label.Click += new System.EventHandler(this.FirstName_Label_Click);
            // 
            // LastName_Label
            // 
            this.LastName_Label.BackColor = System.Drawing.SystemColors.Control;
            this.LastName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LastName_Label.Location = new System.Drawing.Point(162, 69);
            this.LastName_Label.Name = "LastName_Label";
            this.LastName_Label.ReadOnly = true;
            this.LastName_Label.Size = new System.Drawing.Size(125, 20);
            this.LastName_Label.TabIndex = 4;
            this.LastName_Label.Click += new System.EventHandler(this.LastName_Label_Click);
            // 
            // Login_Label
            // 
            this.Login_Label.BackColor = System.Drawing.SystemColors.Control;
            this.Login_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Login_Label.Location = new System.Drawing.Point(12, 118);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.ReadOnly = true;
            this.Login_Label.Size = new System.Drawing.Size(143, 20);
            this.Login_Label.TabIndex = 5;
            this.Login_Label.Click += new System.EventHandler(this.Login_Label_Click);
            // 
            // ComboBox_Domain
            // 
            this.ComboBox_Domain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Domain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ComboBox_Domain.FormattingEnabled = true;
            this.ComboBox_Domain.Location = new System.Drawing.Point(162, 118);
            this.ComboBox_Domain.Name = "ComboBox_Domain";
            this.ComboBox_Domain.Size = new System.Drawing.Size(126, 21);
            this.ComboBox_Domain.TabIndex = 6;
            // 
            // Email_Label
            // 
            this.Email_Label.BackColor = System.Drawing.SystemColors.Control;
            this.Email_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Email_Label.Location = new System.Drawing.Point(12, 157);
            this.Email_Label.Name = "Email_Label";
            this.Email_Label.ReadOnly = true;
            this.Email_Label.Size = new System.Drawing.Size(182, 20);
            this.Email_Label.TabIndex = 7;
            this.Email_Label.Click += new System.EventHandler(this.Email_Label_Click);
            // 
            // Password_Label
            // 
            this.Password_Label.BackColor = System.Drawing.SystemColors.Control;
            this.Password_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Password_Label.Location = new System.Drawing.Point(12, 196);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.ReadOnly = true;
            this.Password_Label.Size = new System.Drawing.Size(182, 20);
            this.Password_Label.TabIndex = 8;
            this.Password_Label.Click += new System.EventHandler(this.Password_Label_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Email.Location = new System.Drawing.Point(8, 141);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 9;
            this.Email.Text = "Email";
            // 
            // Domain
            // 
            this.Domain.AutoSize = true;
            this.Domain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Domain.Location = new System.Drawing.Point(159, 102);
            this.Domain.Name = "Domain";
            this.Domain.Size = new System.Drawing.Size(42, 13);
            this.Domain.TabIndex = 10;
            this.Domain.Text = "Домен";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Login.Location = new System.Drawing.Point(9, 102);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(33, 13);
            this.Login.TabIndex = 11;
            this.Login.Text = "Login";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Password.Location = new System.Drawing.Point(8, 180);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 12;
            this.Password.Text = "Password";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FirstName.Location = new System.Drawing.Point(10, 53);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(54, 13);
            this.FirstName.TabIndex = 13;
            this.FirstName.Text = "FirstName";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LastName.Location = new System.Drawing.Point(159, 53);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(55, 13);
            this.LastName.TabIndex = 14;
            this.LastName.Text = "LastName";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 286);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Domain);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.Email_Label);
            this.Controls.Add(this.ComboBox_Domain);
            this.Controls.Add(this.Login_Label);
            this.Controls.Add(this.LastName_Label);
            this.Controls.Add(this.FirstName_Label);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.TextBox1_Label);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextBox1_Label;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.TextBox FirstName_Label;
        private System.Windows.Forms.TextBox LastName_Label;
        private System.Windows.Forms.TextBox Login_Label;
        private System.Windows.Forms.ComboBox ComboBox_Domain;
        private System.Windows.Forms.TextBox Email_Label;
        private System.Windows.Forms.TextBox Password_Label;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Domain;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
    }
}