namespace MyFirstWindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guziol_right = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            trackBar1 = new TrackBar();
            updateTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // Guziol_right
            // 
            Guziol_right.BackColor = Color.FromArgb(192, 192, 0);
            Guziol_right.BackgroundImageLayout = ImageLayout.None;
            Guziol_right.Location = new Point(676, 35);
            Guziol_right.Name = "Guziol_right";
            Guziol_right.Size = new Size(149, 29);
            Guziol_right.TabIndex = 0;
            Guziol_right.Text = "->";
            Guziol_right.UseVisualStyleBackColor = false;
            Guziol_right.Click += Guziol_right_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Lime;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.MaximumSize = new Size(1920, 1080);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(676, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.Paint += Picture_box_Paint;
            pictureBox1.MouseClick += myForm_MouseClick;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(676, 0);
            button1.Name = "button1";
            button1.Size = new Size(149, 29);
            button1.TabIndex = 2;
            button1.Text = "<-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(701, 355);
            trackBar1.Maximum = 1000;
            trackBar1.Minimum = -1000;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(112, 56);
            trackBar1.TabIndex = 4;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // updateTimer
            // 
            updateTimer.Enabled = true;
            updateTimer.Interval = 20;
            updateTimer.Tick += updateTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 450);
            Controls.Add(trackBar1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(Guziol_right);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            MouseClick += myForm_MouseClick;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Guziol_right;
        private PictureBox pictureBox1;
        private Button button1;
        private TrackBar trackBar1;
        private System.Windows.Forms.Timer updateTimer;
    }
}