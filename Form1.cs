using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace slideShow
{
    public partial class Form1 : Form
    {
        private string path;
        private string[] paths;
        private int index;
        private int x = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadNextImage()
        {
            if (index >= paths.Length) index = 0;
            if (index < 0) index = paths.Length - 1;
            tpp.Text = (index + 1).ToString();
            pictureBox1.ImageLocation = paths[index];
            index++;
            timer3.Stop();
        }

        private void imageFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void startSlideshow_Click(object sender, EventArgs e)
        {
            index = 0;
            if(radiolocal.Checked)
                paths = System.IO.Directory.GetFiles(path, "*.*", System.IO.SearchOption.AllDirectories);
            else if (radioweb.Checked)
            {
                List<string> mll = class1.DownloadAllImages(webdir.Text);
                paths = new string[mll.Count];
                for (int i = 0; i < mll.Count; i++)
                {
                    paths[i] = mll[i];
                }
            }

            timer1.Interval = Convert.ToInt32(showSpeed.Value);
            timer1.Start();
            pauseResume.Enabled = true;
            forward.Enabled = true;
            back.Enabled = true;
            if (pauseResume.Text == "გაგრძელება")
            {
                pauseResume.Text = "დაპაუზება";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer2.Start();
            timer3.Start();
        }

        private void showSpeed_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(showSpeed.Value);
        }

        private void pauseResume_Click(object sender, EventArgs e)
        {
            if(pauseResume.Text == "დაპაუზება")
            {
                timer1.Stop();
                pauseResume.Text = "გაგრძელება";
            }
            else
            {
                timer1.Start();
                pauseResume.Text = "დაპაუზება";
            }

        }

        private void browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.ShowDialog();
            directory.Text = dlg.SelectedPath;
            path = dlg.SelectedPath;
        }

        private void back_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            index-=2;
            LoadNextImage();
            timer1.Start();
        }

        private void forward_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadNextImage();
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Location == new Point(100, 78))
            {
                timer2.Stop();
                pictureBox1.SetBounds(0, 78, 1171, 516);
            }
            if(pictureBox1.Location == new Point(-1400, 78))
            {
                x = 1400;
            }
            x -= 100;
            pictureBox1.SetBounds(x, 78, 1171, 516);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void radioweb_CheckedChanged(object sender, EventArgs e)
        {
            webdir.Enabled = true;
            browse.Enabled = false;
        }

        private void radiolocal_CheckedChanged(object sender, EventArgs e)
        {
            webdir.Enabled = false;
            browse.Enabled = true;
        }

    }
}
