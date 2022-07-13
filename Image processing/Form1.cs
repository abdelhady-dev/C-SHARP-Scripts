using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using openCV;

namespace openDialogApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IplImage image1;
        IplImage image2;
        IplImage image3;
        IplImage img;
        Bitmap bmp;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = " ";
            openFileDialog1.Filter = "JPEG|*JPG|Bitmap|*.bmp|All|*.*-11";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image1 = cvlib.CvLoadImage(openFileDialog1.FileName, cvlib.CV_LOAD_IMAGE_COLOR);
                    CvSize size = new CvSize(pictureBox1.Width, pictureBox1.Height);
                    IplImage resized_image = cvlib.CvCreateImage(size, image1.depth, image1.nChannels);
                    cvlib.CvResize(ref image1, ref resized_image, cvlib.CV_INTER_LINEAR);

                    pictureBox1.BackgroundImage = (Image)resized_image;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void redGreanBlue(int color)
        {
            img = cvlib.CvCreateImage(new CvSize(image1.width, image1.height), image1.depth, image1.nChannels);
            int srcAdd = image1.imageData.ToInt32();
            int dstAdd = img.imageData.ToInt32();

            unsafe
            {
                int srcIndex, dstIndex;
                for (int r = 0; r < img.height; r++)
                    for (int c = 0; c < img.width; c++)
                    {
                        srcIndex = dstIndex = (img.width * r * img.nChannels) + (c * img.nChannels);
                        switch (color)
                        {
                            case 0: // blue
                                *(byte*)(dstAdd + dstIndex + 0) = *(byte*)(srcAdd + srcIndex + 0);
                                *(byte*)(dstAdd + dstIndex + 1) = 0;
                                *(byte*)(dstAdd + dstIndex + 2) = 0;
                                break;
                            case 1: // green
                                *(byte*)(dstAdd + dstIndex + 0) = 0;
                                *(byte*)(dstAdd + dstIndex + 1) = *(byte*)(srcAdd + srcIndex + 1);
                                *(byte*)(dstAdd + dstIndex + 2) = 0;
                                break;
                            case 2: // red
                                *(byte*)(dstAdd + dstIndex + 0) = 0;
                                *(byte*)(dstAdd + dstIndex + 1) = 0;
                                *(byte*)(dstAdd + dstIndex + 2) = *(byte*)(srcAdd + srcIndex + 2);
                                break;
                        }

                    }
            }
            CvSize size = new CvSize(pictureBox2.Width, pictureBox2.Height);
            IplImage resized_image = cvlib.CvCreateImage(size, img.depth, img.nChannels);
            cvlib.CvResize(ref img, ref resized_image, cvlib.CV_INTER_LINEAR);
            pictureBox2.BackgroundImage = (Image)resized_image;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redGreanBlue(2);
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redGreanBlue(1);
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redGreanBlue(0);
        }

        private Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }

            return result;
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)image1;
            int w = bmp.Width;
            int h = bmp.Height;
            Color p;
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    p = bmp.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;
                    int av = (r + g + b) / 3;
                    bmp.SetPixel(x, y, Color.FromArgb(a, av, av, av));
                }
            }
            bmp = ResizeBitmap(bmp, pictureBox2.Width, pictureBox2.Height);
            pictureBox2.BackgroundImage = (Image)bmp;
        }

        private void addImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = " ";
            openFileDialog1.Filter = "JPEG|*JPG|Bitmap|*.bmp|All|*.*-11";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image2 = cvlib.CvLoadImage(openFileDialog1.FileName, cvlib.CV_LOAD_IMAGE_COLOR);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            CvSize size = new CvSize(pictureBox2.Width, pictureBox2.Height);

            IplImage resized_image1 = cvlib.CvCreateImage(size, image1.depth, image1.nChannels);
            cvlib.CvResize(ref image1, ref resized_image1, cvlib.CV_INTER_LINEAR);

            IplImage resized_image2 = cvlib.CvCreateImage(size, image2.depth, image2.nChannels);
            cvlib.CvResize(ref image2, ref resized_image2, cvlib.CV_INTER_LINEAR);


            image3 = cvlib.CvCreateImage(size, image1.depth, image1.nChannels);

            int srcX = resized_image1.imageData.ToInt32();
            int srcY = resized_image2.imageData.ToInt32();
            int dstAddress = image3.imageData.ToInt32();
            unsafe
            {
                for (int r = 0; r < resized_image1.height; r++)
                {
                    for (int c = 0; c < resized_image1.width; c++)
                    {

                        int srcIndexX, srcIndexY, disIndex;
                        srcIndexX = (resized_image1.width * r * resized_image1.nChannels) + (resized_image1.nChannels * c);
                        srcIndexY = (resized_image2.width * r * resized_image2.nChannels) + (resized_image2.nChannels * c);
                        disIndex = (image3.width * r * image3.nChannels) + (image3.nChannels * c);

                        byte* redX = (byte*)(srcX + srcIndexX + 2);
                        byte* greenX = (byte*)(srcX + srcIndexX + 1);
                        byte* blueX = (byte*)(srcX + srcIndexX + 0);

                        byte* redY = (byte*)(srcY + srcIndexY + 2);
                        byte* greenY = (byte*)(srcY + srcIndexY + 1);
                        byte* blueY = (byte*)(srcY + srcIndexY + 0);

                        byte red = (byte)Math.Min(255, (*redX + *redY));
                        byte green = (byte)Math.Min(255, (*greenX + *greenY));
                        byte blue = (byte)Math.Min(255, (*blueX + *blueY));

                        *(byte*)(dstAddress + disIndex + 2) = red;
                        *(byte*)(dstAddress + disIndex + 1) = green;
                        *(byte*)(dstAddress + disIndex + 0) = blue;
                    }
                }
            }


            IplImage resized_image3 = cvlib.CvCreateImage(size, image3.depth, image3.nChannels);
            cvlib.CvResize(ref image3, ref resized_image3, cvlib.CV_INTER_LINEAR);
            pictureBox2.BackgroundImage = (Image)resized_image3;
        }

        private void histogramToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            chart1.Series["Red"].Points.Clear();
            chart1.Series["Green"].Points.Clear();
            chart1.Series["Blue"].Points.Clear();

            Bitmap bmpImg = (Bitmap) image1;
            int width = bmpImg.Width;
            int hieght = bmpImg.Height;


            int[] ni_Red = new int[256];
            int[] ni_Green = new int[256];
            int[] ni_Blue = new int[256];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < hieght; j++)
                {
                    Color pixelColor = bmpImg.GetPixel(i, j);

                    ni_Red[pixelColor.R]++;
                    ni_Green[pixelColor.G]++;
                    ni_Blue[pixelColor.B]++;

                }
            }


            for (int i = 0; i < 256; i++)
            {
                chart1.Series["Red"].Points.AddY(ni_Red[i]);
                chart1.Series["Green"].Points.AddY(ni_Green[i]);
                chart1.Series["Blue"].Points.AddY(ni_Blue[i]);
            }
        }

        private void equalizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Series["Red"].Points.Clear();
            chart1.Series["Green"].Points.Clear();
            chart1.Series["Blue"].Points.Clear();

            Bitmap bmpImg = (Bitmap)image1;
            Bitmap newImage = bmpImg;
            int width = bmpImg.Width;
            int hieght = bmpImg.Height;

            //******************* Calculate N(i) **************//

            int[] ni_Red = new int[256];
            int[] ni_Green = new int[256];
            int[] ni_Blue = new int[256];


            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < hieght; j++)
                {
                    Color pixelColor = bmpImg.GetPixel(i, j);

                    ni_Red[pixelColor.R]++;
                    ni_Green[pixelColor.G]++;
                    ni_Blue[pixelColor.B]++;
                }
            }

            //******************* Calculate P(Ni) **************//

            decimal[] prob_ni_Red = new decimal[256];
            decimal[] prob_ni_Green = new decimal[256];
            decimal[] prob_ni_Blue = new decimal[256];

            for (int i = 0; i < 256; i++)
            {
                prob_ni_Red[i] = (decimal) ni_Red[i] / (decimal)(width * hieght);
                prob_ni_Green[i] = (decimal) ni_Green[i] / (decimal)(width * hieght);
                prob_ni_Blue[i] = (decimal) ni_Blue[i] / (decimal)(width * hieght);
            }

            //******************* Calculate CDF **************//

            decimal[] cdf_Red = new decimal[256];
            decimal[] cdf_Green = new decimal[256];
            decimal[] cdf_Blue = new decimal[256];

            cdf_Red[0] = prob_ni_Red[0];
            cdf_Green[0] = prob_ni_Green[0];
            cdf_Blue[0] = prob_ni_Blue[0];

            for (int i = 1; i < 256; i++)
            {
                cdf_Red[i] = prob_ni_Red[i] + cdf_Red[i - 1];
                cdf_Green[i] = prob_ni_Green[i] + cdf_Green[i - 1];
                cdf_Blue[i] = prob_ni_Blue[i] + cdf_Blue[i - 1];
            }

            //******************* Calculate CDF(L-1) **************//

            int red, green, blue;
            int constant = 255;

            int[] eq_Red = new int[256];
            int[] eq_Green = new int[256];
            int[] eq_Blue = new int[256];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < hieght; j++)
                {
                    Color pixelColor = bmpImg.GetPixel(i, j);

                    red = (int)Math.Round(cdf_Red[pixelColor.R] * constant);
                    green = (int)Math.Round(cdf_Red[pixelColor.G] * constant);
                    blue = (int)Math.Round(cdf_Red[pixelColor.B] * constant);

                    eq_Red[red]++;
                    eq_Green[green]++;
                    eq_Blue[blue]++;

                    Color newColor = Color.FromArgb(red, green, blue);
                    newImage.SetPixel(i, j, newColor);
                }
            }
            newImage = ResizeBitmap(newImage, pictureBox3.Width, pictureBox3.Height);
            pictureBox3.Image = (Image) newImage;

            for (int i = 0; i < 256; i++)
            {
                chart1.Series["Red"].Points.AddY(eq_Red[i]);
                chart1.Series["Green"].Points.AddY(eq_Green[i]);
                chart1.Series["Blue"].Points.AddY(eq_Blue[i]);
            }
        }

        public static Bitmap MirrorHorizontal(Bitmap src)
        {
            if (src != null)
            {
                Bitmap dst = new Bitmap(src.Width, src.Height);
                BitmapData srcBmData = src.LockBits(new Rectangle(0, 0, src.Width, src.Height), ImageLockMode.ReadWrite, src.PixelFormat);
                BitmapData dstBmData = dst.LockBits(new Rectangle(0, 0, dst.Width, dst.Height), ImageLockMode.ReadWrite, src.PixelFormat);

                try
                {
                    int height = src.Height;
                    int width = src.Width;
                    int stride = srcBmData.Stride;
                    int bytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(src.PixelFormat) / 8;
                    int offset = stride - width * bytesPerPixel;
                    int totalLength = Math.Abs(stride) * src.Height;
                    IntPtr srcPtr = srcBmData.Scan0;
                    IntPtr dstPtr = dstBmData.Scan0;
                    // Declaramos un arreglo para guardar toda la data.
                    byte[] srcData = new byte[totalLength];
                    byte[] dstData = new byte[totalLength];
                    // Copiamos los valores RGB en el arreglo.
                    System.Runtime.InteropServices.Marshal.Copy(srcPtr, srcData, 0, totalLength);
                    // Posicion Inicial
                    int beginPos = 0;
                    // Posicion Final
                    int endPos = (src.Width - 1) * bytesPerPixel;

                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++, endPos += -bytesPerPixel - bytesPerPixel)
                        {
                            for (int index = 0; index < bytesPerPixel; index++, beginPos++, endPos++)
                            {
                                dstData[beginPos] = srcData[endPos];
                            }
                        }

                        beginPos += offset;
                        endPos = beginPos + (src.Width - 1) * bytesPerPixel;
                    }

                    // Copy the RGB values back to the bitmap
                    System.Runtime.InteropServices.Marshal.Copy(dstData, 0, dstPtr, totalLength);
                }

                finally
                {
                    src.UnlockBits(srcBmData);
                    dst.UnlockBits(dstBmData);
                }

                return dst;
            }

            return null;
        }

        public static Bitmap ImageSmooth(Bitmap image)
        {
            int w = image.Width;
            int h = image.Height;
            BitmapData image_data = image.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);
            int bytes = image_data.Stride * image_data.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            Marshal.Copy(image_data.Scan0, buffer, 0, bytes);
            image.UnlockBits(image_data);
            for (int i = 2; i < w - 2; i++)
            {
                for (int j = 2; j < h - 2; j++)
                {
                    int p = i * 3 + j * image_data.Stride;
                    for (int k = 0; k < 3; k++)
                    {
                        List<int> vals = new List<int>();
                        for (int xkernel = -2; xkernel < 3; xkernel++)
                        {
                            for (int ykernel = -2; ykernel < 3; ykernel++)
                            {
                                int kernel_p = k + p + xkernel * 3 + ykernel * image_data.Stride;
                                vals.Add(buffer[kernel_p]);
                            }
                        }
                        result[p + k] = (byte)(vals.Sum() / vals.Count);
                    }
                }
            }
            Bitmap res_img = new Bitmap(w, h);
            BitmapData res_data = res_img.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb);
            Marshal.Copy(result, 0, res_data.Scan0, bytes);
            res_img.UnlockBits(res_data);
            return res_img;
        }


        public static Bitmap MedianFilterGrayScale(Bitmap bm)
        {
            List<byte> termsList = new List<byte>();

            byte[,] image = new byte[bm.Width, bm.Height];

            //Convert to Grayscale 
            for (int i = 0; i < bm.Width; i++)
            {
                for (int j = 0; j < bm.Height; j++)
                {
                    var c = bm.GetPixel(i, j);
                    byte gray = (byte)(.333 * c.R + .333 * c.G + .333 * c.B);
                    image[i, j] = gray;
                }
            }

            //applying Median Filtering 
            for (int i = 0; i <= bm.Width - 3; i++)
                for (int j = 0; j <= bm.Height - 3; j++)
                {
                    for (int x = i; x <= i + 2; x++)
                        for (int y = j; y <= j + 2; y++)
                        {
                            termsList.Add(image[x, y]);
                        }
                    byte[] terms = termsList.ToArray();
                    termsList.Clear();
                    Array.Sort<byte>(terms);
                    Array.Reverse(terms);
                    byte color = terms[4];
                    bm.SetPixel(i + 1, j + 1, Color.FromArgb(color, color, color));
                }
            return bm;
        }

        public static Bitmap MedianFilterRGB(Bitmap sourceBitmap,
                                            int matrixSize,
                                              int bias = 0,
                                    bool grayscale = false)
        {
            BitmapData sourceData =
                       sourceBitmap.LockBits(new Rectangle(0, 0,
                       sourceBitmap.Width, sourceBitmap.Height),
                       ImageLockMode.ReadOnly,
                       PixelFormat.Format32bppArgb);


            byte[] pixelBuffer = new byte[sourceData.Stride *
                                          sourceData.Height];


            byte[] resultBuffer = new byte[sourceData.Stride *
                                           sourceData.Height];


            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0,
                                       pixelBuffer.Length);


            sourceBitmap.UnlockBits(sourceData);


            if (grayscale == true)
            {
                float rgb = 0;


                for (int k = 0; k < pixelBuffer.Length; k += 4)
                {
                    rgb = pixelBuffer[k] * 0.11f;
                    rgb += pixelBuffer[k + 1] * 0.59f;
                    rgb += pixelBuffer[k + 2] * 0.3f;


                    pixelBuffer[k] = (byte)rgb;
                    pixelBuffer[k + 1] = pixelBuffer[k];
                    pixelBuffer[k + 2] = pixelBuffer[k];
                    pixelBuffer[k + 3] = 255;
                }
            }


            int filterOffset = (matrixSize - 1) / 2;
            int calcOffset = 0;


            int byteOffset = 0;

            List<int> neighbourPixels = new List<int>();
            byte[] middlePixel;


            for (int offsetY = filterOffset; offsetY <
                sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX <
                    sourceBitmap.Width - filterOffset; offsetX++)
                {
                    byteOffset = offsetY *
                                 sourceData.Stride +
                                 offsetX * 4;


                    neighbourPixels.Clear();


                    for (int filterY = -filterOffset;
                        filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset;
                            filterX <= filterOffset; filterX++)
                        {


                            calcOffset = byteOffset +
                                         (filterX * 4) +
                                (filterY * sourceData.Stride);


                            neighbourPixels.Add(BitConverter.ToInt32(
                                             pixelBuffer, calcOffset));
                        }
                    }


                    neighbourPixels.Sort();

                    middlePixel = BitConverter.GetBytes(
                                       neighbourPixels[filterOffset]);


                    resultBuffer[byteOffset] = middlePixel[0];
                    resultBuffer[byteOffset + 1] = middlePixel[1];
                    resultBuffer[byteOffset + 2] = middlePixel[2];
                    resultBuffer[byteOffset + 3] = middlePixel[3];
                }
            }


            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width,
                                             sourceBitmap.Height);


            BitmapData resultData =
                       resultBitmap.LockBits(new Rectangle(0, 0,
                       resultBitmap.Width, resultBitmap.Height),
                       ImageLockMode.WriteOnly,
                       PixelFormat.Format32bppArgb);


            Marshal.Copy(resultBuffer, 0, resultData.Scan0,
                                       resultBuffer.Length);


            resultBitmap.UnlockBits(resultData);


            return resultBitmap;
        }

        private void mirrorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmpImg = (Bitmap) image1;
            Bitmap newImage = MirrorHorizontal(bmpImg);
            newImage = ResizeBitmap(newImage, pictureBox2.Width, pictureBox2.Height);
            pictureBox2.Image = (Image)newImage;
        }

        private void smoothingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmpImg = (Bitmap) image1;
            Bitmap newImage = ImageSmooth(bmpImg);
            newImage = ResizeBitmap(newImage, pictureBox2.Width, pictureBox2.Height);
            pictureBox2.Image = (Image)newImage;
        }

        private void medianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmpImg = (Bitmap)image1;
            Bitmap newImage = MedianFilterGrayScale(bmpImg);
            newImage = ResizeBitmap(newImage, pictureBox2.Width, pictureBox2.Height);
            pictureBox2.Image = (Image)newImage;
        }

        private void medianRGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmpImg = (Bitmap)image1;
            Bitmap newImage = MedianFilterRGB(bmpImg, 5);
            newImage = ResizeBitmap(newImage, pictureBox2.Width, pictureBox2.Height);
            pictureBox2.Image = (Image)newImage;
        }
    }
}
