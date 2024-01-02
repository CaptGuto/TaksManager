using System.Runtime.InteropServices;

namespace fProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LandingPageContentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbSignIn = new System.Windows.Forms.Label();
            this.btnGetStarted = new System.Windows.Forms.Button();
            this.LbLandingPageTitile = new System.Windows.Forms.Label();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.panelCloseMinimize = new System.Windows.Forms.Panel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(9, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 649);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::fProject.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 649);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LandingPageContentRichTextBox
            // 
            this.LandingPageContentRichTextBox.BackColor = System.Drawing.Color.White;
            this.LandingPageContentRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LandingPageContentRichTextBox.Location = new System.Drawing.Point(21, 206);
            this.LandingPageContentRichTextBox.Name = "LandingPageContentRichTextBox";
            this.LandingPageContentRichTextBox.ReadOnly = true;
            this.LandingPageContentRichTextBox.Size = new System.Drawing.Size(421, 102);
            this.LandingPageContentRichTextBox.TabIndex = 1;
            this.LandingPageContentRichTextBox.TabStop = false;
            this.LandingPageContentRichTextBox.Text = resources.GetString("LandingPageContentRichTextBox.Text");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbSignIn);
            this.panel2.Controls.Add(this.btnGetStarted);
            this.panel2.Controls.Add(this.LandingPageContentRichTextBox);
            this.panel2.Controls.Add(this.LbLandingPageTitile);
            this.panel2.Location = new System.Drawing.Point(715, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 649);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbSignIn
            // 
            this.lbSignIn.AutoSize = true;
            this.lbSignIn.Location = new System.Drawing.Point(118, 420);
            this.lbSignIn.Name = "lbSignIn";
            this.lbSignIn.Size = new System.Drawing.Size(227, 20);
            this.lbSignIn.TabIndex = 3;
            this.lbSignIn.Text = "Already have an account? Sign In";
            this.lbSignIn.Click += new System.EventHandler(this.lbSignIn_Click);
            // 
            // btnGetStarted
            // 
            this.btnGetStarted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.btnGetStarted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetStarted.Location = new System.Drawing.Point(78, 341);
            this.btnGetStarted.Name = "btnGetStarted";
            this.btnGetStarted.Size = new System.Drawing.Size(300, 40);
            this.btnGetStarted.TabIndex = 2;
            this.btnGetStarted.Text = "Get Started";
            this.btnGetStarted.UseVisualStyleBackColor = false;
            this.btnGetStarted.Click += new System.EventHandler(this.btnGetStarted_Click);
            // 
            // LbLandingPageTitile
            // 
            this.LbLandingPageTitile.AutoSize = true;
            this.LbLandingPageTitile.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbLandingPageTitile.Location = new System.Drawing.Point(102, 110);
            this.LbLandingPageTitile.Name = "LbLandingPageTitile";
            this.LbLandingPageTitile.Size = new System.Drawing.Size(266, 54);
            this.LbLandingPageTitile.TabIndex = 0;
            this.LbLandingPageTitile.Text = "Task Manager";
            this.LbLandingPageTitile.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panelTitlebar.Controls.Add(this.panelCloseMinimize);
            this.panelTitlebar.Controls.Add(this.PanelTitle);
            this.panelTitlebar.Location = new System.Drawing.Point(-1, 3);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(1183, 53);
            this.panelTitlebar.TabIndex = 4;
            this.panelTitlebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitlebar_Paint);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(1182, 723);
            this.Controls.Add(this.panelTitlebar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Panel panel2;
        private Label LbLandingPageTitile;
        private RichTextBox LandingPageContentRichTextBox;
        private Button btnGetStarted;
        private Label lbSignIn;
        private Panel panelTitlebar;
        private Panel panelCloseMinimize;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private Panel PanelTitle;
        private Label label6;
    }
}