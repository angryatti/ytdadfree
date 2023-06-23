
namespace ytd_ncore
{
    partial class VideoFromAudio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoFromAudio));
            openpic = new System.Windows.Forms.Button();
            unloadedpic = new System.Windows.Forms.Label();
            opentheaudio = new System.Windows.Forms.Button();
            unloadedaudio = new System.Windows.Forms.Label();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            makemp4 = new System.Windows.Forms.Button();
            formatfilter = new System.Windows.Forms.ComboBox();
            goback = new System.Windows.Forms.Button();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            previewofload = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)previewofload).BeginInit();
            SuspendLayout();
            // 
            // openpic
            // 
            resources.ApplyResources(openpic, "openpic");
            openpic.Name = "openpic";
            openpic.UseVisualStyleBackColor = true;
            openpic.Click += openpic_Click;
            // 
            // unloadedpic
            // 
            resources.ApplyResources(unloadedpic, "unloadedpic");
            unloadedpic.ForeColor = System.Drawing.Color.Red;
            unloadedpic.Name = "unloadedpic";
            // 
            // opentheaudio
            // 
            resources.ApplyResources(opentheaudio, "opentheaudio");
            opentheaudio.Name = "opentheaudio";
            opentheaudio.UseVisualStyleBackColor = true;
            opentheaudio.Click += opentheaudio_Click;
            // 
            // unloadedaudio
            // 
            resources.ApplyResources(unloadedaudio, "unloadedaudio");
            unloadedaudio.ForeColor = System.Drawing.Color.Red;
            unloadedaudio.Name = "unloadedaudio";
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "jpg";
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.DefaultExt = "mp3|aac";
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // makemp4
            // 
            resources.ApplyResources(makemp4, "makemp4");
            makemp4.Name = "makemp4";
            makemp4.UseVisualStyleBackColor = true;
            makemp4.Click += makemp4_Click;
            // 
            // formatfilter
            // 
            formatfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            formatfilter.FormattingEnabled = true;
            formatfilter.Items.AddRange(new object[] { resources.GetString("formatfilter.Items"), resources.GetString("formatfilter.Items1") });
            resources.ApplyResources(formatfilter, "formatfilter");
            formatfilter.Name = "formatfilter";
            // 
            // goback
            // 
            resources.ApplyResources(goback, "goback");
            goback.Name = "goback";
            goback.UseVisualStyleBackColor = true;
            goback.Click += goback_Click;
            // 
            // previewofload
            // 
            resources.ApplyResources(previewofload, "previewofload");
            previewofload.Name = "previewofload";
            previewofload.TabStop = false;
            // 
            // VideoFromAudio
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(goback);
            Controls.Add(formatfilter);
            Controls.Add(makemp4);
            Controls.Add(previewofload);
            Controls.Add(unloadedaudio);
            Controls.Add(opentheaudio);
            Controls.Add(unloadedpic);
            Controls.Add(openpic);
            Name = "VideoFromAudio";
            FormClosing += VideoFromAudio_FormClosing;
            Load += VideoFromAudio_Load;
            ((System.ComponentModel.ISupportInitialize)previewofload).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button openpic;
        private System.Windows.Forms.Label unloadedpic;
        private System.Windows.Forms.Button opentheaudio;
        private System.Windows.Forms.Label unloadedaudio;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.PictureBox previewofload;
        private System.Windows.Forms.Button makemp4;
        private System.Windows.Forms.ComboBox formatfilter;
        private System.Windows.Forms.Button goback;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}