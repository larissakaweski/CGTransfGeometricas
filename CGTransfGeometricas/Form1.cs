using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGTransfGeometricas
{
    public partial class tela : Form
    {
        Bitmap areaDesenho;
        Color corPreenche;
        int x1, y1, x2, y2;

        public tela()
        {
            InitializeComponent();
            areaDesenho = new Bitmap(imagem.Size.Width,
            imagem.Size.Height);
            corPreenche = Color.Black;
        }

        private void btDesenhar_Click(object sender, EventArgs e)
        {
            int x = (int)Convert.ToInt64(txtX.Text);
            int y = (int)Convert.ToInt64(txtY.Text);
            
            areaDesenho.SetPixel(x, y, corPreenche);
            imagem.Image = areaDesenho;
        }

        private void btRotacionar_Click(object sender, EventArgs e)
        {
            double angleDegrees = (double)numericUpDownAngle.Value;
            Point rotationCenter = new Point(imagem.Width / 2, imagem.Height / 2); // Ponto central da imagem

            Bitmap rotatedImage = RotateImage(areaDesenho, angleDegrees, rotationCenter);
            imagem.Image = rotatedImage;
        }

        private Bitmap RotateImage(Bitmap originalImage, double angleDegrees, Point rotationCenter)
        {
            Bitmap rotatedImage = new Bitmap(originalImage.Width, originalImage.Height);

            double angleRadians = angleDegrees * (Math.PI / 180.0);

            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    int xOffset = x - rotationCenter.X;
                    int yOffset = y - rotationCenter.Y;

                    int rotatedX = (int)(xOffset * Math.Cos(angleRadians) - yOffset * Math.Sin(angleRadians)) + rotationCenter.X;
                    int rotatedY = (int)(xOffset * Math.Sin(angleRadians) + yOffset * Math.Cos(angleRadians)) + rotationCenter.Y;

                    if (rotatedX >= 0 && rotatedX < rotatedImage.Width && rotatedY >= 0 && rotatedY < rotatedImage.Height)
                    {
                        rotatedImage.SetPixel(rotatedX, rotatedY, originalImage.GetPixel(x, y));
                    }
                }
            }

            return rotatedImage;
        }

        private void btTransladar_Click(object sender, EventArgs e)
        {
            int translateX = (int)numericUpDownTransX.Value;
            int translateY = (int)numericUpDownTransY.Value;

            Bitmap translatedImage = TranslateImage(areaDesenho, translateX, translateY);
            imagem.Image = translatedImage;
        }

        private Bitmap TranslateImage(Bitmap originalImage, int translateX, int translateY)
        {
            Bitmap translatedImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    int newX = x + translateX;
                    int newY = y + translateY;

                    if (newX >= 0 && newX < translatedImage.Width && newY >= 0 && newY < translatedImage.Height)
                    {
                        translatedImage.SetPixel(newX, newY, originalImage.GetPixel(x, y));
                    }
                }
            }

            return translatedImage;
        }

        private void btEscala_Click(object sender, EventArgs e)
        {
            double scaleValue = (double)numericUpDownScale.Value;

            Bitmap scaledImage = ScaleImage(areaDesenho, scaleValue);
            imagem.Image = scaledImage;
        }

        private Bitmap ScaleImage(Bitmap originalImage, double scaleValue)
        {
            numericUpDownScale.Minimum = 0.1m;
            numericUpDownScale.Maximum = 10.0m;
            numericUpDownScale.Increment = 0.1m;

            int newWidth = (int)(originalImage.Width * scaleValue);
            int newHeight = (int)(originalImage.Height * scaleValue);

            if (newWidth <= 0 || newHeight <= 0)
            {
                return originalImage;
            }

            Bitmap scaledImage = new Bitmap(newWidth, newHeight);

            using (Graphics g = Graphics.FromImage(scaledImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(originalImage, 0, 0, newWidth, newHeight);
            }

            return scaledImage;
        }

        private void btEspelhar_Click(object sender, EventArgs e)
        {
            Bitmap mirroredImage = MirrorImageBasedOnQuadrant(areaDesenho);
            imagem.Image = mirroredImage;
        }

        private Bitmap MirrorImageBasedOnQuadrant(Bitmap originalImage)
        {
            Bitmap mirroredImage = new Bitmap(originalImage.Width, originalImage.Height);

            using (Graphics g = Graphics.FromImage(mirroredImage))
            {
                g.TranslateTransform(originalImage.Width, 0);
                g.ScaleTransform(-1, 1);
                g.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height), 0, 0, originalImage.Width, originalImage.Height, GraphicsUnit.Pixel);
            }

            return mirroredImage;
        }

        private void btCor_Click(object sender, EventArgs e)
        {
            DialogResult result = cdlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                corPreenche = cdlg.Color;
            }
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            areaDesenho = new Bitmap(imagem.Size.Width, imagem.Size.Height);
            imagem.Image = areaDesenho;
        }

        private void imagem_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X;
                int y = e.Y;
                txtX.Text = Convert.ToString(x);
                txtY.Text = Convert.ToString(y);
                areaDesenho.SetPixel(x, y, corPreenche);
                imagem.Image = areaDesenho;
            }
        }
    }
}
