namespace AccordResearch
{
    partial class mnForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mnForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsLabel = new System.Windows.Forms.ToolStripLabel();
            this.lstDev = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.displayImage = new System.Windows.Forms.PictureBox();
            this.btnDevRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnPlayPause = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.btnRotateX = new System.Windows.Forms.ToolStripButton();
            this.btnRotateY = new System.Windows.Forms.ToolStripButton();
            this.btnGrayscale = new System.Windows.Forms.ToolStripButton();
            this.btnFace = new System.Windows.Forms.ToolStripButton();
            this.btnScrShot = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayImage)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLabel,
            this.lstDev,
            this.btnDevRefresh,
            this.toolStripSeparator1,
            this.btnPlayPause,
            this.btnStop,
            this.toolStripSeparator2,
            this.btnRotateX,
            this.btnRotateY,
            this.btnGrayscale,
            this.btnFace,
            this.btnScrShot,
            this.toolStripSeparator3,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(598, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsLabel
            // 
            this.tsLabel.Name = "tsLabel";
            this.tsLabel.Size = new System.Drawing.Size(109, 22);
            this.tsLabel.Text = "Video Input Device:";
            // 
            // lstDev
            // 
            this.lstDev.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.lstDev.Name = "lstDev";
            this.lstDev.Size = new System.Drawing.Size(121, 25);
            this.lstDev.SelectedIndexChanged += new System.EventHandler(this.lstDev_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // displayImage
            // 
            this.displayImage.BackgroundImage = global::AccordResearch.Properties.Resources.camera;
            this.displayImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.displayImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayImage.Location = new System.Drawing.Point(0, 25);
            this.displayImage.Name = "displayImage";
            this.displayImage.Size = new System.Drawing.Size(598, 371);
            this.displayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.displayImage.TabIndex = 1;
            this.displayImage.TabStop = false;
            // 
            // btnDevRefresh
            // 
            this.btnDevRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDevRefresh.Image = global::AccordResearch.Properties.Resources.refresh;
            this.btnDevRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDevRefresh.Name = "btnDevRefresh";
            this.btnDevRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnDevRefresh.Text = "Refresh device list";
            this.btnDevRefresh.Click += new System.EventHandler(this.btnDevRefresh_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPlayPause.Image = global::AccordResearch.Properties.Resources.play;
            this.btnPlayPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(23, 22);
            this.btnPlayPause.Text = "toolStripButton1";
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStop.Image = global::AccordResearch.Properties.Resources.stop;
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(23, 22);
            this.btnStop.Text = "toolStripButton2";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRotateX
            // 
            this.btnRotateX.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRotateX.Image = global::AccordResearch.Properties.Resources.rotatex;
            this.btnRotateX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRotateX.Name = "btnRotateX";
            this.btnRotateX.Size = new System.Drawing.Size(23, 22);
            this.btnRotateX.Text = "toolStripButton3";
            this.btnRotateX.Click += new System.EventHandler(this.btnRotateX_Click);
            // 
            // btnRotateY
            // 
            this.btnRotateY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRotateY.Image = global::AccordResearch.Properties.Resources.rotatey;
            this.btnRotateY.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRotateY.Name = "btnRotateY";
            this.btnRotateY.Size = new System.Drawing.Size(23, 22);
            this.btnRotateY.Text = "toolStripButton4";
            this.btnRotateY.Click += new System.EventHandler(this.btnRotateY_Click);
            // 
            // btnGrayscale
            // 
            this.btnGrayscale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGrayscale.Image = global::AccordResearch.Properties.Resources.grayscale;
            this.btnGrayscale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGrayscale.Name = "btnGrayscale";
            this.btnGrayscale.Size = new System.Drawing.Size(23, 22);
            this.btnGrayscale.Text = "toolStripButton5";
            this.btnGrayscale.Click += new System.EventHandler(this.btnGrayscale_Click);
            // 
            // btnFace
            // 
            this.btnFace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFace.Image = global::AccordResearch.Properties.Resources.facedetect;
            this.btnFace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFace.Name = "btnFace";
            this.btnFace.Size = new System.Drawing.Size(23, 22);
            this.btnFace.Text = "toolStripButton6";
            this.btnFace.Click += new System.EventHandler(this.btnFace_Click);
            // 
            // btnScrShot
            // 
            this.btnScrShot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnScrShot.Image = global::AccordResearch.Properties.Resources.screenshot;
            this.btnScrShot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnScrShot.Name = "btnScrShot";
            this.btnScrShot.Size = new System.Drawing.Size(23, 22);
            this.btnScrShot.Text = "toolStripButton7";
            this.btnScrShot.Click += new System.EventHandler(this.btnScrShot_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = global::AccordResearch.Properties.Resources.exit;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 22);
            this.btnExit.Text = "toolStripButton8";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 396);
            this.Controls.Add(this.displayImage);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mnForm";
            this.Text = "AccordResearch [Just for fun]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mnForm_FormClosing);
            this.Load += new System.EventHandler(this.mnForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsLabel;
        private System.Windows.Forms.ToolStripComboBox lstDev;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPlayPause;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnRotateX;
        private System.Windows.Forms.ToolStripButton btnRotateY;
        private System.Windows.Forms.ToolStripButton btnGrayscale;
        private System.Windows.Forms.ToolStripButton btnFace;
        private System.Windows.Forms.ToolStripButton btnScrShot;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.PictureBox displayImage;
        private System.Windows.Forms.ToolStripButton btnDevRefresh;
    }
}

