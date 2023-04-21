namespace ExampleApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.vxod = new System.Windows.Forms.Button();
            this.PassField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.ico2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseName = new System.Windows.Forms.Label();
            this.Autorizlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.vxod);
            this.panel1.Controls.Add(this.PassField);
            this.panel1.Controls.Add(this.loginField);
            this.panel1.Controls.Add(this.ico2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 448);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.BackgroundImage = global::ExampleApp.Properties.Resources._299105_lock_icon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(74, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vxod
            // 
            this.vxod.BackColor = System.Drawing.Color.Silver;
            this.vxod.BackgroundImage = global::ExampleApp.Properties.Resources._285655_user_icon;
            this.vxod.FlatAppearance.BorderSize = 0;
            this.vxod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vxod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vxod.Location = new System.Drawing.Point(113, 302);
            this.vxod.Name = "vxod";
            this.vxod.Size = new System.Drawing.Size(150, 36);
            this.vxod.TabIndex = 5;
            this.vxod.Text = "Войти";
            this.vxod.UseVisualStyleBackColor = false;
            this.vxod.Click += new System.EventHandler(this.vxod_Click_1);
            // 
            // PassField
            // 
            this.PassField.BackColor = System.Drawing.Color.Gray;
            this.PassField.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.Location = new System.Drawing.Point(113, 213);
            this.PassField.Name = "PassField";
            this.PassField.PasswordChar = '.';
            this.PassField.Size = new System.Drawing.Size(214, 32);
            this.PassField.TabIndex = 4;
            this.PassField.UseSystemPasswordChar = true;
            this.PassField.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // loginField
            // 
            this.loginField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginField.BackColor = System.Drawing.Color.Gray;
            this.loginField.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(113, 120);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(214, 32);
            this.loginField.TabIndex = 3;
            this.loginField.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // ico2
            // 
            this.ico2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ico2.ErrorImage")));
            this.ico2.Image = ((System.Drawing.Image)(resources.GetObject("ico2.Image")));
            this.ico2.InitialImage = ((System.Drawing.Image)(resources.GetObject("ico2.InitialImage")));
            this.ico2.Location = new System.Drawing.Point(40, 213);
            this.ico2.Name = "ico2";
            this.ico2.Size = new System.Drawing.Size(57, 54);
            this.ico2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ico2.TabIndex = 2;
            this.ico2.TabStop = false;
            this.ico2.Click += new System.EventHandler(this.ico2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.CloseName);
            this.panel2.Controls.Add(this.Autorizlabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 75);
            this.panel2.TabIndex = 0;
            // 
            // CloseName
            // 
            this.CloseName.AutoSize = true;
            this.CloseName.BackColor = System.Drawing.Color.SteelBlue;
            this.CloseName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseName.ForeColor = System.Drawing.Color.White;
            this.CloseName.Location = new System.Drawing.Point(329, 0);
            this.CloseName.Name = "CloseName";
            this.CloseName.Size = new System.Drawing.Size(26, 27);
            this.CloseName.TabIndex = 1;
            this.CloseName.Text = "X";
            this.CloseName.Click += new System.EventHandler(this.CloseName_Click);
            // 
            // Autorizlabel
            // 
            this.Autorizlabel.BackColor = System.Drawing.Color.SteelBlue;
            this.Autorizlabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Autorizlabel.Font = new System.Drawing.Font("Gabriola", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Autorizlabel.ForeColor = System.Drawing.SystemColors.Window;
            this.Autorizlabel.Location = new System.Drawing.Point(0, 0);
            this.Autorizlabel.Name = "Autorizlabel";
            this.Autorizlabel.Size = new System.Drawing.Size(360, 75);
            this.Autorizlabel.TabIndex = 0;
            this.Autorizlabel.Text = "Авторизация";
            this.Autorizlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Autorizlabel.Click += new System.EventHandler(this.Autorizlabel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 448);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseName;
        private System.Windows.Forms.Label Autorizlabel;
        private System.Windows.Forms.Button vxod;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox ico2;
        internal System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}