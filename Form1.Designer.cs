namespace QueueSimulation
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
            this.picMain = new System.Windows.Forms.PictureBox();
            this.Customer1 = new System.Windows.Forms.PictureBox();
            this.Customer2 = new System.Windows.Forms.PictureBox();
            this.Customer3 = new System.Windows.Forms.PictureBox();
            this.Customer4 = new System.Windows.Forms.PictureBox();
            this.Customer5 = new System.Windows.Forms.PictureBox();
            this.QueueGate = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lstQueue = new System.Windows.Forms.ListBox();
            this.lstProcessed = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblProcessing = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customer5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueueGate)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.BackColor = System.Drawing.Color.SteelBlue;
            this.picMain.Location = new System.Drawing.Point(350, 119);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(75, 10);
            this.picMain.TabIndex = 0;
            this.picMain.TabStop = false;
            // 
            // Customer1
            // 
            this.Customer1.BackColor = System.Drawing.Color.Red;
            this.Customer1.Location = new System.Drawing.Point(16, 90);
            this.Customer1.Name = "Customer1";
            this.Customer1.Size = new System.Drawing.Size(25, 25);
            this.Customer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Customer1.TabIndex = 1;
            this.Customer1.TabStop = false;
            // 
            // Customer2
            // 
            this.Customer2.BackColor = System.Drawing.Color.DarkOrange;
            this.Customer2.Location = new System.Drawing.Point(16, 90);
            this.Customer2.Name = "Customer2";
            this.Customer2.Size = new System.Drawing.Size(25, 25);
            this.Customer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Customer2.TabIndex = 2;
            this.Customer2.TabStop = false;
            // 
            // Customer3
            // 
            this.Customer3.BackColor = System.Drawing.Color.Chartreuse;
            this.Customer3.Location = new System.Drawing.Point(16, 90);
            this.Customer3.Name = "Customer3";
            this.Customer3.Size = new System.Drawing.Size(25, 25);
            this.Customer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Customer3.TabIndex = 3;
            this.Customer3.TabStop = false;
            // 
            // Customer4
            // 
            this.Customer4.BackColor = System.Drawing.Color.Turquoise;
            this.Customer4.Location = new System.Drawing.Point(16, 90);
            this.Customer4.Name = "Customer4";
            this.Customer4.Size = new System.Drawing.Size(25, 25);
            this.Customer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Customer4.TabIndex = 4;
            this.Customer4.TabStop = false;
            // 
            // Customer5
            // 
            this.Customer5.BackColor = System.Drawing.Color.MidnightBlue;
            this.Customer5.Location = new System.Drawing.Point(16, 90);
            this.Customer5.Name = "Customer5";
            this.Customer5.Size = new System.Drawing.Size(25, 25);
            this.Customer5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Customer5.TabIndex = 5;
            this.Customer5.TabStop = false;
            // 
            // QueueGate
            // 
            this.QueueGate.BackColor = System.Drawing.Color.SteelBlue;
            this.QueueGate.Location = new System.Drawing.Point(224, 78);
            this.QueueGate.Name = "QueueGate";
            this.QueueGate.Size = new System.Drawing.Size(10, 50);
            this.QueueGate.TabIndex = 6;
            this.QueueGate.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lstQueue
            // 
            this.lstQueue.BackColor = System.Drawing.Color.White;
            this.lstQueue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstQueue.ForeColor = System.Drawing.Color.Black;
            this.lstQueue.FormattingEnabled = true;
            this.lstQueue.ItemHeight = 20;
            this.lstQueue.Location = new System.Drawing.Point(12, 39);
            this.lstQueue.Name = "lstQueue";
            this.lstQueue.Size = new System.Drawing.Size(200, 60);
            this.lstQueue.TabIndex = 7;
            // 
            // lstProcessed
            // 
            this.lstProcessed.BackColor = System.Drawing.Color.White;
            this.lstProcessed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstProcessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProcessed.ForeColor = System.Drawing.Color.Black;
            this.lstProcessed.FormattingEnabled = true;
            this.lstProcessed.ItemHeight = 20;
            this.lstProcessed.Location = new System.Drawing.Point(237, 39);
            this.lstProcessed.Name = "lstProcessed";
            this.lstProcessed.Size = new System.Drawing.Size(200, 60);
            this.lstProcessed.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "IN QUEUE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "PROCESSING:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(233, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "PROCESSED:";
            // 
            // timer2
            // 
            this.timer2.Interval = 700;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(13, 227);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 16);
            this.lblTime.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(183, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Queue Gate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(346, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Check out";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 137);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(442, 27);
            this.progressBar1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(482, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 332);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Program Flow";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(350, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 10);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Location = new System.Drawing.Point(405, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 50);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 292);
            this.label7.TabIndex = 1;
            this.label7.Text = "label7";
            // 
            // lblProcessing
            // 
            this.lblProcessing.AutoSize = true;
            this.lblProcessing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessing.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblProcessing.Location = new System.Drawing.Point(127, 115);
            this.lblProcessing.Name = "lblProcessing";
            this.lblProcessing.Size = new System.Drawing.Size(0, 21);
            this.lblProcessing.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(89, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 37);
            this.label6.TabIndex = 18;
            this.label6.Text = "QUEUE SIMULATION";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblProcessing);
            this.groupBox2.Controls.Add(this.lstQueue);
            this.groupBox2.Controls.Add(this.lstProcessed);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(16, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 175);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(719, 351);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.QueueGate);
            this.Controls.Add(this.Customer5);
            this.Controls.Add(this.Customer4);
            this.Controls.Add(this.Customer3);
            this.Controls.Add(this.Customer2);
            this.Controls.Add(this.Customer1);
            this.Controls.Add(this.picMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queue Simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customer5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueueGate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.PictureBox Customer1;
        private System.Windows.Forms.PictureBox Customer2;
        private System.Windows.Forms.PictureBox Customer3;
        private System.Windows.Forms.PictureBox Customer4;
        private System.Windows.Forms.PictureBox Customer5;
        private System.Windows.Forms.PictureBox QueueGate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lstQueue;
        private System.Windows.Forms.ListBox lstProcessed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblProcessing;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

