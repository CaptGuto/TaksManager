using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fProject
{
    public partial class AddTaskForm : Form
    {
        //Variables to be sent to Database
        string TITLE;
        string DESCRIPTION;
        string due_date;
        int PRIORITY;
        string CREATED_BY;
        //Define the owner group as 00pers00pr to specify that it is an individual task

        string OWNER_GROUP = "00pers00pr"; 


        public AddTaskForm(string callerid)
        {
            InitializeComponent();
            CREATED_BY = callerid;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!TextBoxCheck.checkEmpty(tbTaskName))
            {
                //Change a label and say please fill this 
            }
            else
            {
                TITLE = tbTaskName.Text;
                DESCRIPTION = rtbTaskDescription.Text;
                due_date = datePickerDueDate.Text;
                string DUE_DATE = "";

                if (DateTime.TryParse(due_date, out DateTime dueDate))
                {
                    // Format the date as YYYY-MM-DD
                    DUE_DATE = dueDate.ToString("yyyy-MM-dd");

                    // Now, formattedDueDate contains the date in the desired format
                }

                if (radioBtnVImportant.Checked)
                {
                    PRIORITY = 3;
                }
                else if (radiobtnImportant.Checked)
                {
                    PRIORITY = 2;
                }
                else if (radiobtnImportant.Checked)
                {
                    PRIORITY = 1;
                }
                else
                {
                    lbRadioBox.Text = "Please Choose A Priority For your Task";
                }

                dbConnection connection = new dbConnection();
                if (connection.AddTask(TITLE, DESCRIPTION, DUE_DATE, PRIORITY, false, CREATED_BY, OWNER_GROUP))
                {
                    MessageBox.Show("data Insert successful");
                }
                else
                {
                    MessageBox.Show("Data Entry faied");
                }
            }
            
        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCloseAddTask_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
