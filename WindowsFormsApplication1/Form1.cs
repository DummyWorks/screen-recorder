using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bmp;
        Graphics gr;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bmp = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width,
                             Screen.PrimaryScreen.WorkingArea.Height);
            gr = Graphics.FromImage(bmp);
            gr.CopyFromScreen(0, 0, 0, 0, new Size(bmp.Width, bmp.Height));
            pictureBox1.Image = bmp;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);

        }

      

      

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            groupBox1.Dock = DockStyle.Fill;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            groupBox1.Dock = DockStyle.None;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            Graphics graphics = Graphics.FromImage(bitmap as Image);
            string namafile = txttitle.Text;

            graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
            SaveFileDialog sd = new SaveFileDialog();
            sd.InitialDirectory = @"C:\";
            sd.Title = "Save Screen Shoot Files";
            //sd.CheckFileExists = true;
            //sd.CheckPathExists = true;
            sd.DefaultExt = "jpg";
            //sd.Filter = "Text files (*.jpg)|*.jpg|All files (*.*)|*.*";
            sd.FilterIndex = 2;
            sd.RestoreDirectory = true;
            if (sd.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(@"C:\Users\Acer\Documents\Visual Studio 2015\Projects\ConsoleApplication16\WindowsFormsApplication1\bin\Debug\'" + sd.FileName + "'.jpg", ImageFormat.Jpeg);

            }
        }
    }
}
