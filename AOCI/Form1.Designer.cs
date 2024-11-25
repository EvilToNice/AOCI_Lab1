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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.DefaultImage = new Emgu.CV.UI.ImageBox();
            this.SelectImageBtn = new System.Windows.Forms.Button();
            this.ReImage = new Emgu.CV.UI.ImageBox();
            this.ProcessBtn = new System.Windows.Forms.Button();
            this.CannyFirst = new System.Windows.Forms.TrackBar();
            this.CannySecond = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannySecond)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
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
            this.ReImage.Location = new System.Drawing.Point(744, 12);
            this.ReImage.Name = "ReImage";
            this.ReImage.Size = new System.Drawing.Size(640, 480);
            this.ReImage.TabIndex = 4;
            this.ReImage.TabStop = false;
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.Location = new System.Drawing.Point(665, 246);
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
            this.CannyFirst.Location = new System.Drawing.Point(663, 114);
            this.CannyFirst.Maximum = 256;
            this.CannyFirst.Name = "CannyFirst";
            this.CannyFirst.Size = new System.Drawing.Size(75, 45);
            this.CannyFirst.TabIndex = 6;
            // 
            // CannySecond
            // 
            this.CannySecond.LargeChange = 1;
            this.CannySecond.Location = new System.Drawing.Point(663, 177);
            this.CannySecond.Maximum = 256;
            this.CannySecond.Name = "CannySecond";
            this.CannySecond.Size = new System.Drawing.Size(75, 45);
            this.CannySecond.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 514);
            this.Controls.Add(this.CannySecond);
            this.Controls.Add(this.CannyFirst);
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

        private System.Windows.Forms.ImageList imageList1;
        private Emgu.CV.UI.ImageBox DefaultImage;
        private System.Windows.Forms.Button SelectImageBtn;
        private Emgu.CV.UI.ImageBox ReImage;
        private System.Windows.Forms.Button ProcessBtn;
        private System.Windows.Forms.TrackBar CannyFirst;
        private System.Windows.Forms.TrackBar CannySecond;
    }
}

