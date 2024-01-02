using System;
using System.Collections;
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
    public partial class ChildUpComing : Form
    {
        //The arraylist to hold all the 
        ArrayList listOfTasks= new ArrayList();
        dbConnection connection; 

        //caller username/ID
        string callerID; 
        public ChildUpComing(string callerId)
        {

            InitializeComponent();

            callerID = callerId; 
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm(callerID);
            addTaskForm.Show(); 
            //Here Reinitialize the get data to get all the tasks available after the update(the addTask)
        }

        private void todaypanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChildUpComing_Load(object sender, EventArgs e)
        {
            connection = new dbConnection();
            listOfTasks = connection.GetTasksByUserName(callerID);
            if(listOfTasks == null)
            {
                MessageBox.Show("it's empty"); 
            }
            foreach (Task task in listOfTasks)
            {
                MessageBox.Show("${task.Title}");
            }
            MessageBox.Show("this is working"); 
        }
    }
}
