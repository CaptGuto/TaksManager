using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 
namespace fProject
{
    public partial class SingUpForm : Form
    {

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private bool isDragging = false;
        private int xOffset, yOffset;

        //Database Variables 
        string ConnectionString = "server=127.0.0.1; user=root; database=task; password=";
        MySqlConnection mysqlconnection;

        //User Data Variables
        string fullname;
        string email;
        string password;
        string username;

        //Variables for the textboxClearing 
        int[] touchcounter = {0,0,0,0,0}; 

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();


        public SingUpForm()
        {
            InitializeComponent();

            this.panelTitlebar.MouseDown += Form1_MouseDown;
            this.panelTitlebar.MouseMove += Form1_MouseMove;
            this.panelTitlebar.MouseUp += Form1_MouseUp;

            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;

            mysqlconnection = new MySqlConnection(ConnectionString);
            try
            {
                mysqlconnection.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Check Your Internet Connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                mysqlconnection.Close(); 
            }
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbSignIn_Click(object sender, EventArgs e)
        {
            SignInForm signInForm= new SignInForm();
            this.Close(); 
            signInForm.Show(); 
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void tbFirstName_MouseDown(object sender, MouseEventArgs e)
        {
            if (touchcounter[0] == 0)
            {
                tbFirstName.Clear(); 
            }

            touchcounter[0]++;
        }

        private void tbLastName_MouseDown(object sender, MouseEventArgs e)
        {
            if (touchcounter[1] == 0)
            {
                tbUserName.Clear();
            }

            touchcounter[1]++;
        }

        private void tbEmail_MouseDown(object sender, MouseEventArgs e)
        {
            if (touchcounter[2] == 0)
            {
                tbEmail.Clear();
            }

            touchcounter[2]++;

        }

        private void TxtBoxPassword_MouseDown(object sender, MouseEventArgs e)
        {
            if (touchcounter[3] == 0)
            {
                tbPassword.Clear();
            }

            touchcounter[3]++;
        }

        private void tbRePassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (touchcounter[4] == 0)
            {
                tbRePassword.Clear();
            }

            touchcounter[4]++;
            
        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {
            if (ValidateTextBoxes())
            {
                Register();
            }
            else
            {
               // MessageBox.Show("Please Fill the information correctly "); 
            }
        }

        private void SingUpForm_Load(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*'; 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.tbPassword.PasswordChar == '*')
            {
                this.tbPassword.PasswordChar = '\0';
            }
            else
            {
                this.tbPassword.PasswordChar = '*';
            }
        }
        private Boolean ValidateTextBoxes()
        {
            if (!TextBoxCheck.validateUserName(tbUserName))
            {
                lbErrormessege.Text = "Username should include no syboles \n and should be 8-10 characters";
                return false;
            }
            else if (!TextBoxCheck.validateEmail(tbEmail))
            {
                lbErrormessege.Text = "Please Enter the correct Email"; 
                return false; 
            }
            else if (!TextBoxCheck.ValidatePassword(tbPassword))
            {
                lbErrormessege.Text = "The Password should include Lower and Upper case letters,\n number and a symbole";
                return false; 
            }
            else if(!TextBoxCheck.checkPasswordMatch(tbPassword, tbRePassword))
            {
                lbErrormessege.Text = "Password Doesn't match "; 
                return false; 
            }

            return true;
        }

        //A function to register the new user to a database
        private void Register()
        {
            fullname = tbFirstName.Text.Trim();
            username = tbUserName.Text.Trim();
            email = tbEmail.Text.Trim();
            password = tbPassword.Text.Trim();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO user VALUES (@username, @fullname, @email, @password)", mysqlconnection))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@fullname", fullname);

                try
                {
                    mysqlconnection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during registration: " + ex.Message);
                }
            }
        }

        //Might move this to separate Class 


    }
}
