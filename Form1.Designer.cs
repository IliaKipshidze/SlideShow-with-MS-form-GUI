
namespace slideShow
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.directory = new System.Windows.Forms.TextBox();
            this.startSlideshow = new System.Windows.Forms.Button();
            this.pauseResume = new System.Windows.Forms.Button();
            this.showSpeed = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.browse = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.tpp = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.webdir = new System.Windows.Forms.TextBox();
            this.radiolocal = new System.Windows.Forms.RadioButton();
            this.radioweb = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1171, 516);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // directory
            // 
            this.directory.Enabled = false;
            this.directory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.directory.Location = new System.Drawing.Point(36, 38);
            this.directory.Multiline = true;
            this.directory.Name = "directory";
            this.directory.Size = new System.Drawing.Size(332, 27);
            this.directory.TabIndex = 1;
            // 
            // startSlideshow
            // 
            this.startSlideshow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.startSlideshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startSlideshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.startSlideshow.ForeColor = System.Drawing.Color.White;
            this.startSlideshow.Location = new System.Drawing.Point(854, 12);
            this.startSlideshow.Name = "startSlideshow";
            this.startSlideshow.Size = new System.Drawing.Size(284, 52);
            this.startSlideshow.TabIndex = 6;
            this.startSlideshow.Text = "სლაიდშოუს დაწყება";
            this.startSlideshow.UseVisualStyleBackColor = false;
            this.startSlideshow.Click += new System.EventHandler(this.startSlideshow_Click);
            // 
            // pauseResume
            // 
            this.pauseResume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pauseResume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pauseResume.Enabled = false;
            this.pauseResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.pauseResume.ForeColor = System.Drawing.Color.White;
            this.pauseResume.Location = new System.Drawing.Point(503, 600);
            this.pauseResume.Name = "pauseResume";
            this.pauseResume.Size = new System.Drawing.Size(184, 59);
            this.pauseResume.TabIndex = 9;
            this.pauseResume.Text = "დაპაუზება";
            this.pauseResume.UseVisualStyleBackColor = false;
            this.pauseResume.Click += new System.EventHandler(this.pauseResume_Click);
            // 
            // showSpeed
            // 
            this.showSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.showSpeed.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.showSpeed.Location = new System.Drawing.Point(1058, 614);
            this.showSpeed.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.showSpeed.Name = "showSpeed";
            this.showSpeed.Size = new System.Drawing.Size(68, 32);
            this.showSpeed.TabIndex = 10;
            this.showSpeed.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.showSpeed.ValueChanged += new System.EventHandler(this.showSpeed_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(933, 617);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "დაყოვნება:";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // browse
            // 
            this.browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.browse.Location = new System.Drawing.Point(374, 41);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(90, 24);
            this.browse.TabIndex = 12;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Enabled = false;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(36, 607);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(49, 45);
            this.back.TabIndex = 13;
            this.back.Text = "<";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // forward
            // 
            this.forward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.forward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forward.Enabled = false;
            this.forward.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.forward.ForeColor = System.Drawing.Color.White;
            this.forward.Location = new System.Drawing.Point(91, 607);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(49, 45);
            this.forward.TabIndex = 14;
            this.forward.Text = ">";
            this.forward.UseVisualStyleBackColor = false;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // tpp
            // 
            this.tpp.AutoSize = true;
            this.tpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tpp.Location = new System.Drawing.Point(173, 619);
            this.tpp.Name = "tpp";
            this.tpp.Size = new System.Drawing.Size(0, 20);
            this.tpp.TabIndex = 15;
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 170;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // webdir
            // 
            this.webdir.Enabled = false;
            this.webdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.webdir.Location = new System.Drawing.Point(489, 38);
            this.webdir.Multiline = true;
            this.webdir.Name = "webdir";
            this.webdir.Size = new System.Drawing.Size(332, 27);
            this.webdir.TabIndex = 16;
            // 
            // radiolocal
            // 
            this.radiolocal.AutoSize = true;
            this.radiolocal.Checked = true;
            this.radiolocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiolocal.Location = new System.Drawing.Point(36, 12);
            this.radiolocal.Name = "radiolocal";
            this.radiolocal.Size = new System.Drawing.Size(282, 20);
            this.radiolocal.TabIndex = 18;
            this.radiolocal.TabStop = true;
            this.radiolocal.Text = "ლოკალური დირექტორიიდან წამოღება";
            this.radiolocal.UseVisualStyleBackColor = true;
            this.radiolocal.CheckedChanged += new System.EventHandler(this.radiolocal_CheckedChanged);
            // 
            // radioweb
            // 
            this.radioweb.AutoSize = true;
            this.radioweb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioweb.Location = new System.Drawing.Point(489, 12);
            this.radioweb.Name = "radioweb";
            this.radioweb.Size = new System.Drawing.Size(193, 20);
            this.radioweb.TabIndex = 19;
            this.radioweb.Text = "ვებ გვერდიდან წამოღება";
            this.radioweb.UseVisualStyleBackColor = true;
            this.radioweb.CheckedChanged += new System.EventHandler(this.radioweb_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 662);
            this.Controls.Add(this.radioweb);
            this.Controls.Add(this.radiolocal);
            this.Controls.Add(this.webdir);
            this.Controls.Add(this.tpp);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.back);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.showSpeed);
            this.Controls.Add(this.pauseResume);
            this.Controls.Add(this.startSlideshow);
            this.Controls.Add(this.directory);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Slide-Show Program";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox directory;
        private System.Windows.Forms.Button startSlideshow;
        private System.Windows.Forms.Button pauseResume;
        private System.Windows.Forms.NumericUpDown showSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Label tpp;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TextBox webdir;
        private System.Windows.Forms.RadioButton radiolocal;
        private System.Windows.Forms.RadioButton radioweb;
    }
}

