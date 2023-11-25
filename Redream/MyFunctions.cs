using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Emgu.CV;
//using Emgu.CV.Structure;
//using DlibDotNet;
namespace Redream
{
    internal class MyFunctions
    {

        public static Image LerpImages2(Image image1, Image image2, float t)
        {
            int width = image1.Width;
            int height = image1.Height;

            Bitmap bmp = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;

                // Calculate the opacity values for each image
                int opacity1 = (int)Math.Round(255 * (1 - t));
                int opacity2 = (int)Math.Round(255 * t);

                // Create image attributes for applying opacity
                ColorMatrix matrix1 = new ColorMatrix { Matrix33 = opacity1 / 255f };
                ColorMatrix matrix2 = new ColorMatrix { Matrix33 = opacity2 / 255f };
                ImageAttributes attributes1 = new ImageAttributes();
                ImageAttributes attributes2 = new ImageAttributes();
                attributes1.SetColorMatrix(matrix1, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                attributes2.SetColorMatrix(matrix2, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                // Draw the first image with the adjusted opacity
                Rectangle rect1 = new Rectangle(0, 0, width, height);
                g.DrawImage(image1, rect1, 0, 0, width, height, GraphicsUnit.Pixel, attributes1);

                // Draw the second image with the adjusted opacity
                Rectangle rect2 = new Rectangle(0, 0, width, height);
                g.DrawImage(image2, rect2, 0, 0, width, height, GraphicsUnit.Pixel, attributes2);
            }

            return bmp;
        }

        public static Image LerpImages(Image img1, Image img2, float opacity)
        {
            Bitmap bmp = new Bitmap(img2.Width, img2.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                g.DrawImage(img2, new Rectangle(0, 0, img2.Width, img2.Height), 0, 0, img2.Width, img2.Height, GraphicsUnit.Pixel, attributes);
            }

            Bitmap img = (Bitmap)img1.Clone();
            using (Graphics g = Graphics.FromImage(img))
            {
                g.DrawImage(bmp, 0, 0, bmp.Width, bmp.Height);
            }

            // Dispose of the Graphics objects
            bmp.Dispose();

            return img;
        }

        public static Bitmap MergeImages(Image image1, Image image2, int space)
        {
            Bitmap bitmap = new Bitmap(image1.Width + image2.Width + space, Math.Max(image1.Height, image2.Height));
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.Black);
                g.DrawImage(image1, 0, 0);
                g.DrawImage(image2, image1.Width + space, 0);
            }
            return bitmap;
        }

        public static Size NormalizeSize2(Size size, int maxSize)
        {
            int width = size.Width;
            int height = size.Height;

            // Calculate the total number of pixels
            int totalPixels = width * height;

            // Check if the image exceeds the maximum total pixels
            if (totalPixels > (maxSize * maxSize))
            {
                // Calculate the aspect ratio
                double aspectRatio = (double)width / height;

                // Calculate the new width and height while maintaining the aspect ratio and limiting the total pixels
                double scaleFactor = Math.Sqrt((double)(maxSize * maxSize) / totalPixels);
                width = (int)(width * scaleFactor);
                height = (int)(height * scaleFactor);
            }

            // Adjust the size to be a multiple of 8
            width = (width / 8) * 8;
            height = (height / 8) * 8;

            return new Size(width, height);
        }
        public static Size NormalizeSize(Size size, int maxSize)
        {
            int width = size.Width;
            int height = size.Height;

            // Calculate the aspect ratio of the original image
            float aspectRatio = (float)width / height;

            // Calculate the new width and height based on the maximum size and aspect ratio
            int newWidth, newHeight;
            if (width > height)
            {
                newWidth = maxSize;
                newHeight = (int)(maxSize / aspectRatio);
            }
            else
            {
                newHeight = maxSize;
                newWidth = (int)(maxSize * aspectRatio);
            }
            // Adjust the size to be a multiple of 8
            newWidth = (newWidth / 8) * 8;
            newHeight = (newHeight / 8) * 8;

            // Return the new size as a Size object
            return new Size(newWidth, newHeight);
        }



        public static Bitmap GenerateGradientMask(Size size, int fillPercentage)
        {
            int width = size.Width;
            int height = size.Height;

            Bitmap gradientMask = new Bitmap(width, height);

            using (Graphics graphics = Graphics.FromImage(gradientMask))
            {
                graphics.FillRectangle(Brushes.White, 0, 0, width, height);
                int fillHeight = height * fillPercentage / 100;
                graphics.FillRectangle(Brushes.Black, 0, 0, width, fillHeight);
            }

            return gradientMask;
        }

        public static int SearchValueInDatagridView(DataGridView grid, string searchValue, int cell = 0)
        {
            int rowIndex = -1;
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Cells[cell].Value != null && row.Cells[cell].Value.ToString().ToLower() == searchValue.ToLower())
                {
                    rowIndex = row.Index;
                    break;
                }
            }
            return rowIndex;
        }

        public static int SearchValueInList(List<string> list, string searchValue)
        {
            int index = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == searchValue)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }



        public static string FindBestMatch(string input, string[] candidates)
        {
            int minDistance = int.MaxValue;
            string bestMatch = string.Empty;

            foreach (string candidate in candidates)
            {
                int distance = ComputeLevenshteinDistance(input, candidate);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    bestMatch = candidate;
                }
            }

            return bestMatch;
        }

        static int ComputeLevenshteinDistance(string source, string target)
        {
            int[,] distances = new int[source.Length + 1, target.Length + 1];

            for (int i = 0; i <= source.Length; i++)
                distances[i, 0] = i;

            for (int j = 0; j <= target.Length; j++)
                distances[0, j] = j;

            for (int i = 1; i <= source.Length; i++)
            {
                for (int j = 1; j <= target.Length; j++)
                {
                    int cost = source[i - 1] == target[j - 1] ? 0 : 1;

                    distances[i, j] = Math.Min(
                        Math.Min(distances[i - 1, j] + 1, distances[i, j - 1] + 1),
                        distances[i - 1, j - 1] + cost
                    );
                }
            }

            return distances[source.Length, target.Length];
        }

        public static byte[] ImageToBytes(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }

        public static Rectangle[] DetectAndApplyMask(Bitmap img)
        {
            /*
            Mat mat = img.ToMat();
            */
            img.Save("temp.jpg");
            // Load the image using Emgu.CV
            Image<Bgr, byte> image = new Image<Bgr, byte>("temp.jpg");

            // Load the pre-trained face cascade classifier
            CascadeClassifier faceCascade = new CascadeClassifier("Data\\Haarcascade\\haarcascade_frontalface_alt.xml");
            //CascadeClassifier faceCascade = new CascadeClassifier("Data\\Haarcascade\\haarcascade_profileface.xml");
            //CascadeClassifier faceCascade = new CascadeClassifier("Data\\Haarcascade\\haarcascade_fullbody.xml");
            //CascadeClassifier faceCascade = new CascadeClassifier("Data\\Haarcascade\\haarcascade_upperbody.xml");



            Rectangle[] faces = new Rectangle[] { Rectangle.Empty };


            // Convert the image to grayscale for face detection
            using (var grayImage = image.Convert<Gray, byte>())
            {
                faces = faceCascade.DetectMultiScale(grayImage, 1.5, 3, Size.Empty);
                faces = faceCascade.DetectMultiScale(grayImage);

            }
            //Bitmap maskOut = image.ToBitmap();
            

            return faces;
            
        }
        public static void ClearMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }




        public static Bitmap ResizeImage(Image image, Size size)
        {
            // Create a new Bitmap with the desired width and height
            Bitmap resizedImage = new Bitmap(size.Width, size.Height);

            // Create a Graphics object from the resized image
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                graphics.SmoothingMode = SmoothingMode.None;
                graphics.PixelOffsetMode = PixelOffsetMode.None;

                // Draw the original image onto the resized image
                graphics.DrawImage(image, 0, 0, size.Width, size.Height);
            }

            return resizedImage;
        }

        public static bool IsValidURL(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out Uri result)
                && (result.Scheme == Uri.UriSchemeHttp || result.Scheme == Uri.UriSchemeHttps);
        }

        public static async Task<Bitmap> LoadImageAsync(string filePath)
        {
            return await Task.Run(() =>
            {
                // Load the image synchronously
                Bitmap image = new Bitmap(filePath);

                // Return the loaded image
                return image;
            });
        }
    }
}
