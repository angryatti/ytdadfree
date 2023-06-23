using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ytd_ncore
{
    public partial class VideoFromAudio : Form
    {
        public VideoFromAudio()
        {
            InitializeComponent();
        }

        private void openpic_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                System.IO.File.Copy(openFileDialog1.FileName, System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "pic.jpg"), true);

                unloadedpic.Text = "loaded";
                unloadedpic.ForeColor = Color.Green;


                if (previewofload.Image != null) previewofload.Image.Dispose();

                using (Bitmap bm = new Bitmap("pic.jpg"))
                {
                    previewofload.Image = new Bitmap(bm);
                }

                previewofload.Size = new System.Drawing.Size(640, 480);
                previewofload.SizeMode = PictureBoxSizeMode.CenterImage;
                previewofload.Invalidate();

            }



            else
            {
                MessageBox.Show("Picture invalid! / A kép érvénytelen!");

            }
        }

        private void VideoFromAudio_Load(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = ".jpg";

        }

        private void opentheaudio_Click(object sender, EventArgs e)
        {

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                if (formatfilter.Text == "mp3")
                {
                    System.IO.File.Copy(openFileDialog2.FileName, System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "audiosource.mp3"), true);


                }
                else if (formatfilter.Text == "aac")
                {
                    System.IO.File.Copy(openFileDialog2.FileName, System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "audiosource.aac"), true);

                }
                else
                {

                    System.IO.File.Copy(openFileDialog2.FileName, System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "audiosource.mp3"), true);

                }

                unloadedaudio.Text = "loaded";
                unloadedaudio.ForeColor = Color.Green;

            }

        }

        private void makemp4_Click(object sender, EventArgs e)
        {
            if (unloadedaudio.ForeColor != Color.Green && unloadedpic.ForeColor != Color.Green)
            {
                MessageBox.Show("Audio or Picture is unloaded!");

            }
            else
            {


                Process.Start("ffmpeg", " -i pic.jpg -pix_fmt yuv420p picfinal.jpg");
                Process[] workers3 = Process.GetProcessesByName("ffmpeg");
                foreach (Process worker in workers3)
                {

                    worker.WaitForExit();
                    worker.Dispose();
                }

                if (formatfilter.Text != "aac")
                {

                    Process.Start("ffmpeg", " -loop 1 -y -i picfinal.jpg -i audiosource.mp3 -shortest outputvideo.mp4");

                }
                else
                {
                    Process.Start("ffmpeg", " -loop 1 -y -i picfinal.jpg -i audiosource.aac -shortest outputvideo.mp4");
                }

                //  saveFileDialog1 = new SaveFileDialog();
                string fileName = "outputvideo.mp4";
                // Stream myStream;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)

                {
                    if ((saveFileDialog1.OpenFile()) != null)
                    {


                        System.IO.File.Copy(fileName, saveFileDialog1.FileName, true);
                    }
                }
                Process[] workers4 = Process.GetProcessesByName("ffmpeg");
                foreach (Process worker in workers4)
                {

                    worker.WaitForExit();
                    worker.Dispose();
                }

                if (System.IO.File.Exists("pic.jpg"))
                {
                    System.IO.File.Delete("pic.jpg");
                }

                if (System.IO.File.Exists("picfinal.jpg"))
                {
                    System.IO.File.Delete("picfinal.jpg");
                }

                if (System.IO.File.Exists("audiosource.mp3"))
                {
                    System.IO.File.Delete("audiosource.mp3");
                }
                unloadedaudio.ForeColor = Color.Red;
                unloadedpic.ForeColor = Color.Red;
                unloadedaudio.Text = "unloaded";
                unloadedpic.Text = "unloaded";


            }
        }

        private void goback_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();

            this.Dispose();
        }

        private void VideoFromAudio_FormClosing(object sender, FormClosingEventArgs e)
        {
            goback_Click(sender, e);

        }
    }
}
