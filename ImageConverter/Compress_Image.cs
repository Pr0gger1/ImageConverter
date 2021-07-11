using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ImageEditor
{
    public class Jpeg_Compression
    {
        protected static ImageCodecInfo GetEncoderInfo(string mime_type)
        {
            ImageCodecInfo[] encoders = ImageCodecInfo.GetImageEncoders();
            for (int i = 0; i <= encoders.Length; i++)
            {
                if (encoders[i].MimeType == mime_type) return encoders[i];
            }
            return null;
        }
        public static void Compress(string filename, string saveToDir , int quality)
        {
            int com_ratio = 100 - quality;

            using (Bitmap img = new Bitmap(filename))
            {
                EncoderParameters EncoderImage = new EncoderParameters()
                {
                    Param = new EncoderParameter[]
                    {
                        new EncoderParameter(Encoder.Quality, 100L - com_ratio)
                    }
                };
                img.Save(
                    Path.ChangeExtension(saveToDir, "").Trim('.') + $"_compressed.jpg",
                    ImageCodecInfo.GetImageEncoders()[1],
                    EncoderImage);
            }
        }
    }

    public class DirJpegCompression : Jpeg_Compression
    {
        public static Bitmap LoadBitmap(string file_name)
        {
            Bitmap result;
            using (Bitmap bm = new Bitmap(file_name))
            {
                result = new Bitmap(bm.Width, bm.Height);
                using (Graphics gr = Graphics.FromImage(result))
                {
                    Rectangle rect = new Rectangle(0, 0, bm.Width, bm.Height);
                    gr.DrawImage(bm, rect, rect, GraphicsUnit.Pixel);
                }
            }
            return result;
        }

        public static void SaveJpg(Image image, string save_to, int level)
        {
            try
            {
                int quality = 100 - level;
                EncoderParameters encoder_params = new EncoderParameters(1);
                encoder_params.Param[0] = new EncoderParameter(
                    Encoder.Quality, level);

                ImageCodecInfo image_codec_info = GetEncoderInfo("image/jpeg");
                image.Save(save_to, image_codec_info, encoder_params);
            }
            catch
            {

            }
        }
        //public static void CompressDirJpg(Image img, string save_to_dir, int quality)
        //{
        //    int com_ratio = 100 - quality;
        //    try
        //    {
        //        EncoderParameters encoder_params = new EncoderParameters(1);
        //        encoder_params.Param[0] = new EncoderParameter(Encoder.Quality, 100L - com_ratio);
        //        ImageCodecInfo img_codec_info = GetEncoderInfo("image/jpeg");
        //        img.Save(save_to_dir, img_codec_info, encoder_params);

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
