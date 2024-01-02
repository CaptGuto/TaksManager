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
    public partial class MainPage : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private bool isDragging = false;
        private int xOffset, yOffset;

        //UserName of the caller 
        string caller; 

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        public MainPage(string CallerID)
        {
            InitializeComponent();

            caller = CallerID;

            this.panelTitlebar.MouseDown += Form1_MouseDown;
            this.panelTitlebar.MouseMove += Form1_MouseMove;
            this.panelTitlebar.MouseUp += Form1_MouseUp;

            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
            //InitializeComponent();
        }

        public void loadForm(Form form)
        {
            if (
                this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0); 

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);

            this.MainPanel.Tag = f;
            f.Show();
        }

        private void Form1_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuSidePanelPageMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //loadForm(new ChildUpComing()); 
        }
        private void panel1_Click(object sender,EventArgs e)
        {
            loadForm(new ChildUpComing(caller)); 
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void upComingLabel_Click(object sender, EventArgs e)
        {
            loadForm(new ChildUpComing(caller));
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            loadForm(new ChildUpComing(caller)); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            loadForm(new ChildToday()); 
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            //Create a Calendar Form
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            //Create a Sticky paper Form
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            this.panelTask.Height = 224; 
            this.ListPanel.Height = 0;
            this.labelList.Location = new Point(24, 416); 
            this.ListPanel.Location = new Point(24, 406);
            this.lbGroup.Location = new Point(24, 456); 
            this.panelGroup.Height= 0;
        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            this.panelTask.Height = 0;
            this.labelList.Location = new Point(29, 190); 
            this.ListPanel.Location = new Point(0, 230);
            this.lbGroup.Location = new Point(24, 359); 
            this.panelGroup.Height= 0;
            this.ListPanel.Height = 125; 

        }

        private void lbGroup_Click(object sender, EventArgs e)
        {

        }

        private void lbGroup_MouseClick(object sender, MouseEventArgs e)
        {
            this.panelTask.Height = 0;
            this.panelGroup.Location = new Point(0, 266);
            this.lbGroup.Location = new Point(24, 235);
            this.labelList.Location = new Point(24, 192); 
            this.ListPanel.Height = 0;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void PanelTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseUp(object? sender, MouseEventArgs e)
        {
            // Stop dragging when the left mouse button is released
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
    }
}
