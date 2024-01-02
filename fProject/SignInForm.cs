using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fProject
{
    public partial class SignInForm : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private bool isDragging = false;
        private int xOffset, yOffset;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        //Variables for the textboxClearing 
        int[] touchcounter = { 0, 0, 0, 0, 0 };

        //sign in textbox variables 
        string username;
        string password;

        //Database initiation 
        dbConnection connection; 

        public SignInForm()
        {
            InitializeComponent();

            this.panelTitlebar.MouseDown += Form1_MouseDown;
            this.panelTitlebar.MouseMove += Form1_MouseMove;
            this.panelTitlebar.MouseUp += Form1_MouseUp;

            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
        }
        private void Form1_MouseUp(object? sender, MouseEventArgs e)
        {
            // Stop dragging when the left mouse button is released
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void Form1_MouseMove(object? sender, MouseEventArgs e)
        {
            // Check if the form is being dragged
            if (isDragging)
            {
                // Move the form with the mouse
                this.Location = new System.Drawing.Point(Cursor.Position.X - xOffset, Cursor.Position.Y - yOffset);
            }
        }

        private void Form1_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void TxtBoxPassword_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.Clear();
        }
        private void LbLandingPageTitile_Click(object sender, EventArgs e)
        {

        }

        private void TxtBoxPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*'; 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form form2Instance = Application.OpenForms["SignInForm"]; ///Todo: Fix this

            if (form2Instance != null)
            {
                // Close Form2
                form2Instance.Close();
            }

        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {

            if(!TextBoxCheck.checkEmpty(tbEmail) && !TextBoxCheck.checkEmpty(tbPassword))
            {
                lbError.Text = "Please fill your USERNAME and PASSWORD correctly "; 
            }
            else
            {
                //Initialize the username and password from the textbox 
                password = tbPassword.Text;
                username = tbEmail.Text.Trim();

                connection = new dbConnection();
                int signinResult = connection.UserLogin(username, password);
                if (signinResult == 0)
                {
                    MainPage mainPage = new MainPage(username);
                    this.Close(); 
                    mainPage.Show();
                }
                else if (signinResult == 1)
                {
                    MessageBox.Show("The specified user was not found", "user not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (signinResult == 2)
                {
                    MessageBox.Show("Please check you password and username and try again", "Username, Password missmatch", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (signinResult == 3)
                {
                    MessageBox.Show("An unexpected error occured please try again ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(this.tbPassword.PasswordChar== '*')
            {
                this.tbPassword.PasswordChar = '\0';
            }
            else
            {
                this.tbPassword.PasswordChar = '*';
            }
            
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usernameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (touchcounter[0] == 0)
            {
                tbEmail.Clear();
            }

            touchcounter[0]++;
        }

        private void tbPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (touchcounter[1] == 0)
            {
                tbPassword.Clear();
            }

            touchcounter[1]++;
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
