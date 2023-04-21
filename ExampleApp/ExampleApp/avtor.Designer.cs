namespace ExampleApp
{
    partial class avtor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(avtor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IsPass = new System.Windows.Forms.Button();
            this.IsLogin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Registr = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseName = new System.Windows.Forms.Label();
            this.Autorizlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.IsPass);
            this.panel1.Controls.Add(this.IsLogin);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Registr);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 474);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // IsPass
            // 
            this.IsPass.BackColor = System.Drawing.Color.Transparent;
            this.IsPass.Enabled = false;
            this.IsPass.FlatAppearance.BorderSize = 0;
            this.IsPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IsPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsPass.Location = new System.Drawing.Point(92, 205);
            this.IsPass.Name = "IsPass";
            this.IsPass.Size = new System.Drawing.Size(189, 29);
            this.IsPass.TabIndex = 12;
            this.IsPass.UseVisualStyleBackColor = false;
            // 
            // IsLogin
            // 
            this.IsLogin.BackColor = System.Drawing.Color.Transparent;
            this.IsLogin.Enabled = false;
            this.IsLogin.FlatAppearance.BorderSize = 0;
            this.IsLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IsLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsLogin.Location = new System.Drawing.Point(92, 129);
            this.IsLogin.Name = "IsLogin";
            this.IsLogin.Size = new System.Drawing.Size(189, 29);
            this.IsLogin.TabIndex = 11;
            this.IsLogin.UseVisualStyleBackColor = false;
            this.IsLogin.Click += new System.EventHandler(this.IsLogin_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(92, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ваше фото";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(92, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ваше фамилия";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Registr
            // 
            this.Registr.BackColor = System.Drawing.Color.Transparent;
            this.Registr.Enabled = false;
            this.Registr.FlatAppearance.BorderSize = 0;
            this.Registr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Registr.Location = new System.Drawing.Point(92, 94);
            this.Registr.Name = "Registr";
            this.Registr.Size = new System.Drawing.Size(189, 29);
            this.Registr.TabIndex = 6;
            this.Registr.Text = "Ваше имя";
            this.Registr.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.CloseName);
            this.panel2.Controls.Add(this.Autorizlabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 75);
            this.panel2.TabIndex = 0;
            // 
            // CloseName
            // 
            this.CloseName.AutoSize = true;
            this.CloseName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CloseName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CloseName.Location = new System.Drawing.Point(329, 0);
            this.CloseName.Name = "CloseName";
            this.CloseName.Size = new System.Drawing.Size(26, 27);
            this.CloseName.TabIndex = 1;
            this.CloseName.Text = "X";
            this.CloseName.Click += new System.EventHandler(this.CloseName_Click);
            // 
            // Autorizlabel
            // 
            this.Autorizlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Autorizlabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Autorizlabel.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Autorizlabel.ForeColor = System.Drawing.SystemColors.Window;
            this.Autorizlabel.Location = new System.Drawing.Point(0, 0);
            this.Autorizlabel.Name = "Autorizlabel";
            this.Autorizlabel.Size = new System.Drawing.Size(364, 75);
            this.Autorizlabel.TabIndex = 0;
            this.Autorizlabel.Text = "Вход выполнен";
            this.Autorizlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Autorizlabel.Click += new System.EventHandler(this.Autorizlabel_Click);
            // 
            // avtor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 474);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "avtor";
            this.Text = "avtor";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Registr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseName;
        private System.Windows.Forms.Label Autorizlabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button IsPass;
        private System.Windows.Forms.Button IsLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}