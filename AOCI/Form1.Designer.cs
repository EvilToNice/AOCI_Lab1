namespace AOCI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.DefaultImage = new Emgu.CV.UI.ImageBox();
            this.SelectImageBtn = new System.Windows.Forms.Button();
            this.ReImage = new Emgu.CV.UI.ImageBox();
            this.ProcessBtn = new System.Windows.Forms.Button();
            this.CannyFirst = new System.Windows.Forms.TrackBar();
            this.CannySecond = new System.Windows.Forms.TrackBar();
            this.VideoBTN = new System.Windows.Forms.Button();
            this.TimerVideo = new System.Windows.Forms.Timer(this.components);
            this.txt50 = new System.Windows.Forms.TextBox();
            this.txt100 = new System.Windows.Forms.TextBox();
            this.txt200 = new System.Windows.Forms.TextBox();
            this.txt150 = new System.Windows.Forms.TextBox();
            this.txt255 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannySecond)).BeginInit();
            this.SuspendLayout();
            // 
            // DefaultImage
            // 
            this.DefaultImage.Location = new System.Drawing.Point(12, 12);
            this.DefaultImage.Name = "DefaultImage";
            this.DefaultImage.Size = new System.Drawing.Size(640, 480);
            this.DefaultImage.TabIndex = 2;
            this.DefaultImage.TabStop = false;
            // 
            // SelectImageBtn
            // 
            this.SelectImageBtn.Location = new System.Drawing.Point(663, 12);
            this.SelectImageBtn.Name = "SelectImageBtn";
            this.SelectImageBtn.Size = new System.Drawing.Size(75, 23);
            this.SelectImageBtn.TabIndex = 3;
            this.SelectImageBtn.Text = "Open Image";
            this.SelectImageBtn.UseVisualStyleBackColor = true;
            this.SelectImageBtn.Click += new System.EventHandler(this.SelectImageBtn_Click);
            // 
            // ReImage
            // 
            this.ReImage.Location = new System.Drawing.Point(834, 12);
            this.ReImage.Name = "ReImage";
            this.ReImage.Size = new System.Drawing.Size(640, 480);
            this.ReImage.TabIndex = 4;
            this.ReImage.TabStop = false;
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.Location = new System.Drawing.Point(663, 51);
            this.ProcessBtn.Name = "ProcessBtn";
            this.ProcessBtn.Size = new System.Drawing.Size(75, 23);
            this.ProcessBtn.TabIndex = 5;
            this.ProcessBtn.Text = "Process";
            this.ProcessBtn.UseVisualStyleBackColor = true;
            this.ProcessBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // CannyFirst
            // 
            this.CannyFirst.LargeChange = 1;
            this.CannyFirst.Location = new System.Drawing.Point(658, 214);
            this.CannyFirst.Maximum = 256;
            this.CannyFirst.Name = "CannyFirst";
            this.CannyFirst.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.CannyFirst.Size = new System.Drawing.Size(45, 256);
            this.CannyFirst.TabIndex = 6;
            // 
            // CannySecond
            // 
            this.CannySecond.LargeChange = 1;
            this.CannySecond.Location = new System.Drawing.Point(693, 214);
            this.CannySecond.Maximum = 256;
            this.CannySecond.Name = "CannySecond";
            this.CannySecond.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.CannySecond.Size = new System.Drawing.Size(45, 256);
            this.CannySecond.SmallChange = 5;
            this.CannySecond.TabIndex = 7;
            this.CannySecond.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // VideoBTN
            // 
            this.VideoBTN.Location = new System.Drawing.Point(663, 100);
            this.VideoBTN.Name = "VideoBTN";
            this.VideoBTN.Size = new System.Drawing.Size(75, 23);
            this.VideoBTN.TabIndex = 5;
            this.VideoBTN.Text = "Video";
            this.VideoBTN.UseVisualStyleBackColor = true;
            this.VideoBTN.Click += new System.EventHandler(this.VideoBTN_Click);
            // 
            // TimerVideo
            // 
            this.TimerVideo.Interval = 33;
            this.TimerVideo.Tick += new System.EventHandler(this.TimerVideo_Tick);
            // 
            // txt50
            // 
            this.txt50.AccessibleDescription = "255";
            this.txt50.Location = new System.Drawing.Point(755, 15);
            this.txt50.MaxLength = 3;
            this.txt50.Name = "txt50";
            this.txt50.Size = new System.Drawing.Size(63, 20);
            this.txt50.TabIndex = 8;
            // 
            // txt100
            // 
            this.txt100.AccessibleDescription = "255";
            this.txt100.Location = new System.Drawing.Point(755, 53);
            this.txt100.MaxLength = 3;
            this.txt100.Name = "txt100";
            this.txt100.Size = new System.Drawing.Size(63, 20);
            this.txt100.TabIndex = 9;
            // 
            // txt200
            // 
            this.txt200.AccessibleDescription = "255";
            this.txt200.Location = new System.Drawing.Point(755, 140);
            this.txt200.MaxLength = 3;
            this.txt200.Name = "txt200";
            this.txt200.Size = new System.Drawing.Size(63, 20);
            this.txt200.TabIndex = 11;
            // 
            // txt150
            // 
            this.txt150.AccessibleDescription = "255";
            this.txt150.Location = new System.Drawing.Point(755, 102);
            this.txt150.MaxLength = 3;
            this.txt150.Name = "txt150";
            this.txt150.Size = new System.Drawing.Size(63, 20);
            this.txt150.TabIndex = 10;
            // 
            // txt255
            // 
            this.txt255.AccessibleDescription = "255";
            this.txt255.Location = new System.Drawing.Point(755, 175);
            this.txt255.MaxLength = 3;
            this.txt255.Name = "txt255";
            this.txt255.Size = new System.Drawing.Size(63, 20);
            this.txt255.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(655, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "cannyThreshold";
            this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.label1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(690, 549);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "cannyThresholdLinking";
            this.label2.Paint += new System.Windows.Forms.PaintEventHandler(this.label2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 609);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt255);
            this.Controls.Add(this.txt200);
            this.Controls.Add(this.txt150);
            this.Controls.Add(this.txt100);
            this.Controls.Add(this.txt50);
            this.Controls.Add(this.CannySecond);
            this.Controls.Add(this.CannyFirst);
            this.Controls.Add(this.VideoBTN);
            this.Controls.Add(this.ProcessBtn);
            this.Controls.Add(this.ReImage);
            this.Controls.Add(this.SelectImageBtn);
            this.Controls.Add(this.DefaultImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DefaultImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannySecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Emgu.CV.UI.ImageBox DefaultImage;
        private System.Windows.Forms.Button SelectImageBtn;
        private Emgu.CV.UI.ImageBox ReImage;
        private System.Windows.Forms.Button ProcessBtn;
        private System.Windows.Forms.TrackBar CannyFirst;
        private System.Windows.Forms.TrackBar CannySecond;
        private System.Windows.Forms.Button VideoBTN;
        private System.Windows.Forms.Timer TimerVideo;
        private System.Windows.Forms.TextBox txt50;
        private System.Windows.Forms.TextBox txt100;
        private System.Windows.Forms.TextBox txt200;
        private System.Windows.Forms.TextBox txt150;
        private System.Windows.Forms.TextBox txt255;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

