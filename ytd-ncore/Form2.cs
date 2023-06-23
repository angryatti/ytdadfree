using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ytd_ncore
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void previewok_Click(object sender, EventArgs e)
        {
           
            
            //this.Hide();
            Form1 f1 = new Form1();
         
            f1.Show();
          
            previewbox.Image = null;
            previewbox.Invalidate();
            previewbox.Dispose();
            this.Dispose();
            //   Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        //  previewbox.Image =Image.FromFile("downloadedshot.jpg");
         //   Bitmap bitmap = new Bitmap("0");

            if (previewbox.Image != null) previewbox.Image.Dispose();
         //   bitmap.Save("downloadedshot.jpg");
           // bitmap.Dispose();
            using (Bitmap bm = new Bitmap("downloadedshot.jpg"))
            {
                previewbox.Image = new Bitmap(bm);
        }

        previewbox.Size = new System.Drawing.Size(1024, 768);
            previewbox.SizeMode = PictureBoxSizeMode.CenterImage;
            previewbox.Invalidate();
         
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();

            f1.Show();
     
            previewbox.Image = null;
            previewbox.Invalidate();
            // Close();
            previewbox.Dispose();
            this.Dispose();
        }
    }
}
