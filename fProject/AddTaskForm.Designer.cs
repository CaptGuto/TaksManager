namespace fProject
{
    partial class AddTaskForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCloseAddTask = new System.Windows.Forms.Button();
            this.tbTaskName = new System.Windows.Forms.TextBox();
            this.rtbTaskDescription = new System.Windows.Forms.RichTextBox();
            this.datePickerDueDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnNotImportant = new System.Windows.Forms.RadioButton();
            this.radiobtnImportant = new System.Windows.Forms.RadioButton();
            this.radioBtnVImportant = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lbRadioBox = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(203)))), ((int)(((byte)(233)))));
            this.button1.Location = new System.Drawing.Point(134, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Task";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCloseAddTask
            // 
            this.btnCloseAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(203)))), ((int)(((byte)(233)))));
            this.btnCloseAddTask.Location = new System.Drawing.Point(534, 416);
            this.btnCloseAddTask.Name = "btnCloseAddTask";
            this.btnCloseAddTask.Size = new System.Drawing.Size(160, 33);
            this.btnCloseAddTask.TabIndex = 3;
            this.btnCloseAddTask.Text = "CLOSE";
            this.btnCloseAddTask.UseVisualStyleBackColor = false;
            this.btnCloseAddTask.Click += new System.EventHandler(this.btnCloseAddTask_Click);
            // 
            // tbTaskName
            // 
            this.tbTaskName.BackColor = System.Drawing.Color.White;
            this.tbTaskName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTaskName.ForeColor = System.Drawing.Color.Black;
            this.tbTaskName.Location = new System.Drawing.Point(71, 94);
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.Size = new System.Drawing.Size(300, 34);
            this.tbTaskName.TabIndex = 5;
            this.tbTaskName.Text = "Task Title";
            // 
            // rtbTaskDescription
            // 
            this.rtbTaskDescription.Location = new System.Drawing.Point(71, 184);
            this.rtbTaskDescription.Name = "rtbTaskDescription";
            this.rtbTaskDescription.Size = new System.Drawing.Size(300, 157);
            this.rtbTaskDescription.TabIndex = 6;
            this.rtbTaskDescription.Text = "Task Description";
            // 
            // datePickerDueDate
            // 
            this.datePickerDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerDueDate.Location = new System.Drawing.Point(462, 94);
            this.datePickerDueDate.Name = "datePickerDueDate";
            this.datePickerDueDate.Size = new System.Drawing.Size(250, 27);
            this.datePickerDueDate.TabIndex = 7;
            this.datePickerDueDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Task Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Task Due Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Task Title";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnNotImportant);
            this.groupBox1.Controls.Add(this.radiobtnImportant);
            this.groupBox1.Controls.Add(this.radioBtnVImportant);
            this.groupBox1.Location = new System.Drawing.Point(462, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 157);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Priority";
            // 
            // radioBtnNotImportant
            // 
            this.radioBtnNotImportant.AutoSize = true;
            this.radioBtnNotImportant.Location = new System.Drawing.Point(6, 115);
            this.radioBtnNotImportant.Name = "radioBtnNotImportant";
            this.radioBtnNotImportant.Size = new System.Drawing.Size(125, 24);
            this.radioBtnNotImportant.TabIndex = 2;
            this.radioBtnNotImportant.TabStop = true;
            this.radioBtnNotImportant.Text = "Not Important";
            this.radioBtnNotImportant.UseVisualStyleBackColor = true;
            // 
            // radiobtnImportant
            // 
            this.radiobtnImportant.AutoSize = true;
            this.radiobtnImportant.Location = new System.Drawing.Point(6, 70);
            this.radiobtnImportant.Name = "radiobtnImportant";
            this.radiobtnImportant.Size = new System.Drawing.Size(96, 24);
            this.radiobtnImportant.TabIndex = 1;
            this.radiobtnImportant.TabStop = true;
            this.radiobtnImportant.Text = "Important";
            this.radiobtnImportant.UseVisualStyleBackColor = true;
            // 
            // radioBtnVImportant
            // 
            this.radioBtnVImportant.AutoSize = true;
            this.radioBtnVImportant.Location = new System.Drawing.Point(6, 26);
            this.radioBtnVImportant.Name = "radioBtnVImportant";
            this.radioBtnVImportant.Size = new System.Drawing.Size(128, 24);
            this.radioBtnVImportant.TabIndex = 0;
            this.radioBtnVImportant.TabStop = true;
            this.radioBtnVImportant.Text = "Very Important";
            this.radioBtnVImportant.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 505);
            this.panel1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(12, 488);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(830, 17);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(12, 494);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(830, 11);
            this.panel4.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 494);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 11);
            this.panel2.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.panel5.Location = new System.Drawing.Point(12, 485);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(817, 19);
            this.panel5.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Location = new System.Drawing.Point(829, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(13, 505);
            this.panel6.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(12, 488);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(830, 17);
            this.panel7.TabIndex = 14;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(12, 494);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(830, 11);
            this.panel8.TabIndex = 13;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(12, 494);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(830, 11);
            this.panel9.TabIndex = 13;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.panel10.Location = new System.Drawing.Point(12, -1);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(817, 19);
            this.panel10.TabIndex = 16;
            // 
            // lbRadioBox
            // 
            this.lbRadioBox.AutoSize = true;
            this.lbRadioBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbRadioBox.Location = new System.Drawing.Point(462, 356);
            this.lbRadioBox.Name = "lbRadioBox";
            this.lbRadioBox.Size = new System.Drawing.Size(0, 20);
            this.lbRadioBox.TabIndex = 17;
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 504);
            this.Controls.Add(this.lbRadioBox);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePickerDueDate);
            this.Controls.Add(this.rtbTaskDescription);
            this.Controls.Add(this.tbTaskName);
            this.Controls.Add(this.btnCloseAddTask);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTaskForm";
            this.Text = "AddTaskForm";
            this.Load += new System.EventHandler(this.AddTaskForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button btnCloseAddTask;
        private TextBox tbTaskName;
        private RichTextBox rtbTaskDescription;
        private DateTimePicker datePickerDueDate;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton radioBtnNotImportant;
        private RadioButton radiobtnImportant;
        private RadioButton radioBtnVImportant;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Label lbRadioBox;
    }
}