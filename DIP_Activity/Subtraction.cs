using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIP_Activity
{
    public partial class Subtraction : Form
    {
        OpenFileDialog openFile;
        SaveFileDialog saveFile;
        Bitmap imageB, imageA, resultImage;
        public Subtraction()
        {
            InitializeComponent();
            openFile = new OpenFileDialog(); // Open Dialog
            saveFile = new SaveFileDialog(); // Save Dialog

        }

        private void imageProcessingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ImageProcessing img = new ImageProcessing();
            img.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == saveFile.ShowDialog())
            {
                Image img = (Image)resultImage;
                img.Save(saveFile.FileName);
            }
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFile.ShowDialog())
            {
                imageB = new Bitmap(openFile.FileName);
                pictureBox1.Image = imageB;
            }
        }

        private void LoadBackgroundButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFile.ShowDialog())
            {
                imageA = new Bitmap(openFile.FileName);
                pictureBox2.Image = imageA;
            }
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(imageB.Width, imageB.Height);
            Color myGreen = Color.FromArgb(0, 255, 0);
            int greyGreen = (myGreen.R + myGreen.G + myGreen.B) / 3;
            int threshold = 5;

            for (int x = 0; x < imageB.Width; x++)
            {
                for (int y = 0; y < imageB.Height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    Color backPixel = imageA.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractValue = Math.Abs(grey - greyGreen);
                    if (subtractValue > threshold)
                    {
                        resultImage.SetPixel(x, y, pixel);
                    }
                    else
                    {
                        resultImage.SetPixel(x, y, backPixel);
                    }
                }
            }
            pictureBox3.Image = resultImage;
        }
    }
}
