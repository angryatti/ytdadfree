using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Drawing;
using System.Net;
using System.ComponentModel;
//ing System.Management;
//using System.Net.Http.WebRequest;

namespace ytd_ncore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        string settingsengine;
        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        private void dwndnconv_Click(object sender, EventArgs e)
        {



            if (videourltext.Text != "") button8_Click(sender, e);
            progressBar1.Value = 25;
            label1.Text = "Task: 1/3";

            if (videourltext.Text != "" && videourltext.Text.Length == 43 || fbookdown.Checked == true)
            {
                if (settingsengine != "Engine=Default")
                {
                    Process.Start("yt-dlp.exe", videourltext.Text + " -o downloadedfile");

                }
                else
                {
                    if (reducedvideo.Checked)
                    {
                        Process.Start("youtube-dl.exe", " -f worst " + videourltext.Text + " -o downloadedfile.mp4");

                    }
                    else
                    {
                        Process.Start("youtube-dl.exe", videourltext.Text + " -o downloadedfile");
                    }
                }

                if (File.Exists("downloadedfile"))
                {

                    File.Move("downloadedfile", "downloadedfile.webm");


                }


                if (settingsengine != "Engine=Default")
                {
                    Process[] workers = Process.GetProcessesByName("yt-dlp");

                    foreach (Process worker in workers)
                    {

                        worker.WaitForExit();
                        worker.Dispose();
                    }
                }
                else
                {
                    Process[] workers = Process.GetProcessesByName("youtube-dl");

                    foreach (Process worker in workers)
                    {

                        worker.WaitForExit();
                        worker.Dispose();
                    }
                }
                if (onlymkvcheck.Checked)
                {
                    label1.Text = "Task Completed";
                    progressBar1.Value = 100;
                }
                else
                {
                    progressBar1.Value = 25;
                }
                if (comboBox1.Text == "aac")
                {
                    if (System.IO.File.Exists("downloadedfile.webm") || (System.IO.File.Exists("downloadedfile.mkv") || (System.IO.File.Exists("downloadedfile.mp4"))))
                    {
                        if (System.IO.File.Exists("downloadedfile.webm") && (cBaactrue.Checked))
                        {
                            Process.Start("ffmpeg", "-i downloadedfile.webm -c:a libfdk_aac -vbr 5 finalfile." + comboBox1.Text);
                        }
                        if (System.IO.File.Exists("downloadedfile.mkv") && (cBaactrue.Checked))
                        {
                            Process.Start("ffmpeg", "-i downloadedfile.mkv -c:a libfdk_aac -vbr 5 finalfile." + comboBox1.Text);
                        }
                        if (System.IO.File.Exists("downloadedfile.mp4") && (cBaactrue.Checked))
                        {
                            Process.Start("ffmpeg", "-i downloadedfile.mp4 -c:a libfdk_aac -vbr 5 finalfile." + comboBox1.Text);
                        }
                    }

                }

                if ((!onlymkvcheck.Checked) && (!(comboBox1.Text == "no_convert")) && !(comboBox1.Text == "aac"))
                {


                    if (System.IO.File.Exists("downloadedfile.webm") || (System.IO.File.Exists("downloadedfile.mkv") || (System.IO.File.Exists("downloadedfile.mp4"))))

                    {

                        if (System.IO.File.Exists("downloadedfile.webm"))

                            if (!hwaccer.Checked)
                            {

                                if (!reducedaudio.Checked)
                                {
                                    Process.Start("ffmpeg", "-i downloadedfile.webm -b:a 320k finalfile." + comboBox1.Text);


                                }
                                else
                                {
                                    Process.Start("ffmpeg", "-i downloadedfile.webm -b:a 128k finalfile." + comboBox1.Text);
                                }

                            }
                            else
                            {

                                if (cuda.BackColor != Color.Green && amdgpu.BackColor != Color.Red)
                                {
                                    if (!reducedaudio.Checked)
                                    {
                                        Process.Start("ffmpeg", " -hwaccel dxva2 -i downloadedfile.webm -b:a 320k finalfile." + comboBox1.Text);
                                    }
                                    else
                                    {
                                        Process.Start("ffmpeg", " -hwaccel dxva2 -i downloadedfile.webm -b:a 128k finalfile." + comboBox1.Text);
                                    }

                                }
                                else if (cuda.BackColor == Color.Green)
                                {
                                    if (!reducedaudio.Checked)
                                    {
                                        Process.Start("ffmpeg", " -hwaccel cuda -i downloadedfile.webm -b:a 320k finalfile." + comboBox1.Text);
                                    }
                                    else
                                    {
                                        Process.Start("ffmpeg", " -hwaccel cuda -i downloadedfile.webm -b:a 128k finalfile." + comboBox1.Text);

                                    }

                                }
                                else if (amdgpu.BackColor == Color.Red)
                                {
                                    if (!reducedaudio.Checked)
                                    {
                                        Process.Start("ffmpeg", " -hwaccel vdpau -i downloadedfile.webm -b:a 320k finalfile." + comboBox1.Text);
                                    }
                                    else
                                    {
                                        Process.Start("ffmpeg", " -hwaccel vdpau -i downloadedfile.webm -b:a 128k finalfile." + comboBox1.Text);
                                    }
                                }




                            }


                        if (System.IO.File.Exists("downloadedfile.mkv"))

                            if (!hwaccer.Checked)
                            {

                                if (!reducedaudio.Checked)
                                {
                                    Process.Start("ffmpeg", "-i downloadedfile.mkv -b:a 320k finalfile." + comboBox1.Text);
                                }
                                else
                                {
                                    Process.Start("ffmpeg", "-i downloadedfile.mkv -b:a 128k finalfile." + comboBox1.Text);
                                }

                            }
                            else
                            {

                                if (cuda.BackColor != Color.Green && amdgpu.BackColor != Color.Red)
                                {
                                    if (!reducedaudio.Checked)
                                    {
                                        Process.Start("ffmpeg", " -hwaccel dxva2 -i downloadedfile.mkv -b:a 320k finalfile." + comboBox1.Text);
                                    }
                                    else
                                    {
                                        Process.Start("ffmpeg", " -hwaccel dxva2 -i downloadedfile.mkv -b:a 128k finalfile." + comboBox1.Text);
                                    }

                                }
                                else if (cuda.BackColor == Color.Green)
                                {
                                    if (!reducedaudio.Checked)
                                    {
                                        Process.Start("ffmpeg", " -hwaccel cuda -i downloadedfile.mkv -b:a 320k finalfile." + comboBox1.Text);
                                    }
                                    else
                                    {
                                        Process.Start("ffmpeg", " -hwaccel cuda -i downloadedfile.mkv -b:a 128k finalfile." + comboBox1.Text);

                                    }

                                }
                                else if (amdgpu.BackColor == Color.Red)
                                {
                                    if (!reducedaudio.Checked)
                                    {
                                        Process.Start("ffmpeg", " -hwaccel vdpau -i downloadedfile.mkv -b:a 320k finalfile." + comboBox1.Text);
                                    }
                                    else
                                    {
                                        Process.Start("ffmpeg", " -hwaccel vdpau -i downloadedfile.mkv -b:a 128k finalfile." + comboBox1.Text);
                                    }
                                }




                            }

                        if (System.IO.File.Exists("downloadedfile.mp4"))
                        {
                            if (!reducedaudio.Checked)
                            {
                                Process.Start("ffmpeg", "-i downloadedfile.mp4 -b:a 320k finalfile." + comboBox1.Text);
                            }
                            else
                            {
                                Process.Start("ffmpeg", "-i downloadedfile.mp4 -b:a 128k finalfile." + comboBox1.Text);
                            }

                        }
                        else
                        {

                            if (cuda.BackColor != Color.Green && amdgpu.BackColor != Color.Red)
                            {
                                if (!reducedaudio.Checked)
                                {
                                    Process.Start("ffmpeg", " -hwaccel dxva2 -i downloadedfile.mp4 -b:a 320k finalfile." + comboBox1.Text);
                                }
                                else
                                {
                                    Process.Start("ffmpeg", " -hwaccel dxva2 -i downloadedfile.mp4 -b:a 128k finalfile." + comboBox1.Text);
                                }

                            }
                            else if (cuda.BackColor == Color.Green)
                            {
                                if (!reducedaudio.Checked)
                                {
                                    Process.Start("ffmpeg", " -hwaccel cuda -i downloadedfile.mp4 -b:a 320k finalfile." + comboBox1.Text);
                                }
                                else
                                {
                                    Process.Start("ffmpeg", " -hwaccel cuda -i downloadedfile.mp4 -b:a 128k finalfile." + comboBox1.Text);

                                }

                            }
                            else if (amdgpu.BackColor == Color.Red)
                            {
                                if (!reducedaudio.Checked)
                                {
                                    Process.Start("ffmpeg", " -hwaccel vdpau -i downloadedfile.mp4 -b:a 320k finalfile." + comboBox1.Text);
                                }
                                else
                                {
                                    Process.Start("ffmpeg", " -hwaccel vdpau -i downloadedfile.mp4 -b:a 128k finalfile." + comboBox1.Text);
                                }
                            }




                        }
                        label1.Text = "Task: 2/3";
                        progressBar1.Value = 50;
                    }
                    else
                    {
                        MessageBox.Show("Nem töltötted le a videót");
                    }

                }
            }
            else
            {
                //   ("");

                MessageBox.Show("Adjon meg egy youtube-url-t / Please Give a youtube URL!");

            }
            Process[] workers3 = Process.GetProcessesByName("ffmpeg");

            foreach (Process worker in workers3)
            {

                worker.WaitForExit();
                worker.Dispose();
            }
            progressBar1.Value = 75;

            if (addcover.Checked)
            {
                label1.Text = "Task: 3/3";
            }
            else
            {
                label1.Text = "Task: Completed";
                progressBar1.Value = 100;
            }

            if (addcover.Checked)
            {

                if (System.IO.File.Exists("downloadedshot.webp"))
                    System.IO.File.Delete("downloadedshot.webp");

                if (System.IO.File.Exists("downloadedshot.jpg"))
                    System.IO.File.Delete("downloadedshot.jpg");

                if (System.IO.File.Exists("downloadedshot.png"))
                    System.IO.File.Delete("downloadedshot.png");

                Process.Start("youtube-dl.exe", " --write-thumbnail --skip-download " + videourltext.Text + " --output downloadedshot");


                Process[] workers = Process.GetProcessesByName("youtube-dl");

                foreach (Process worker in workers)
                {

                    worker.WaitForExit();
                    worker.Dispose();
                }

                Process.Start("ffmpeg.exe", " -i downloadedshot.webp downloadedshot.png");                                                                                                            //


                Process[] workers2 = Process.GetProcessesByName("ffmpeg");

                foreach (Process worker in workers2)
                {

                    worker.WaitForExit();
                    worker.Dispose();
                }


                if (System.IO.File.Exists("downloadedshot.jpg"))

                {
                    Process.Start("ffmpeg.exe", " -i downloadedshot.jpg -pix_fmt rgba downloadedshot.png");
                }
                else
                {
                    Process.Start("ffmpeg.exe", " -i downloadedshot.webp downloadedshot.png");
                }

                Process[] workers5 = Process.GetProcessesByName("ffmpeg");

                foreach (Process worker in workers5)
                {

                    worker.WaitForExit();
                    worker.Dispose();
                }

                if (!reducedaudio.Checked)
                {
                    Process.Start("lame.exe", " --ti downloadedshot.png -b 320 finalfile.mp3");
                }
                else
                {

                    Process.Start("lame.exe", " --ti downloadedshot.png -b 128 finalfile.mp3");
                }

                Process[] workers4 = Process.GetProcessesByName("lame");

                foreach (Process worker in workers4)
                {

                    worker.WaitForExit();
                    worker.Dispose();
                }
                progressBar1.Value = 100;
                label1.Text = "Task: Completed";

                if (System.IO.File.Exists("finalfile.mp3.mp3"))
                {
                    System.IO.File.Delete("finalfile.mp3");
                    System.IO.File.Move("finalfile.mp3.mp3", "finalfile.mp3");

                }

            }
            if (autoshutdownbn.Checked)

            {
                Process.Start("shutdown", " -s -t 100");





                this.Close();
            }
        }










        private void convertmanually_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "aac")
            {
                if (System.IO.File.Exists("downloadedfile.webm") || (System.IO.File.Exists("downloadedfile.mkv") || (System.IO.File.Exists("downloadedfile.mp4"))))
                {
                    if (System.IO.File.Exists("downloadedfile.webm") && (cBaactrue.Checked))
                    {
                        Process.Start("ffmpeg", "-i downloadedfile.webm -c:a libfdk_aac -vbr 5 finalfile." + comboBox1.Text);
                    }
                    if (System.IO.File.Exists("downloadedfile.mkv") && (cBaactrue.Checked))
                    {
                        Process.Start("ffmpeg", "-i downloadedfile.mkv -c:a libfdk_aac -vbr 5 finalfile." + comboBox1.Text);
                    }
                    if (System.IO.File.Exists("downloadedfile.mp4") && (cBaactrue.Checked))
                    {
                        Process.Start("ffmpeg", "-i downloadedfile.mp4 -c:a libfdk_aac -vbr 5 finalfile." + comboBox1.Text);
                    }
                }

            }

            if (!(comboBox1.Text == "no_convert"))
            {

                if (System.IO.File.Exists("downloadedfile.webm") || (System.IO.File.Exists("downloadedfile.mkv")) || (System.IO.File.Exists("downloadedfile.mp4")))

                {

                    if (System.IO.File.Exists("downloadedfile.webm"))

                        if (!hwaccer.Checked)
                        {

                            if (!reducedaudio.Checked)
                            {
                                Process.Start("ffmpeg", "-i downloadedfile.webm -b:a 320k finalfile." + comboBox1.Text);
                            }
                            else
                            {
                                Process.Start("ffmpeg", "-i downloadedfile.webm -b:a 128k finalfile." + comboBox1.Text);
                            }

                        }
                        else
                        {

                            if (cuda.BackColor != Color.Green && amdgpu.BackColor != Color.Red)
                            {
                                if (!reducedaudio.Checked)
                                {
                                    Process.Start("ffmpeg", " -hwaccel dxva2 -i downloadedfile.webm -b:a 320k finalfile." + comboBox1.Text);
                                }
                                else
                                {
                                    Process.Start("ffmpeg", " -hwaccel dxva2 -i downloadedfile.webm -b:a 128k finalfile." + comboBox1.Text);
                                }

                            }
                            else if (cuda.BackColor == Color.Green)
                            {
                                if (!reducedaudio.Checked)
                                {
                                    Process.Start("ffmpeg", " -hwaccel cuda -i downloadedfile.webm -b:a 320k finalfile." + comboBox1.Text);
                                }
                                else
                                {
                                    Process.Start("ffmpeg", " -hwaccel cuda -i downloadedfile.webm -b:a 128k finalfile." + comboBox1.Text);

                                }

                            }
                            else if (amdgpu.BackColor == Color.Red)
                            {
                                if (!reducedaudio.Checked)
                                {
                                    Process.Start("ffmpeg", " -hwaccel vdpau -i downloadedfile.webm -b:a 320k finalfile." + comboBox1.Text);
                                }
                                else
                                {
                                    Process.Start("ffmpeg", " -hwaccel vdpau -i downloadedfile.webm -b:a 128k finalfile." + comboBox1.Text);
                                }
                            }




                        }


                    if (System.IO.File.Exists("downloadedfile.mkv"))

                        if (!hwaccer.Checked)
                        {

                            if (!reducedaudio.Checked)
                            {
                                Process.Start("ffmpeg", "-i downloadedfile.mkv -b:a 320k finalfile." + comboBox1.Text);
                            }
                            else
                            {
                                Process.Start("ffmpeg", "-i downloadedfile.mkv -b:a 128k finalfile." + comboBox1.Text);
                            }

                        }
                        else
                        {

                            if (cuda.BackColor != Color.Green && amdgpu.BackColor != Color.Red)
                            {
                                if (!reducedaudio.Checked)
                                {
                                    Process.Start("ffmpeg", " -hwaccel dxva2 -i downloadedfile.mkv -b:a 320k finalfile." + comboBox1.Text);
                                }
                                else
                                {
                                    Process.Start("ffmpeg", " -hwaccel dxva2 -i downloadedfile.mkv -b:a 128k finalfile." + comboBox1.Text);
                                }

                            }
                            else if (cuda.BackColor == Color.Green)
                            {
                                if (!reducedaudio.Checked)
                                {
                                    Process.Start("ffmpeg", " -hwaccel cuda -i downloadedfile.mkv -b:a 320k finalfile." + comboBox1.Text);
                                }
                                else
                                {
                                    Process.Start("ffmpeg", " -hwaccel cuda -i downloadedfile.mkv -b:a 128k finalfile." + comboBox1.Text);

                                }

                            }
                            else if (amdgpu.BackColor == Color.Red)
                            {
                                if (!reducedaudio.Checked)
                                {
                                    Process.Start("ffmpeg", " -hwaccel vdpau -i downloadedfile.mkv -b:a 320k finalfile." + comboBox1.Text);
                                }
                                else
                                {
                                    Process.Start("ffmpeg", " -hwaccel vdpau -i downloadedfile.mkv -b:a 128k finalfile." + comboBox1.Text);
                                }
                            }




                        }

                    if (System.IO.File.Exists("downloadedfile.mp4"))
                    {
                        if (!reducedaudio.Checked)
                        {
                            Process.Start("ffmpeg", "-i downloadedfile.mp4 -b:a 320k finalfile." + comboBox1.Text);
                        }
                        else
                        {
                            Process.Start("ffmpeg", "-i downloadedfile.mp4 -b:a 128k finalfile." + comboBox1.Text);
                        }

                    }
                    else
                    {

                        if (cuda.BackColor != Color.Green && amdgpu.BackColor != Color.Red)
                        {
                            if (!reducedaudio.Checked)
                            {
                                Process.Start("ffmpeg", " -hwaccel dxva2 -i downloadedfile.mp4 -b:a 320k finalfile." + comboBox1.Text);
                            }
                            else
                            {
                                Process.Start("ffmpeg", " -hwaccel dxva2 -i downloadedfile.mp4 -b:a 128k finalfile." + comboBox1.Text);
                            }

                        }
                        else if (cuda.BackColor == Color.Green)
                        {
                            if (!reducedaudio.Checked)
                            {
                                Process.Start("ffmpeg", " -hwaccel cuda -i downloadedfile.mp4 -b:a 320k finalfile." + comboBox1.Text);
                            }
                            else
                            {
                                Process.Start("ffmpeg", " -hwaccel cuda -i downloadedfile.mp4 -b:a 128k finalfile." + comboBox1.Text);

                            }

                        }
                        else if (amdgpu.BackColor == Color.Red)
                        {
                            if (!reducedaudio.Checked)
                            {
                                Process.Start("ffmpeg", " -hwaccel vdpau -i downloadedfile.mp4 -b:a 320k finalfile." + comboBox1.Text);
                            }
                            else
                            {
                                Process.Start("ffmpeg", " -hwaccel vdpau -i downloadedfile.mp4 -b:a 128k finalfile." + comboBox1.Text);
                            }
                        }




                    }

                    Process[] workers4 = Process.GetProcessesByName("ffmpeg");

                    foreach (Process worker in workers4)
                    {

                        worker.WaitForExit();
                        worker.Dispose();
                    }
                    if (addcover.Checked)
                    {

                        if (System.IO.File.Exists("downloadedshot.webp"))
                            System.IO.File.Delete("downloadedshot.webp");

                        if (System.IO.File.Exists("downloadedshot.png"))
                            System.IO.File.Delete("downloadedshot.png");


                        Process.Start("youtube-dl.exe", " --write-thumbnail --skip-download " + videourltext.Text + " --output downloadedshot");


                        Process[] workers = Process.GetProcessesByName("youtube-dl");

                        foreach (Process worker in workers)
                        {

                            worker.WaitForExit();
                            worker.Dispose();
                        }
                        if (System.IO.File.Exists("downloadedshot.jpg"))

                        {
                            Process.Start("ffmpeg.exe", " -i downloadedshot.jpg -pix_fmt rgba downloadedshot.png");
                        }
                        else
                        {
                            Process.Start("ffmpeg.exe", " -i downloadedshot.webp downloadedshot.png");
                        }



                        Process[] workers2 = Process.GetProcessesByName("ffmpeg");

                        foreach (Process worker in workers2)
                        {

                            worker.WaitForExit();
                            worker.Dispose();
                        }


                        if (!reducedaudio.Checked)
                        {
                            Process.Start("lame.exe", " --ti downloadedshot.png -b 320 finalfile.mp3");
                        }
                        else
                        {

                            Process.Start("lame.exe", " --ti downloadedshot.png -b 128 finalfile.mp3");
                        }


                        Process[] workers5 = Process.GetProcessesByName("lame");

                        foreach (Process worker in workers5)
                        {

                            worker.WaitForExit();
                            worker.Dispose();
                        }
                        if (System.IO.File.Exists("finalfile.mp3.mp3"))
                        {
                            System.IO.File.Delete("finalfile.mp3");
                            System.IO.File.Move("finalfile.mp3.mp3", "finalfile.mp3");
                        }

                    }



                }
                else
                {
                    MessageBox.Show("Nem töltötte le a videót");
                }
            }
            else
            {
                MessageBox.Show("No convert selected / Nincs konvertálás!");


            }
            if (autoshutdownbn.Checked)

            {
                Process.Start("shutdown", " -s -t 100");

                this.Close();
            }
        }


        private void renameandsave_Click(object sender, EventArgs e)
        {

            string fileName = "finalfile." + comboBox1.Text;
            saveFileDialog1.FilterIndex = 0;

            if ((System.IO.File.Exists(fileName) || (System.IO.File.Exists("downloadedfile.mp4") || (System.IO.File.Exists("downloadedfile.mkv") || (System.IO.File.Exists("downloadedfile.webm"))))))
            {


                saveFileDialog1.FileName = label6.Text + "." + comboBox1.SelectedText;


                if (System.IO.File.Exists("finalfile.mp3"))
                {
                    saveFileDialog1.FileName = label6.Text + ".mp3";
                    saveFileDialog1.FilterIndex = 0;

                }
                if (System.IO.File.Exists("finalfile.aac"))
                {
                    saveFileDialog1.FileName = label6.Text + ".aac";

                }

                if ((System.IO.File.Exists("downloadedfile.mkv")) && (!System.IO.File.Exists(fileName)))

                {
                    fileName = "downloadedfile.mkv"; saveFileDialog1.FileName = label6.Text + ".mkv";
                    saveFileDialog1.FilterIndex = 4;

                }
                if ((System.IO.File.Exists("downloadedfile.mp4")) && (!System.IO.File.Exists(fileName)))
                {
                    fileName = "downloadedfile.mp4"; saveFileDialog1.FileName = label6.Text + ".mp4";

                    saveFileDialog1.FilterIndex = 3;
                }

                if ((System.IO.File.Exists("downloadedfile.webm")) && (!System.IO.File.Exists(fileName)))
                {
                    fileName = "downloadedfile.webm"; saveFileDialog1.FileName = label6.Text + ".webm";
                    saveFileDialog1.FilterIndex = 5;
                }


                if (saveFileDialog1.ShowDialog() == DialogResult.OK)

                {

                    System.IO.File.Copy(fileName, saveFileDialog1.FileName, true);

                    if (System.IO.File.Exists("finalfile.mp3")) System.IO.File.Delete("finalfile.mp3");
                    if (System.IO.File.Exists("finalfile.mp3")) System.IO.File.Delete("finalfile2.mp3");


                    if (System.IO.File.Exists("downloadedfile.mkv")) System.IO.File.Delete("downloadedfile.mkv");
                    if (System.IO.File.Exists("downloadedfile.mp4")) System.IO.File.Delete("downloadedfile.mp4");
                    if (System.IO.File.Exists("downloadedfile.webm")) System.IO.File.Delete("downloadedfile.webm");
                    if (System.IO.File.Exists("downloadedshot.jpg")) System.IO.File.Delete("downloadedshot.jpg");

                }
            }
            else
            {
                MessageBox.Show("Nem töltöttél le és/vagy nem konvertáltál");
                if (System.IO.File.Exists("finalfile.mp3")) System.IO.File.Delete("finalfile.mp3");
                if (System.IO.File.Exists("finalfile.mp3")) System.IO.File.Delete("finalfile2.mp3");


                if (System.IO.File.Exists("downloadedfile.mkv")) System.IO.File.Delete("downloadedfile.mkv");
                if (System.IO.File.Exists("downloadedfile.mp4")) System.IO.File.Delete("downloadedfile.mp4");
                if (System.IO.File.Exists("downloadedfile.webm")) System.IO.File.Delete("downloadedfile.webm");
                if (System.IO.File.Exists("downloadedshot.jpg")) System.IO.File.Delete("downloadedshot.jpg");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (unnessaryfiles.Checked)
            {
                System.IO.File.Delete("downloadedfile.mkv");

                if (!autoshutdownbn.Checked)
                {
                    System.IO.File.Delete("finalfile." + comboBox1.Text);
                }
                System.IO.File.Delete("downloadedshot.webp");
                System.IO.File.Delete("downloadedshot.jpg");
                System.IO.File.Delete("downloadedshot.png");
                System.IO.File.Delete("downloadedfile.webm");
                System.IO.File.Delete("downloadedfile.mp4");

            }
            Application.ExitThread();
        }



        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unnessaryfiles.Checked)
            {
                System.IO.File.Delete("downloadedfile.mkv");
                System.IO.File.Delete("finalfile." + comboBox1.Text);
                System.IO.File.Delete("downloadedshot.webp");
                System.IO.File.Delete("downloadedshot.jpg");
                System.IO.File.Delete("downloadedfile.webm");
                System.IO.File.Delete("downloadedfile.mp4");
            }

            Application.ExitThread();



        }

        private void requrziveloadandcut_Click(object sender, EventArgs e)
        {
            string str = Convert.ToString((char)34);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                Process.Start("ffmpeg", " -i " + str + openFileDialog1.FileName + str + " -f segment -segment_time " + splittimevalue.Text + " -c copy copyout%03d.mp3");


            }
        }

        private void soundloadandcut_Click(object sender, EventArgs e)
        {
            string str = Convert.ToString((char)34);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                Process.Start("ffmpeg", "-i " + str + openFileDialog1.FileName + str + " -acodec copy -ss " + starttime.Text + " -to " + endtime.Text + " vagottfile.mp3");

            }
        }

        private void destroydownload_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("downloadedfile.webm"))
                System.IO.File.Delete("downloadedfile.webm");
            if (System.IO.File.Exists("downloadedfile.mkv"))
                System.IO.File.Delete("downloadedfile.mkv");
            if (System.IO.File.Exists("downloadedfile.mp4"))
                System.IO.File.Delete("downloadedfile.mp4");


            ;
        }

        private void destroyconvert_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("finalfile.mp3"))
                System.IO.File.Delete("finalfile.mp3");
            if (System.IO.File.Exists("finalfile.mp4"))
                System.IO.File.Delete("finalfile.mp4");

            if (System.IO.File.Exists("finalfile.mkv"))
                System.IO.File.Delete("finalfile.mkv");
            if (System.IO.File.Exists("finalfile.aac"))
                System.IO.File.Delete("finalfile.aac");


        }



        private void button8_Click(object sender, EventArgs e)
        {



            if (videourltext.Text != "")

            {
                //        {
                //                string str = Convert.ToString((char)34);
                if (!onlymkvcheck.Checked)
                {

                    using (StreamWriter outputFile = new StreamWriter("ytd.bat"))

                    {
                        //  outputFile.WriteLine("");
                        outputFile.WriteLine("yt-dlp.exe --get-title  --windows-filenames " + videourltext.Text + " >> info.txt", System.Text.Encoding.UTF8);
                        outputFile.Close();

                        //               )
                    }

                    //Process.Start("cmd","/c ytd.bat");
                    ExecuteCommand("ytd.bat");






                    byte[] ansiBytes = File.ReadAllBytes("info.txt");

                    var utf8String = System.Text.Encoding.Default.GetString(ansiBytes);

                    File.WriteAllText("info2.txt", utf8String);

                    using (StreamReader inputFile = new StreamReader("info2.txt", System.Text.Encoding.UTF8))


                    {
                        // label6.Text = inputFile.ReadLine();
                        label6.Text = inputFile.ReadLine();
                        inputFile.Close();

                    }

                }

                videotitle.Visible = true;
            }
            if (System.IO.File.Exists("info.txt"))
                System.IO.File.Delete("info.txt");
            if (System.IO.File.Exists("info2.txt"))
                System.IO.File.Delete("info2.txt");
            if (System.IO.File.Exists("ytd.bat"))
                System.IO.File.Delete("ytd.bat");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            angolToolStripMenuItem.Enabled = true;
            comboBox1.SelectedIndex = 0;

            StreamReader readfile = new StreamReader("config.ini");
            while (!readfile.EndOfStream)
            {
                settingsengine = readfile.ReadLine();
                settingsengine = readfile.ReadLine();


            }
            readfile.Close();
        
            if (settingsengine != "Engine=Default" && System.IO.File.Exists("youtube-dl.exe"))
            {
                engineytd.Checked = true;

            }
            else
            {
                if (!System.IO.File.Exists("youtube-dl.exe"))
                {

                    MessageBox.Show("A youtube-dl.exe fájlt le kell töltenije a programnak! / The program is downloading the youtube-dl.exe");

                    string remoteUri = "https://github.com/ytdl-org/youtube-dl/releases/download/2021.12.17/";
                    string fileName = "youtube-dl.exe";
                    WebClient myWebClient = new WebClient();
                    string myStringWebResource = remoteUri + fileName;

                    myWebClient.DownloadFile(myStringWebResource, fileName);

                    MessageBox.Show("Letöltés befejeződött! / Download Completed!");

                }

            }
        }
        static void ExecuteCommand(string command)
        {
            var processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            var process = Process.Start(processInfo);

            process.OutputDataReceived += (object sender, DataReceivedEventArgs e) =>
                Console.WriteLine("output>>" + e.Data);
            process.BeginOutputReadLine();

            process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) =>
                Console.WriteLine("error>>" + e.Data);
            process.BeginErrorReadLine();

            process.WaitForExit();

            Console.WriteLine("ExitCode: {0}", process.ExitCode);
            process.Close();
        }

     

        private void urlreset_Click(object sender, EventArgs e)
        {
            videourltext.Text = "";
        }




        private void copyclipboard_Click_1(object sender, EventArgs e)
        {

            videourltext.Text = Clipboard.GetText();
            DialogResult dialogResult = MessageBox.Show("Letöltés és konvertálás", "Elindítja a letöltést illetve konvertálást?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dwndnconv_Click(sender, e);
            }





        }

        private void checkvideopic_Click(object sender, EventArgs e)
        {


            if (System.IO.File.Exists("downloadedshot.webp"))
                System.IO.File.Delete("downloadedshot.webp");

            if (System.IO.File.Exists("downloadedshot.jpg"))
                System.IO.File.Delete("downloadedshot.jpg");


            Process.Start("youtube-dl.exe", " --write-thumbnail --skip-download " + videourltext.Text + " --output downloadedshot");


            Process[] workers = Process.GetProcessesByName("youtube-dl");

            foreach (Process worker in workers)
            {

                worker.WaitForExit();
                worker.Dispose();
            }

            if (!System.IO.File.Exists("downnloadedshot.jpg"))
            {
                Process.Start("ffmpeg.exe", " -i downloadedshot.webp downloadedshot.jpg");                                                                                                            //


                Process[] workers2 = Process.GetProcessesByName("ffmpeg");

                foreach (Process worker in workers2)
                {

                    worker.WaitForExit();
                    worker.Dispose();
                }

            }
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();



        }

        private void cuda_Click(object sender, EventArgs e)
        {

            if (cuda.BackColor != Color.Green)
            {
                cuda.BackColor = Color.Green;
                amdgpu.BackColor = Color.Black;
                hwaccer.Checked = true;
            }
            else
            {
                cuda.BackColor = Color.Black;
                hwaccer.Checked = false;
            }
        }

        private void amdgpu_Click(object sender, EventArgs e)
        {
            if (amdgpu.BackColor != Color.Red)
            {
                amdgpu.BackColor = Color.Red;
                cuda.BackColor = Color.Black;
                hwaccer.Checked = true;
            }
            else
            {
                amdgpu.BackColor = Color.Black;

                hwaccer.Checked = false;
            }
        }









        private void autoshutdownbn_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Letöltés és/vagy Konvertálás után számítógép kikapcsolása. A műveletek végén finalfile.mp3-fájlban fogja találni", "Leállítja majd a számítógépet?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                autoshutdownbn.Checked = true;

            }
            else if (dialogResult == DialogResult.No)
            {

                autoshutdownbn.Checked = false;

            }
        }

        private void cBaactrue_CheckedChanged(object sender, EventArgs e)
        {
            if (cBaactrue.Checked)
            {
                reducedaudio.Checked = false;
                reducedvideo.Checked = false;
                addcover.Checked = false;

                comboBox1.Text = "aac";


            }
            else
            {
                comboBox1.Text = "mp3";


            }
        }
        private void addcover_CheckedChanged(object sender, EventArgs e)
        {
            if (addcover.Checked)
            {
                comboBox1.Text = "mp3";
                cBaactrue.Checked = false;

            }
        }

        private void makevideofromaudio_Click(object sender, EventArgs e)
        {
            VideoFromAudio f3 = new VideoFromAudio();
            f3.Show();
            this.Hide();
        }





        private void ytdlpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            engineytd.Checked = true;
            StreamWriter writefile = new StreamWriter("config.ini");
            writefile.WriteLine("Language=English");
            writefile.WriteLine("Engine=YT-DLP");




            writefile.Close();
            MessageBox.Show("Restart the app is strongly recommended! / A program újraindítása ajánlott!");

        }

        private void youtubedlToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            engineytd.Checked = false;
            StreamWriter writefile = new StreamWriter("config.ini");
            writefile.WriteLine("Language=English");
            writefile.WriteLine("Engine=Default");




            writefile.Close();
            MessageBox.Show("Restart the app is strongly recommended! / A program újraindítása ajánlott!");
        }

        private void engineytd_CheckedChanged(object sender, EventArgs e)
        {
            if (!engineytd.Checked)
            {
                settingsengine = "Engine=Default";

            }
            else
            {
                settingsengine = "Engine=YT-DLP";
            }
        }



        private void fbookdown_CheckedChanged(object sender, EventArgs e)
        {
            if (fbookdown.Checked == true)
            {
                onlymkvcheck.Checked = true;
            }
            else
            {
                onlymkvcheck.Checked = false;
            }
        }




        private void toYtdlpDownloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("yt-dlp.exe"))
            {
                if (!System.IO.File.Exists("yt-dlp.exe.bak"))
                {
                    System.IO.File.Move("yt-dlp.exe", "yt-dlp.exe.bak");
                }
                System.IO.File.Delete("yt-dlp.exe");

                MessageBox.Show("yt-dlp-ből a legfrisebb verziója letöltésre kerül / The Latest yt-dlp has been started and downloaded ");

                string remoteUri = "https://github.com/yt-dlp/yt-dlp/releases/latest/download/";
                string fileName = "yt-dlp.exe";
                System.Net.WebClient myWebClient = new System.Net.WebClient();
                string myStringWebResource = remoteUri + fileName;

                myWebClient.DownloadFile(myStringWebResource, fileName);

                MessageBox.Show("Letöltés befejeződött! / Download Complete");
                DialogResult dialogResult = MessageBox.Show("Would you like to remove the old version ytd backup?", "Are you sure?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    System.IO.File.Delete("yt-dlp.exe.bak");
                }


            }
        }

        private void toYoutubedlDownloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("youtube-dl.exe"))
            {
                System.IO.File.Delete("youtube-dl.exe");

                MessageBox.Show("A youtube-dl legfrisebb verziója letöltésre kerül 2021 (eléggé elavult) / The latest youtube-dl downloads in progress but it is out of date");

                string remoteUri = "https://youtube-dl.org/downloads/latest/";
                string fileName = "youtube-dl.exe";
                System.Net.WebClient myWebClient = new System.Net.WebClient();
                string myStringWebResource = remoteUri + fileName;

                myWebClient.DownloadFile(myStringWebResource, fileName);

                MessageBox.Show("Letöltés befejeződött!");
            }
        }

        private void névjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.Show();
        }

        private void angolToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en");
        }

        private void magyarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangeLanguage("hu-Hu");
        }
    }
}






