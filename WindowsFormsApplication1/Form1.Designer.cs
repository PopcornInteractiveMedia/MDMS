namespace WindowsFormsApplication1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.password_textBox2 = new System.Windows.Forms.TextBox();
            this.user_name_textBox1 = new System.Windows.Forms.TextBox();
            this.user_login_button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.password_textBox2);
            this.groupBox1.Controls.Add(this.user_name_textBox1);
            this.groupBox1.Controls.Add(this.user_login_button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(110, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 186);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGIN";
            // 
            // password_textBox2
            // 
            this.password_textBox2.Location = new System.Drawing.Point(114, 90);
            this.password_textBox2.Name = "password_textBox2";
            this.password_textBox2.Size = new System.Drawing.Size(248, 22);
            this.password_textBox2.TabIndex = 5;
            this.password_textBox2.TextChanged += new System.EventHandler(this.password_textBox2_TextChanged);
            // 
            // user_name_textBox1
            // 
            this.user_name_textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.user_name_textBox1.Location = new System.Drawing.Point(114, 42);
            this.user_name_textBox1.Name = "user_name_textBox1";
            this.user_name_textBox1.Size = new System.Drawing.Size(248, 22);
            this.user_name_textBox1.TabIndex = 4;
            // 
            // user_login_button2
            // 
            this.user_login_button2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Login_button1;
            this.user_login_button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.user_login_button2.Location = new System.Drawing.Point(114, 137);
            this.user_login_button2.Name = "user_login_button2";
            this.user_login_button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.user_login_button2.Size = new System.Drawing.Size(248, 42);
            this.user_login_button2.TabIndex = 3;
            this.user_login_button2.UseVisualStyleBackColor = true;
            this.user_login_button2.TextChanged += new System.EventHandler(this.user_login_button2_TextChanged);
            this.user_login_button2.Click += new System.EventHandler(this.user_login_button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Login_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 129);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 208);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Multimedia Data Management System Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox password_textBox2;
        private System.Windows.Forms.TextBox user_name_textBox1;
        private System.Windows.Forms.Button user_login_button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

