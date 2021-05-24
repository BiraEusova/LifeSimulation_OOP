namespace lifeSimulation
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bPause = new System.Windows.Forms.Button();
            this.NameOfCreature = new System.Windows.Forms.Label();
            this.Kind = new System.Windows.Forms.Label();
            this.Poisoning = new System.Windows.Forms.Label();
            this.Health = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudResolution = new System.Windows.Forms.NumericUpDown();
            this.Coordinates = new System.Windows.Forms.Label();
            this.bStart = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.nudDensity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bPause);
            this.splitContainer1.Panel1.Controls.Add(this.NameOfCreature);
            this.splitContainer1.Panel1.Controls.Add(this.Kind);
            this.splitContainer1.Panel1.Controls.Add(this.Poisoning);
            this.splitContainer1.Panel1.Controls.Add(this.Health);
            this.splitContainer1.Panel1.Controls.Add(this.Gender);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.nudResolution);
            this.splitContainer1.Panel1.Controls.Add(this.Coordinates);
            this.splitContainer1.Panel1.Controls.Add(this.bStart);
            this.splitContainer1.Panel1.Controls.Add(this.bStop);
            this.splitContainer1.Panel1.Controls.Add(this.nudDensity);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(911, 565);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // bPause
            // 
            this.bPause.Location = new System.Drawing.Point(23, 220);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(132, 52);
            this.bPause.TabIndex = 15;
            this.bPause.Text = "Pause";
            this.bPause.UseVisualStyleBackColor = true;
            this.bPause.Click += new System.EventHandler(this.bPause_Click);
            // 
            // NameOfCreature
            // 
            this.NameOfCreature.AutoSize = true;
            this.NameOfCreature.Location = new System.Drawing.Point(19, 382);
            this.NameOfCreature.Name = "NameOfCreature";
            this.NameOfCreature.Size = new System.Drawing.Size(51, 20);
            this.NameOfCreature.TabIndex = 14;
            this.NameOfCreature.Text = "Name";
            this.NameOfCreature.Click += new System.EventHandler(this.label5_Click);
            // 
            // Kind
            // 
            this.Kind.AutoSize = true;
            this.Kind.Location = new System.Drawing.Point(19, 353);
            this.Kind.Name = "Kind";
            this.Kind.Size = new System.Drawing.Size(40, 20);
            this.Kind.TabIndex = 13;
            this.Kind.Text = "Kind";
            // 
            // Poisoning
            // 
            this.Poisoning.AutoSize = true;
            this.Poisoning.Location = new System.Drawing.Point(19, 495);
            this.Poisoning.Name = "Poisoning";
            this.Poisoning.Size = new System.Drawing.Size(78, 20);
            this.Poisoning.TabIndex = 11;
            this.Poisoning.Text = "Poisoning";
            // 
            // Health
            // 
            this.Health.AutoSize = true;
            this.Health.Location = new System.Drawing.Point(19, 437);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(56, 20);
            this.Health.TabIndex = 10;
            this.Health.Text = "Health";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(19, 408);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(63, 20);
            this.Gender.TabIndex = 9;
            this.Gender.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resolution";
            // 
            // nudResolution
            // 
            this.nudResolution.Location = new System.Drawing.Point(23, 96);
            this.nudResolution.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudResolution.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudResolution.Name = "nudResolution";
            this.nudResolution.Size = new System.Drawing.Size(132, 26);
            this.nudResolution.TabIndex = 7;
            this.nudResolution.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudResolution.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Coordinates
            // 
            this.Coordinates.AutoSize = true;
            this.Coordinates.Location = new System.Drawing.Point(19, 466);
            this.Coordinates.Name = "Coordinates";
            this.Coordinates.Size = new System.Drawing.Size(95, 20);
            this.Coordinates.TabIndex = 6;
            this.Coordinates.Text = "Coordinates";
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(23, 162);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(132, 52);
            this.bStart.TabIndex = 5;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(23, 278);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(132, 52);
            this.bStop.TabIndex = 4;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // nudDensity
            // 
            this.nudDensity.Location = new System.Drawing.Point(23, 34);
            this.nudDensity.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudDensity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDensity.Name = "nudDensity";
            this.nudDensity.Size = new System.Drawing.Size(132, 26);
            this.nudDensity.TabIndex = 3;
            this.nudDensity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDensity.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Density";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(8000, 8000);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 80;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(911, 565);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nudDensity;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Coordinates;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudResolution;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label Health;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Poisoning;
        private System.Windows.Forms.Label NameOfCreature;
        private System.Windows.Forms.Label Kind;
        private System.Windows.Forms.Button bPause;
    }
}

