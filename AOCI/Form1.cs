using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Util;

namespace AOCI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Image<Bgr, byte> sourceImage; //глобальная переменная

        private void SelectImageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                var result = openFileDialog.ShowDialog(); // открытие диалога выбора файла
                if (result == DialogResult.OK) // открытие выбранного файла
                {
                    string fileName = openFileDialog.FileName;
                    sourceImage = new Image<Bgr, byte>(fileName);
                }
                DefaultImage.Image = sourceImage.Resize(640, 480, Inter.Linear);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> grayImage = sourceImage.Convert<Gray, byte>();
            var tempImage = grayImage.PyrDown();
            var destImage = tempImage.PyrUp();
            
            double cannyThreshold = CannyFirst.Value;
            double cannyThresholdLinking = CannySecond.Value;
            
            Image<Gray, byte> cannyEdges = destImage.Canny(cannyThreshold, cannyThresholdLinking);
            
            ReImage.Image = sourceImage.Resize(640, 480, Inter.Linear);

        }
    }
}
