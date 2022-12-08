using System;
using System.Drawing;
using System.Windows.Forms;

namespace DIP_Activity
{
    public partial class ImageProcessing : Form
    {
        OpenFileDialog openFile;
        SaveFileDialog saveFile;
        Bitmap newImage, editedImage;
        public ImageProcessing()
        {
            InitializeComponent();
            openFile = new OpenFileDialog(); // Open Dialog 
            openFile.RestoreDirectory = true;
            openFile.InitialDirectory = "C:\\";
            openFile.FilterIndex = 1;
            openFile.Filter = "jpg Files (*.jpg)|*.jpg|gif Files (*.gif)|*.gif|png Files (*.png)|*.png |bmp Files (*.bmp)|*.bmp";
      
            saveFile = new SaveFileDialog(); // Save Dialog
            saveFile.RestoreDirectory = true;
            saveFile.InitialDirectory = "C:\\";
            saveFile.FilterIndex = 1;
            saveFile.Filter = "jpg Files (*.jpg)|*.jpg|gif Files (*.gif)|*.gif|png Files (*.png)|*.png |bmp Files (*.bmp)|*.bmp";
   
        }

        /// <summary>
        /// Opens FileDialog for choosing of images
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Open_MenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFile.ShowDialog())
            {
                newImage = new Bitmap(openFile.FileName);
                pictureBox1.Image = newImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        /// <summary>
        /// Saving the edited image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_MenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == saveFile.ShowDialog())
            {
                Image img = (Image)editedImage;
                img.Save(saveFile.FileName);
            }
        }

        /// <summary>
        /// COPY
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Copy_MenuItem_Click(object sender, EventArgs e)
        {
            editedImage = new Bitmap(newImage.Width, newImage.Height);
            for (int x = 0; x < newImage.Width; x++)
            {
                for (int y = 0; y < newImage.Height; y++)
                {
                    Color p = newImage.GetPixel(x, y);
                    editedImage.SetPixel(x, y, p);
                }
            }
            pictureBox2.Image = editedImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /// <summary>
        /// GREYSCALE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Greyscale_MenuItem_Click(object sender, EventArgs e)
        {
            editedImage = new Bitmap(newImage.Width, newImage.Height);
            for (int x = 0; x < newImage.Width; x++)
            {
                for (int y = 0; y < newImage.Height; y++)
                {
                    Color p = newImage.GetPixel(x, y);
                    int grey = (p.R + p.G + p.B) / 3;
                    editedImage.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                }
            }
            pictureBox2.Image = editedImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /// <summary>
        /// COLOR INVERSION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Inversion_MenuItem_Click(object sender, EventArgs e)
        {
            editedImage = new Bitmap(newImage.Width, newImage.Height);
            for (int x = 0; x < newImage.Width; x++)
            {
                for (int y = 0; y < newImage.Height; y++)
                {
                    Color p = newImage.GetPixel(x, y);
                    int grey = (p.R + p.G + p.B) / 3;
                    editedImage.SetPixel(x, y, Color.FromArgb(255 - p.R, 255 - p.G, 255 - p.B));
                }
            }
            pictureBox2.Image = editedImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /// <summary>
        /// HISTOGRAM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Histogram_MenuItem_Click(object sender, EventArgs e)
        {
            Color p;

            for (int x = 0; x < newImage.Width; x++)
            {
                for (int y = 0; y < newImage.Height; y++)
                {
                    p = newImage.GetPixel(x, y);
                    int grey = (p.R + p.G + p.B) / 3;
                    newImage.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                }
            }

            int[] hisdata = new int[256];
            for (int x = 0; x < newImage.Width; x++)
            {
                for (int y = 0; y < newImage.Height; y++)
                {
                    p = newImage.GetPixel(x, y);
                    hisdata[p.R]++;
                }
            }

            editedImage = new Bitmap(256, 800);
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < 800; y++)
                {
                    editedImage.SetPixel(x, y, Color.White);
                }
            }

            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < Math.Min(hisdata[x] / 5, editedImage.Height - 1); y++)
                {
                    editedImage.SetPixel(x, (editedImage.Height - 1) - y, Color.Black);
                }
            }

            pictureBox2.Image = editedImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /// <summary>
        /// SEPIA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sepia_MenuItem_Click(object sender, EventArgs e)
        {
            editedImage = new Bitmap(newImage.Width, newImage.Height);
            for (int x = 0; x < newImage.Width; x++)
            {
                for (int y = 0; y < newImage.Height; y++)
                {
                    Color p = newImage.GetPixel(x, y);
                    int r = (int)(0.393 * p.R + 0.769 * p.G + 0.189 * p.B);
                    int g = (int)(0.349 * p.R + 0.686 * p.G + 0.168 * p.B);
                    int b = (int)(0.272 * p.R + 0.534 * p.G + 0.131 * p.B);

                    if (r > 255)
                    {
                        r = 255;
                    }

                    if (g > 255)
                    {
                        g = 255;
                    }

                    if (b > 255)
                    {
                        b = 255;
                    }

                    editedImage.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            pictureBox2.Image = editedImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Subtraction_MenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subtraction sub = new Subtraction();
            sub.Show();
        }
    }
}

    

        