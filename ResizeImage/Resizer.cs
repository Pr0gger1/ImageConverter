using System;
using System.Drawing;

namespace ImageEdit
{
    public class Resizer
    {
        public static Image Change_Size_Img(Image imgToResize, Size size)
        {
            //Get width and height original image
            int origWidth = imgToResize.Width;
            int origHeight = imgToResize.Height;

            //Calculate new resolution
            float nPercent;
            float nPercentW = size.Width / (float)origWidth;
            float nPercentH = size.Height / (float)origHeight;

            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
            }
            else
            {
                nPercent = nPercentW;
            }

            int outWidth = (int)(origWidth * nPercent);
            int outHeight = (int)(origHeight * nPercent);
            Bitmap bmp = new Bitmap(outWidth, outHeight);
            Graphics graph = Graphics.FromImage((Image)bmp);

            graph.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graph.DrawImage(imgToResize, 0, 0, outWidth, outHeight);
            graph.Dispose();

            return (Image)bmp;
        }
    }
}
