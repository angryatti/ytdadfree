
namespace ytd_ncore
{
    partial class Form2
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
            this.previewbox = new System.Windows.Forms.PictureBox();
            this.previewok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previewbox)).BeginInit();
            this.SuspendLayout();
            // 
            // previewbox
            // 
            this.previewbox.Location = new System.Drawing.Point(12, 12);
            this.previewbox.Name = "previewbox";
            this.previewbox.Size = new System.Drawing.Size(1024, 768);
            this.previewbox.TabIndex = 0;
            this.previewbox.TabStop = false;
            // 
            // previewok
            // 
            this.previewok.Location = new System.Drawing.Point(448, 786);
            this.previewok.Name = "previewok";
            this.previewok.Size = new System.Drawing.Size(75, 23);
            this.previewok.TabIndex = 1;
            this.previewok.Text = "OK";
            this.previewok.UseVisualStyleBackColor = true;
            this.previewok.Click += new System.EventHandler(this.previewok_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 818);
            this.Controls.Add(this.previewok);
            this.Controls.Add(this.previewbox);
            this.Name = "Form2";
            this.Text = "Előnézet - thumbnail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previewbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox previewbox;
        private System.Windows.Forms.Button previewok;
    }
}