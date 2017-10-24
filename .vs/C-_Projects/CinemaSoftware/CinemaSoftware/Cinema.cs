using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSoftware
{
    public partial class Cinema : Form
    {
        public Cinema()
        {
            InitializeComponent();
        }

        private void Cinema_Load(object sender, EventArgs e)
        {
            OpenSettings();
            CreateScreen();
            ScreenLabel();
            CreateInfoChars();
            CreateSeatsArea();
        }

        private void CreateSeatsArea()
        {
            for (int i = 0; i < length; i++)
            {
                for (int i = 0; i < length; i++)
                {
                    Button btnSeat = new Button();
                    btnSeat.Location = new Point(220 + (i * 50), 145 + (j * 100));
                }
            }
        }

        private void CreateInfoChars()
        {
            // int buyukAkacadenkgeliyo = Convert.ToInt32('A');
            for (int i = 0; i < 7; i++)
            {
                Label lblInfo = new Label();
                lblInfo.Location = new Point(20, 150 + (i * 100));
                lblInfo.Size = new Size(40,40);
                lblInfo.Text = Convert.ToChar(65+i).ToString();
                lblInfo.BackColor = Color.Lime;
                lblInfo.ForeColor = Color.Red;
                lblInfo.Font = new Font(FontFamily.GenericMonospace, 18f);
                lblInfo.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(lblInfo);
                    
            }
        }

        private void ScreenLabel()
        {
            Label lblScreen = new Label();
            lblScreen.Location = new Point(this.Width / 2 - 50, 30);
            lblScreen.Size = new Size(100, 20);
            lblScreen.Text = "SCREEN";
            lblScreen.TextAlign = ContentAlignment.MiddleCenter;
            lblScreen.BackColor = Color.Aqua;
            lblScreen.ForeColor = Color.Maroon;
            lblScreen.Font = new Font(FontFamily.GenericSerif, 14f); //f-float m-decimal d-double
            this.Controls.Add(lblScreen);
        }

        private void CreateScreen()
        {
            PictureBox pBoxScreen = new PictureBox();
            pBoxScreen.Location = new Point(100,50);
            pBoxScreen.Size = new Size(this.Width - 200, 30);
            pBoxScreen.BackColor = Color.Maroon;
            this.Controls.Add(pBoxScreen);
        }

        private void OpenSettings()
        {
            this.BackColor = Color.DarkGray;
            this.WindowState = FormWindowState.Maximized;
            this.Text = "Welcome Cinema Otomation";
        }
    }
}
