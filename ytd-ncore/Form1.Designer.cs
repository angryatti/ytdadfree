namespace ytd_ncore
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            videourltext = new System.Windows.Forms.TextBox();
            dwndnconv = new System.Windows.Forms.Button();
            videourl = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            convertmanually = new System.Windows.Forms.Button();
            renameandsave = new System.Windows.Forms.Button();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            unnessaryfiles = new System.Windows.Forms.CheckBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            downloadEngineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toYtdlpDownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toYoutubedlDownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            nyelvToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            angolToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            magyarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            nyelvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            angolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            magyarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            youtubedlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ytdlpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            chooseDownloadEngineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            youtubedlToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ytdlpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            requrziveloadandcut = new System.Windows.Forms.Button();
            splittimevalue = new System.Windows.Forms.TextBox();
            splitterinsec = new System.Windows.Forms.Label();
            soundloadandcut = new System.Windows.Forms.Button();
            starttime = new System.Windows.Forms.TextBox();
            endtime = new System.Windows.Forms.TextBox();
            startpoint = new System.Windows.Forms.Label();
            endpoint = new System.Windows.Forms.Label();
            destroydownload = new System.Windows.Forms.Button();
            destroyconvert = new System.Windows.Forms.Button();
            onlymkvcheck = new System.Windows.Forms.CheckBox();
            authorandsongname = new System.Windows.Forms.Button();
            videotitle = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            urlreset = new System.Windows.Forms.Button();
            copyclipboard = new System.Windows.Forms.Button();
            checkvideopic = new System.Windows.Forms.Button();
            hwaccer = new System.Windows.Forms.CheckBox();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            amdgpu = new System.Windows.Forms.Button();
            cuda = new System.Windows.Forms.Button();
            addcover = new System.Windows.Forms.CheckBox();
            reducedvideo = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            reducedaudio = new System.Windows.Forms.CheckBox();
            autoshutdownbn = new System.Windows.Forms.CheckBox();
            cBaactrue = new System.Windows.Forms.CheckBox();
            makevideofromaudio = new System.Windows.Forms.Button();
            engineytd = new System.Windows.Forms.CheckBox();
            fbookdown = new System.Windows.Forms.CheckBox();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            bindingSource1 = new System.Windows.Forms.BindingSource(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // videourltext
            // 
            resources.ApplyResources(videourltext, "videourltext");
            videourltext.Name = "videourltext";
            // 
            // dwndnconv
            // 
            resources.ApplyResources(dwndnconv, "dwndnconv");
            dwndnconv.Name = "dwndnconv";
            dwndnconv.UseVisualStyleBackColor = true;
            dwndnconv.Click += dwndnconv_Click;
            // 
            // videourl
            // 
            resources.ApplyResources(videourl, "videourl");
            videourl.Name = "videourl";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { resources.GetString("comboBox1.Items"), resources.GetString("comboBox1.Items1"), resources.GetString("comboBox1.Items2"), resources.GetString("comboBox1.Items3"), resources.GetString("comboBox1.Items4"), resources.GetString("comboBox1.Items5") });
            resources.ApplyResources(comboBox1, "comboBox1");
            comboBox1.Name = "comboBox1";
            // 
            // convertmanually
            // 
            resources.ApplyResources(convertmanually, "convertmanually");
            convertmanually.Name = "convertmanually";
            convertmanually.UseVisualStyleBackColor = true;
            convertmanually.Click += convertmanually_Click;
            // 
            // renameandsave
            // 
            resources.ApplyResources(renameandsave, "renameandsave");
            renameandsave.Name = "renameandsave";
            renameandsave.UseVisualStyleBackColor = true;
            renameandsave.Click += renameandsave_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileName = "nevezzat.mp3";
            resources.ApplyResources(saveFileDialog1, "saveFileDialog1");
            saveFileDialog1.FilterIndex = 0;
            // 
            // unnessaryfiles
            // 
            resources.ApplyResources(unnessaryfiles, "unnessaryfiles");
            unnessaryfiles.Checked = true;
            unnessaryfiles.CheckState = System.Windows.Forms.CheckState.Checked;
            unnessaryfiles.Name = "unnessaryfiles";
            unnessaryfiles.UseVisualStyleBackColor = true;
       
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem2, downloadEngineToolStripMenuItem, nyelvToolStripMenuItem1, névjegyToolStripMenuItem });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem2
            // 
            fileToolStripMenuItem2.Name = "fileToolStripMenuItem2";
            resources.ApplyResources(fileToolStripMenuItem2, "fileToolStripMenuItem2");
            // 
            // downloadEngineToolStripMenuItem
            // 
            downloadEngineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toYtdlpDownloadToolStripMenuItem, toYoutubedlDownloadToolStripMenuItem });
            downloadEngineToolStripMenuItem.Name = "downloadEngineToolStripMenuItem";
            resources.ApplyResources(downloadEngineToolStripMenuItem, "downloadEngineToolStripMenuItem");
            // 
            // toYtdlpDownloadToolStripMenuItem
            // 
            toYtdlpDownloadToolStripMenuItem.Name = "toYtdlpDownloadToolStripMenuItem";
            resources.ApplyResources(toYtdlpDownloadToolStripMenuItem, "toYtdlpDownloadToolStripMenuItem");
            toYtdlpDownloadToolStripMenuItem.Click += toYtdlpDownloadToolStripMenuItem_Click;
            // 
            // toYoutubedlDownloadToolStripMenuItem
            // 
            toYoutubedlDownloadToolStripMenuItem.Name = "toYoutubedlDownloadToolStripMenuItem";
            resources.ApplyResources(toYoutubedlDownloadToolStripMenuItem, "toYoutubedlDownloadToolStripMenuItem");
            toYoutubedlDownloadToolStripMenuItem.Click += toYoutubedlDownloadToolStripMenuItem_Click;
            // 
            // nyelvToolStripMenuItem1
            // 
            nyelvToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { angolToolStripMenuItem1, magyarToolStripMenuItem1 });
            nyelvToolStripMenuItem1.Name = "nyelvToolStripMenuItem1";
            resources.ApplyResources(nyelvToolStripMenuItem1, "nyelvToolStripMenuItem1");
            // 
            // angolToolStripMenuItem1
            // 
            angolToolStripMenuItem1.Name = "angolToolStripMenuItem1";
            resources.ApplyResources(angolToolStripMenuItem1, "angolToolStripMenuItem1");
            angolToolStripMenuItem1.Click += angolToolStripMenuItem1_Click;
            // 
            // magyarToolStripMenuItem1
            // 
            magyarToolStripMenuItem1.Name = "magyarToolStripMenuItem1";
            resources.ApplyResources(magyarToolStripMenuItem1, "magyarToolStripMenuItem1");
            magyarToolStripMenuItem1.Click += magyarToolStripMenuItem1_Click;
            // 
            // névjegyToolStripMenuItem
            // 
            névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
            resources.ApplyResources(névjegyToolStripMenuItem, "névjegyToolStripMenuItem");
            névjegyToolStripMenuItem.Click += névjegyToolStripMenuItem_Click;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            resources.ApplyResources(quitToolStripMenuItem, "quitToolStripMenuItem");
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // nyelvToolStripMenuItem
            // 
            nyelvToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { angolToolStripMenuItem, magyarToolStripMenuItem });
            resources.ApplyResources(nyelvToolStripMenuItem, "nyelvToolStripMenuItem");
            nyelvToolStripMenuItem.Name = "nyelvToolStripMenuItem";
            // 
            // angolToolStripMenuItem
            // 
            angolToolStripMenuItem.Name = "angolToolStripMenuItem";
            resources.ApplyResources(angolToolStripMenuItem, "angolToolStripMenuItem");
            // 
            // magyarToolStripMenuItem
            // 
            magyarToolStripMenuItem.Name = "magyarToolStripMenuItem";
            resources.ApplyResources(magyarToolStripMenuItem, "magyarToolStripMenuItem");
   
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            resources.ApplyResources(updateToolStripMenuItem, "updateToolStripMenuItem");
            // 
            // youtubedlToolStripMenuItem
            // 
            youtubedlToolStripMenuItem.Name = "youtubedlToolStripMenuItem";
            resources.ApplyResources(youtubedlToolStripMenuItem, "youtubedlToolStripMenuItem");
            // 
            // ytdlpToolStripMenuItem1
            // 
            ytdlpToolStripMenuItem1.Name = "ytdlpToolStripMenuItem1";
            resources.ApplyResources(ytdlpToolStripMenuItem1, "ytdlpToolStripMenuItem1");
            // 
            // chooseDownloadEngineToolStripMenuItem
            // 
            chooseDownloadEngineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { youtubedlToolStripMenuItem1, ytdlpToolStripMenuItem });
            chooseDownloadEngineToolStripMenuItem.Name = "chooseDownloadEngineToolStripMenuItem";
            resources.ApplyResources(chooseDownloadEngineToolStripMenuItem, "chooseDownloadEngineToolStripMenuItem");
            // 
            // youtubedlToolStripMenuItem1
            // 
            youtubedlToolStripMenuItem1.Name = "youtubedlToolStripMenuItem1";
            resources.ApplyResources(youtubedlToolStripMenuItem1, "youtubedlToolStripMenuItem1");
            youtubedlToolStripMenuItem1.Click += youtubedlToolStripMenuItem1_Click;
            // 
            // ytdlpToolStripMenuItem
            // 
            ytdlpToolStripMenuItem.Name = "ytdlpToolStripMenuItem";
            resources.ApplyResources(ytdlpToolStripMenuItem, "ytdlpToolStripMenuItem");
            ytdlpToolStripMenuItem.Click += ytdlpToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // requrziveloadandcut
            // 
            resources.ApplyResources(requrziveloadandcut, "requrziveloadandcut");
            requrziveloadandcut.Name = "requrziveloadandcut";
            requrziveloadandcut.UseVisualStyleBackColor = true;
            requrziveloadandcut.Click += requrziveloadandcut_Click;
            // 
            // splittimevalue
            // 
            resources.ApplyResources(splittimevalue, "splittimevalue");
            splittimevalue.Name = "splittimevalue";
            // 
            // splitterinsec
            // 
            resources.ApplyResources(splitterinsec, "splitterinsec");
            splitterinsec.Name = "splitterinsec";
            // 
            // soundloadandcut
            // 
            resources.ApplyResources(soundloadandcut, "soundloadandcut");
            soundloadandcut.Name = "soundloadandcut";
            soundloadandcut.UseVisualStyleBackColor = true;
            soundloadandcut.Click += soundloadandcut_Click;
            // 
            // starttime
            // 
            resources.ApplyResources(starttime, "starttime");
            starttime.Name = "starttime";
            // 
            // endtime
            // 
            resources.ApplyResources(endtime, "endtime");
            endtime.Name = "endtime";
            // 
            // startpoint
            // 
            resources.ApplyResources(startpoint, "startpoint");
            startpoint.Name = "startpoint";
            // 
            // endpoint
            // 
            resources.ApplyResources(endpoint, "endpoint");
            endpoint.Name = "endpoint";
            // 
            // destroydownload
            // 
            resources.ApplyResources(destroydownload, "destroydownload");
            destroydownload.Name = "destroydownload";
            destroydownload.UseVisualStyleBackColor = true;
            destroydownload.Click += destroydownload_Click;
            // 
            // destroyconvert
            // 
            resources.ApplyResources(destroyconvert, "destroyconvert");
            destroyconvert.Name = "destroyconvert";
            destroyconvert.UseVisualStyleBackColor = true;
            destroyconvert.Click += destroyconvert_Click;
            // 
            // onlymkvcheck
            // 
            resources.ApplyResources(onlymkvcheck, "onlymkvcheck");
            onlymkvcheck.Name = "onlymkvcheck";
            onlymkvcheck.UseVisualStyleBackColor = true;
            // 
            // authorandsongname
            // 
            resources.ApplyResources(authorandsongname, "authorandsongname");
            authorandsongname.Name = "authorandsongname";
            authorandsongname.UseVisualStyleBackColor = true;
            authorandsongname.Click += button8_Click;
            // 
            // videotitle
            // 
            resources.ApplyResources(videotitle, "videotitle");
            videotitle.Name = "videotitle";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // urlreset
            // 
            resources.ApplyResources(urlreset, "urlreset");
            urlreset.Name = "urlreset";
            urlreset.UseVisualStyleBackColor = true;
            urlreset.Click += urlreset_Click;
            // 
            // copyclipboard
            // 
            resources.ApplyResources(copyclipboard, "copyclipboard");
            copyclipboard.Name = "copyclipboard";
            copyclipboard.UseVisualStyleBackColor = true;
            copyclipboard.Click += copyclipboard_Click_1;
            // 
            // checkvideopic
            // 
            resources.ApplyResources(checkvideopic, "checkvideopic");
            checkvideopic.Name = "checkvideopic";
            checkvideopic.UseVisualStyleBackColor = true;
            checkvideopic.Click += checkvideopic_Click;
            // 
            // hwaccer
            // 
            resources.ApplyResources(hwaccer, "hwaccer");
            hwaccer.Name = "hwaccer";
            hwaccer.UseVisualStyleBackColor = true;
            // 
            // amdgpu
            // 
            amdgpu.BackgroundImage = Properties.Resources.amdgpu;
            resources.ApplyResources(amdgpu, "amdgpu");
            amdgpu.Name = "amdgpu";
            toolTip1.SetToolTip(amdgpu, resources.GetString("amdgpu.ToolTip"));
            amdgpu.UseVisualStyleBackColor = true;
            amdgpu.Click += amdgpu_Click;
            // 
            // cuda
            // 
            cuda.BackgroundImage = Properties.Resources.cuda;
            resources.ApplyResources(cuda, "cuda");
            cuda.Name = "cuda";
            toolTip1.SetToolTip(cuda, resources.GetString("cuda.ToolTip"));
            cuda.UseVisualStyleBackColor = true;
            cuda.Click += cuda_Click;
            // 
            // addcover
            // 
            resources.ApplyResources(addcover, "addcover");
            addcover.Name = "addcover";
            addcover.UseVisualStyleBackColor = true;
            addcover.CheckedChanged += addcover_CheckedChanged;
            // 
            // reducedvideo
            // 
            resources.ApplyResources(reducedvideo, "reducedvideo");
            reducedvideo.Name = "reducedvideo";
            reducedvideo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // reducedaudio
            // 
            resources.ApplyResources(reducedaudio, "reducedaudio");
            reducedaudio.Name = "reducedaudio";
            reducedaudio.UseVisualStyleBackColor = true;
            // 
            // autoshutdownbn
            // 
            resources.ApplyResources(autoshutdownbn, "autoshutdownbn");
            autoshutdownbn.Name = "autoshutdownbn";
            autoshutdownbn.UseVisualStyleBackColor = true;
            autoshutdownbn.CheckedChanged += autoshutdownbn_CheckedChanged;
            // 
            // cBaactrue
            // 
            resources.ApplyResources(cBaactrue, "cBaactrue");
            cBaactrue.Name = "cBaactrue";
            cBaactrue.UseVisualStyleBackColor = true;
            cBaactrue.CheckedChanged += cBaactrue_CheckedChanged;
            // 
            // makevideofromaudio
            // 
            resources.ApplyResources(makevideofromaudio, "makevideofromaudio");
            makevideofromaudio.Name = "makevideofromaudio";
            makevideofromaudio.UseVisualStyleBackColor = true;
            makevideofromaudio.Click += makevideofromaudio_Click;
            // 
            // engineytd
            // 
            resources.ApplyResources(engineytd, "engineytd");
            engineytd.Checked = true;
            engineytd.CheckState = System.Windows.Forms.CheckState.Checked;
            engineytd.Name = "engineytd";
            engineytd.UseVisualStyleBackColor = true;
            engineytd.CheckedChanged += engineytd_CheckedChanged;
            // 
            // fbookdown
            // 
            resources.ApplyResources(fbookdown, "fbookdown");
            fbookdown.Name = "fbookdown";
            fbookdown.UseVisualStyleBackColor = true;
            fbookdown.CheckedChanged += fbookdown_CheckedChanged;
            // 
            // progressBar1
            // 
            resources.ApplyResources(progressBar1, "progressBar1");
            progressBar1.Name = "progressBar1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            Controls.Add(fbookdown);
            Controls.Add(engineytd);
            Controls.Add(makevideofromaudio);
            Controls.Add(cBaactrue);
            Controls.Add(autoshutdownbn);
            Controls.Add(reducedaudio);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(reducedvideo);
            Controls.Add(addcover);
            Controls.Add(amdgpu);
            Controls.Add(cuda);
            Controls.Add(hwaccer);
            Controls.Add(checkvideopic);
            Controls.Add(copyclipboard);
            Controls.Add(urlreset);
            Controls.Add(label6);
            Controls.Add(videotitle);
            Controls.Add(authorandsongname);
            Controls.Add(onlymkvcheck);
            Controls.Add(destroyconvert);
            Controls.Add(destroydownload);
            Controls.Add(endpoint);
            Controls.Add(startpoint);
            Controls.Add(endtime);
            Controls.Add(starttime);
            Controls.Add(soundloadandcut);
            Controls.Add(splitterinsec);
            Controls.Add(splittimevalue);
            Controls.Add(requrziveloadandcut);
            Controls.Add(unnessaryfiles);
            Controls.Add(renameandsave);
            Controls.Add(convertmanually);
            Controls.Add(comboBox1);
            Controls.Add(videourl);
            Controls.Add(dwndnconv);
            Controls.Add(videourltext);
            Controls.Add(menuStrip1);
            ForeColor = System.Drawing.SystemColors.Desktop;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox videourltext;
        private System.Windows.Forms.Button dwndnconv;
        private System.Windows.Forms.Label videourl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button convertmanually;
        private System.Windows.Forms.Button renameandsave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox unnessaryfiles;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button requrziveloadandcut;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox splittimevalue;
        private System.Windows.Forms.Label splitterinsec;
        private System.Windows.Forms.Button soundloadandcut;
        private System.Windows.Forms.TextBox starttime;
        private System.Windows.Forms.TextBox endtime;
        private System.Windows.Forms.Label startpoint;
        private System.Windows.Forms.Label endpoint;
        private System.Windows.Forms.Button destroydownload;
        private System.Windows.Forms.Button destroyconvert;
        private System.Windows.Forms.CheckBox onlymkvcheck;
        private System.Windows.Forms.ToolStripMenuItem nyelvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem angolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magyarToolStripMenuItem;
        private System.Windows.Forms.Button authorandsongname;
        private System.Windows.Forms.Label videotitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button urlreset;
        private System.Windows.Forms.Button copyclipboard;
        private System.Windows.Forms.Button checkvideopic;
        private System.Windows.Forms.CheckBox hwaccer;
        private System.Windows.Forms.Button cuda;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button amdgpu;
        private System.Windows.Forms.CheckBox addcover;
        private System.Windows.Forms.CheckBox reducedvideo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youtubedlToolStripMenuItem;
        private System.Windows.Forms.CheckBox reducedaudio;
        private System.Windows.Forms.CheckBox autoshutdownbn;
        private System.Windows.Forms.CheckBox cBaactrue;
        private System.Windows.Forms.Button makevideofromaudio;
        private System.Windows.Forms.ToolStripMenuItem chooseDownloadEngineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youtubedlToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ytdlpToolStripMenuItem;
        private System.Windows.Forms.CheckBox engineytd;
        private System.Windows.Forms.ToolStripMenuItem ytdlpToolStripMenuItem1;
        private System.Windows.Forms.CheckBox fbookdown;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem downloadEngineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toYtdlpDownloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toYoutubedlDownloadToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem névjegyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyelvToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem angolToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem magyarToolStripMenuItem1;
    }
}

