namespace fProject
{
    partial class SingUpForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LbLandingPageTitile = new System.Windows.Forms.Label();
            this.btnGetStarted = new System.Windows.Forms.Button();
            this.lbSignIn = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tbRePassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbErrormessege = new System.Windows.Forms.Label();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.panelCloseMinimize = new System.Windows.Forms.Panel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelTitlebar.SuspendLayout();
            this.panelCloseMinimize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 649);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::fProject.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 652);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LbLandingPageTitile
            // 
            this.LbLandingPageTitile.AutoSize = true;
            this.LbLandingPageTitile.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbLandingPageTitile.Location = new System.Drawing.Point(52, 36);
            this.LbLandingPageTitile.Name = "LbLandingPageTitile";
            this.LbLandingPageTitile.Size = new System.Drawing.Size(138, 45);
            this.LbLandingPageTitile.TabIndex = 0;
            this.LbLandingPageTitile.Text = "Sign Up";
            // 
            // btnGetStarted
            // 
            this.btnGetStarted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(203)))), ((int)(((byte)(233)))));
            this.btnGetStarted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetStarted.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetStarted.Location = new System.Drawing.Point(90, 465);
            this.btnGetStarted.Name = "btnGetStarted";
            this.btnGetStarted.Size = new System.Drawing.Size(300, 40);
            this.btnGetStarted.TabIndex = 2;
            this.btnGetStarted.Text = "Sign Up";
            this.btnGetStarted.UseVisualStyleBackColor = false;
            this.btnGetStarted.Click += new System.EventHandler(this.btnGetStarted_Click);
            // 
            // lbSignIn
            // 
            this.lbSignIn.AutoSize = true;
            this.lbSignIn.Location = new System.Drawing.Point(121, 529);
            this.lbSignIn.Name = "lbSignIn";
            this.lbSignIn.Size = new System.Drawing.Size(227, 20);
            this.lbSignIn.TabIndex = 3;
            this.lbSignIn.Text = "Already have an account? Sign In";
            this.lbSignIn.Click += new System.EventHandler(this.lbSignIn_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.White;
            this.tbFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFirstName.ForeColor = System.Drawing.Color.Black;
            this.tbFirstName.Location = new System.Drawing.Point(90, 114);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(300, 34);
            this.tbFirstName.TabIndex = 0;
            this.tbFirstName.Text = "Full Name";
            this.tbFirstName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbFirstName_MouseDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.tbPassword);
            this.panel3.Location = new System.Drawing.Point(90, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 50);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::fProject.Properties.Resources.ShowPassword;
            this.pictureBox3.Location = new System.Drawing.Point(268, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.Location = new System.Drawing.Point(0, 10);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(267, 34);
            this.tbPassword.TabIndex = 0;
            this.tbPassword.Tag = "";
            this.tbPassword.Text = "Password";
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TxtBoxPassword_MouseDown);
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.White;
            this.tbUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUserName.ForeColor = System.Drawing.Color.Black;
            this.tbUserName.Location = new System.Drawing.Point(90, 168);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(300, 34);
            this.tbUserName.TabIndex = 10;
            this.tbUserName.Text = "User Name";
            this.tbUserName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbLastName_MouseDown);
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.White;
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.ForeColor = System.Drawing.Color.Black;
            this.tbEmail.Location = new System.Drawing.Point(90, 218);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(300, 34);
            this.tbEmail.TabIndex = 11;
            this.tbEmail.Text = "Email";
            this.tbEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbEmail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbEmail_MouseDown);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Controls.Add(this.tbRePassword);
            this.panel6.Location = new System.Drawing.Point(90, 334);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 50);
            this.panel6.TabIndex = 5;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::fProject.Properties.Resources.ShowPassword;
            this.pictureBox4.Location = new System.Drawing.Point(268, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // tbRePassword
            // 
            this.tbRePassword.BackColor = System.Drawing.Color.White;
            this.tbRePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRePassword.ForeColor = System.Drawing.Color.Black;
            this.tbRePassword.Location = new System.Drawing.Point(0, 10);
            this.tbRePassword.Name = "tbRePassword";
            this.tbRePassword.Size = new System.Drawing.Size(267, 34);
            this.tbRePassword.TabIndex = 0;
            this.tbRePassword.Tag = "";
            this.tbRePassword.Text = "Re-enter Password";
            this.tbRePassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbRePassword_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbErrormessege);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.tbEmail);
            this.panel2.Controls.Add(this.tbUserName);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.tbFirstName);
            this.panel2.Controls.Add(this.lbSignIn);
            this.panel2.Controls.Add(this.btnGetStarted);
            this.panel2.Controls.Add(this.LbLandingPageTitile);
            this.panel2.Location = new System.Drawing.Point(641, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 649);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbErrormessege
            // 
            this.lbErrormessege.AutoSize = true;
            this.lbErrormessege.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbErrormessege.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbErrormessege.Location = new System.Drawing.Point(90, 401);
            this.lbErrormessege.Name = "lbErrormessege";
            this.lbErrormessege.Size = new System.Drawing.Size(0, 19);
            this.lbErrormessege.TabIndex = 12;
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panelTitlebar.Controls.Add(this.panelCloseMinimize);
            this.panelTitlebar.Controls.Add(this.PanelTitle);
            this.panelTitlebar.Location = new System.Drawing.Point(0, 3);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(1183, 53);
            this.panelTitlebar.TabIndex = 8;
            // 
            // panelCloseMinimize
            // 
            this.panelCloseMinimize.Controls.Add(this.pictureBox10);
            this.panelCloseMinimize.Controls.Add(this.pictureBox9);
            this.panelCloseMinimize.Controls.Add(this.pictureBox8);
            this.panelCloseMinimize.Location = new System.Drawing.Point(835, 3);
            this.panelCloseMinimize.Name = "panelCloseMinimize";
            this.panelCloseMinimize.Size = new System.Drawing.Size(323, 45);
            this.panelCloseMinimize.TabIndex = 1;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::fProject.Properties.Resources.minus_6399466;
            this.pictureBox10.Location = new System.Drawing.Point(183, 9);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(33, 33);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 2;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::fProject.Properties.Resources.copy_4024457;
            this.pictureBox9.Location = new System.Drawing.Point(232, 7);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(35, 35);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 1;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::fProject.Properties.Resources.cross_button_9312232;
            this.pictureBox8.Location = new System.Drawing.Point(283, 7);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(35, 35);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // PanelTitle
            // 
            this.PanelTitle.Controls.Add(this.label6);
            this.PanelTitle.Location = new System.Drawing.Point(34, 3);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(391, 45);
            this.PanelTitle.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(71, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "TASK MANAGER";
            // 
            // SingUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 723);
            this.Controls.Add(this.panelTitlebar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SingUpForm";
            this.Text = "SingUpForm";
            this.Load += new System.EventHandler(this.SingUpForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelTitlebar.ResumeLayout(false);
            this.panelCloseMinimize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label LbLandingPageTitile;
        private Button btnGetStarted;
        private Label lbSignIn;
        private TextBox tbFirstName;
        private Panel panel3;
        private PictureBox pictureBox3;
        private TextBox tbPassword;
        private TextBox tbUserName;
        private TextBox tbEmail;
        private Panel panel6;
        private PictureBox pictureBox4;
        private TextBox tbRePassword;
        private Panel panel2;
        private Panel panelTitlebar;
        private Panel panelCloseMinimize;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private Panel PanelTitle;
        private Label label6;
        private Label lbErrormessege;
    }
}