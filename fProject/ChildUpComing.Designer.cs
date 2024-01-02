namespace fProject
{
    partial class ChildUpComing
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
            this.label1 = new System.Windows.Forms.Label();
            this.todaypanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.tomorrowpanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.thisweekpanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.todaypanel.SuspendLayout();
            this.tomorrowpanel.SuspendLayout();
            this.thisweekpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today";
            // 
            // todaypanel
            // 
            this.todaypanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.todaypanel.Controls.Add(this.panel3);
            this.todaypanel.Controls.Add(this.btnAddTask);
            this.todaypanel.Controls.Add(this.label1);
            this.todaypanel.Location = new System.Drawing.Point(12, 71);
            this.todaypanel.Name = "todaypanel";
            this.todaypanel.Size = new System.Drawing.Size(794, 359);
            this.todaypanel.TabIndex = 1;
            this.todaypanel.Paint += new System.Windows.Forms.PaintEventHandler(this.todaypanel_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(203)))), ((int)(((byte)(233)))));
            this.panel3.Location = new System.Drawing.Point(13, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 3);
            this.panel3.TabIndex = 7;
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(203)))), ((int)(((byte)(233)))));
            this.btnAddTask.Location = new System.Drawing.Point(32, 296);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(160, 33);
            this.btnAddTask.TabIndex = 0;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // tomorrowpanel
            // 
            this.tomorrowpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tomorrowpanel.Controls.Add(this.panel1);
            this.tomorrowpanel.Controls.Add(this.label2);
            this.tomorrowpanel.Location = new System.Drawing.Point(12, 460);
            this.tomorrowpanel.Name = "tomorrowpanel";
            this.tomorrowpanel.Size = new System.Drawing.Size(374, 377);
            this.tomorrowpanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(203)))), ((int)(((byte)(233)))));
            this.panel1.Location = new System.Drawing.Point(13, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 3);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tomorrow";
            // 
            // thisweekpanel
            // 
            this.thisweekpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thisweekpanel.Controls.Add(this.panel2);
            this.thisweekpanel.Controls.Add(this.label3);
            this.thisweekpanel.Location = new System.Drawing.Point(394, 460);
            this.thisweekpanel.Name = "thisweekpanel";
            this.thisweekpanel.Size = new System.Drawing.Size(412, 377);
            this.thisweekpanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(203)))), ((int)(((byte)(233)))));
            this.panel2.Location = new System.Drawing.Point(16, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 3);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "This Week";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(45, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "Upcoming";
            // 
            // ChildUpComing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 876);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.thisweekpanel);
            this.Controls.Add(this.tomorrowpanel);
            this.Controls.Add(this.todaypanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChildUpComing";
            this.Text = "ChildUpComing";
            this.Load += new System.EventHandler(this.ChildUpComing_Load);
            this.todaypanel.ResumeLayout(false);
            this.todaypanel.PerformLayout();
            this.tomorrowpanel.ResumeLayout(false);
            this.tomorrowpanel.PerformLayout();
            this.thisweekpanel.ResumeLayout(false);
            this.thisweekpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel todaypanel;
        private Button btnAddTask;
        private Panel tomorrowpanel;
        private Label label2;
        private Panel thisweekpanel;
        private Label label3;
        private Label label4;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
    }
}