using System.Runtime.InteropServices;

namespace fProject
{
    public partial class Form1 : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private bool isDragging = false;
        private int xOffset, yOffset;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        public Form1()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {
            SingUpForm signup = new SingUpForm();
            this.Hide(); 
            signup.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbSignIn_Click(object sender, EventArgs e)
        {
            SignInForm form2 = new SignInForm();
            form2.Show(); 
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelTitlebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}