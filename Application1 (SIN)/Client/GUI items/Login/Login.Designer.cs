namespace Client.GUI_items.Login
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameLine = new System.Windows.Forms.TextBox();
            this.passwordLine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLine
            // 
            this.usernameLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameLine.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.usernameLine.Location = new System.Drawing.Point(162, 147);
            this.usernameLine.Name = "usernameLine";
            this.usernameLine.Size = new System.Drawing.Size(240, 26);
            this.usernameLine.TabIndex = 0;
            this.usernameLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.usernameLine.Click += new System.EventHandler(this.textBox1_TextChanged);
            this.usernameLine.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.usernameLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // passwordLine
            // 
            this.passwordLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordLine.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.passwordLine.Location = new System.Drawing.Point(162, 207);
            this.passwordLine.Name = "passwordLine";
            this.passwordLine.PasswordChar = '*';
            this.passwordLine.Size = new System.Drawing.Size(240, 26);
            this.passwordLine.TabIndex = 1;
            this.passwordLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.passwordLine.Click += new System.EventHandler(this.textBox1_TextChanged);
            this.passwordLine.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.passwordLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(138)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(36, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(138)))), ((int)(((byte)(41)))));
            this.label2.Location = new System.Drawing.Point(36, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.button1.Location = new System.Drawing.Point(220, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Log in";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Client.Properties.Resources.logo_login;
            this.pictureBox1.Location = new System.Drawing.Point(41, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // errorMessage
            // 
            this.errorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.ForeColor = System.Drawing.Color.Snow;
            this.errorMessage.Location = new System.Drawing.Point(38, 253);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(148, 53);
            this.errorMessage.TabIndex = 6;
            this.errorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorMessage.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordLine);
            this.Controls.Add(this.usernameLine);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.Size = new System.Drawing.Size(440, 312);
            this.Load += new System.EventHandler(this.LoginView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameLine;
        private System.Windows.Forms.TextBox passwordLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label errorMessage;

    }
}
