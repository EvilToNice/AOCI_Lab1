using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Util;
using static System.Net.Mime.MediaTypeNames;


namespace AOCI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt50.Text = 0.ToString();
            txt100.Text = 25.ToString();
            txt150.Text = 100.ToString();
            txt200.Text = 180.ToString();
            txt255.Text = 255.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Image<Bgr, byte> sourceImage; //глобальная переменная
        int frameCount = 0;
        private void SelectImageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Файлы изображений (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                var result = openFileDialog.ShowDialog(); // открытие диалога выбора файла

                if (result == DialogResult.OK) // открытие выбранного файла
                {
                    string fileName = openFileDialog.FileName;
                    sourceImage = new Image<Bgr, byte>(fileName).Resize(640, 480, Inter.Linear);
                    DefaultImage.Image = sourceImage;//.Resize(640, 480, Inter.Linear)
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void OperationColor(Image<Gray, byte> grayImage)
        {
            try
            {
                //Image<Gray, byte> grayImage = sourceImage.Convert<Gray, byte>();
                Parallel.Invoke(() =>
                {

                    var tempImage = grayImage.PyrDown();
                    var destImage = tempImage.PyrUp();

                    double cannyThreshold = CannyFirst.Value;
                    double cannyThresholdLinking = CannySecond.Value;

                    Image<Gray, byte> cannyEdges = destImage.Canny(cannyThreshold, cannyThresholdLinking);

                    //var cannyEdgesBgr = cannyEdges.Convert<Bgr, byte>();
                    var cannyEdgesBgr = cannyEdges.Convert<Bgr, byte>();
                    Image<Bgr, byte> resultImage;// = sourceImage.Sub(cannyEdgesBgr);

                    if (sourceImage == null)
                    {
                        var frame = capture.QueryFrame();
                        capture.Retrieve(frame); // получение текущего кадра

                        Image<Bgr, byte> image = frame.ToImage<Bgr, byte>();
                        resultImage = image.Sub(cannyEdgesBgr);

                    }
                    else
                    {

                        resultImage = sourceImage.Sub(cannyEdgesBgr); // попиксельное вычитание
                    }



                    //обход по каналам
                    for (int channel = 0; channel < resultImage.NumberOfChannels; channel++)
                        for (int x = 0; x < resultImage.Width; x++)
                            for (int y = 0; y < resultImage.Height; y++) // обход по пискелям
                            {
                                // получение цвета пикселя
                                byte color = resultImage.Data[y, x, channel];
                                if (color <= 50)
                                    color = Convert.ToByte(txt50.Text);
                                else if (color <= 100)
                                    color = Convert.ToByte(txt100.Text);
                                else if (color <= 150)
                                    color = Convert.ToByte(txt150.Text);
                                else if (color <= 200)
                                    color = Convert.ToByte(txt200.Text);
                                else
                                    color = Convert.ToByte(txt255.Text);
                                resultImage.Data[y, x, channel] = color; // изменение цвета пикселя
                            }

                    ReImage.Image = resultImage;//.Resize(640, 480, Inter.Linear)

                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            OperationColor(sourceImage.Convert<Gray, byte>());
        }
        private VideoCapture capture;
        private void VideoBTN_Click(object sender, EventArgs e)
        {
            // инициализация веб-камеры
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы изображений (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog.Filter = "Movie Files (*.mpg, *.avi, *.mp4)|*.mpg;*.avi; *.mp4";

            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK) // открытие выбранного файла
            {
                string fileName = openFileDialog.FileName;

                capture = new VideoCapture(fileName);
                //capture.ImageGrabbed += ProcessFrame;
                if (sourceImage != null)
                {
                    sourceImage = null;
                }
                //var frameHeight = capture.GetCaptureProperty(CapProp.FrameHeight); //высота кадров видео
                //var frameWidth = capture.GetCaptureProperty(CapProp.FrameWidth); //ширина кадров видео
                //var frameRate = capture.GetCaptureProperty(CapProp.XiFramerate); //кадроы в секунду в герцах
                TimerVideo.Enabled = true;
                if (capture.GetCaptureProperty(CapProp.XiFramerate) > 0)
                {
                    TimerVideo.Interval = Convert.ToInt32(capture.GetCaptureProperty(CapProp.XiFramerate));
                    
                }
 

            }


            //capture.Stop(); // остановка обработки видеопотока

        }

        // захват кадра из видеопотока
        //private void ProcessFrame(object sender, EventArgs e)
        //{
        //    var frame = new Mat();
        //    capture.Retrieve(frame); // получение текущего кадра

        //    Image<Bgr, byte> image = frame.ToImage<Bgr, byte>();

        //    Image<Gray, byte> grayImage = image.Convert<Gray, byte>();

        //    var tempImage = grayImage.PyrDown();
        //    var destImage = tempImage.PyrUp();

        //    double cannyThreshold = 40.0;//CannyFirst.Value;
        //    double cannyThresholdLinking = 10.0;// CannySecond.Value;

        //    Image<Gray, byte> cannyEdges = destImage.Canny(cannyThreshold, cannyThresholdLinking);

        //    //var cannyEdgesBgr = cannyEdges.Convert<Bgr, byte>();
        //    DefaultImage.Image = image.Resize(640, 480, Inter.Linear);

        //}

        private void TimerVideo_Tick(object sender, EventArgs e)
        {
            var frame = capture.QueryFrame();
            capture.Retrieve(frame); // получение текущего кадра

            Image<Bgr, byte> image = frame.ToImage<Bgr, byte>();

            //Image<Gray, byte> grayImage = image.Convert<Gray, byte>();

            //var tempImage = grayImage.PyrDown();
            //var destImage = tempImage.PyrUp();

            //double cannyThreshold = CannyFirst.Value;
            //double cannyThresholdLinking =  CannySecond.Value;

            //Image<Gray, byte> cannyEdges = destImage.Canny(cannyThreshold, cannyThresholdLinking);
            //ReImage.Image = cannyEdges.Resize(640, 480, Inter.Linear);
            //DefaultImage.Image = image.Resize(640, 480, Inter.Linear);
            OperationColor(image.Convert<Gray, byte>());

            frameCount++;
            //var frameCount = capture.GetCaptureProperty(CapProp.FrameCount); //количество кадров в видео

            if (frameCount >= capture.GetCaptureProperty(CapProp.FrameCount))
            {
                TimerVideo.Enabled = false;
            }
            
        }

        private void label2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.Clear(this.BackColor);
            //e.Graphics.RotateTransform(-90);
            //SizeF textSize = e.Graphics.MeasureString(label1.Text, label1.Font);
            //label1.Width = (int)textSize.Height + 2;
            //label1.Height = (int)textSize.Width + 2;
            //e.Graphics.TranslateTransform(-label1.Height / 2, label1.Width / 2);
            //e.Graphics.DrawString(label1.Text, label1.Font, Brushes.Black, -(textSize.Width / 2), -(textSize.Height / 2));
        }
    }
}
