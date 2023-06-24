using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watermark_Maker.Classes
{
    public class WatermarkMaker : IWatermarkMaker
    {
        private Image? image;
        private Image? watermark;
        public string filename;
        private WatermarkPosition position = WatermarkPosition.BOTTOM_LEFT;
        public WatermarkMaker(string filename, string watermark)
        {
            LoadImage(filename);
            AddWatermark(watermark);
            this.filename = filename;
        }

        public WatermarkMaker() 
        {
            image = null;
            watermark = null;
            filename = String.Empty;
        }
        public bool AddWatermark(string watermarkFilePath)
        {
            try
            {
                watermark = Image.FromFile(watermarkFilePath);
            }
            catch
            {
                Console.WriteLine($"ERROR: File does not exist or file path does not exist while trying to load {watermarkFilePath}");
            }
            
            return watermark != null;
        }

        public bool LoadImage(string filename)
        {
            try
            {
                image = Image.FromFile(filename);
            }catch
            {
                Console.WriteLine($"ERROR: File does not exist or file path does not exist white trying to load {filename}");
            }
            var fileSplit = filename.Split(new char[] { '\\', '/' });
            var fileName = fileSplit[fileSplit.Length - 1];
            this.filename = fileName;
            return image != null;
        }

        public bool Reset()
        {
            image = null; 
            return true;
        }

        public bool SaveImage(string filename)
        {
            if (image == null)
                return false;
            if (watermark == null)
                return false;
            using(Graphics g = Graphics.FromImage(image))
            {
                int x = GetX();
                int y = GetY();
                g.DrawImage(watermark, x, y, watermark.Width, watermark.Height);

                try
                {
                    image.Save(filename);
                }catch
                {
                    Console.WriteLine("ERROR: An Error has occured, there might be no directory exist");
                    return false;
                }
                return true;
            }
        }

        private int GetX()
        {
            switch (position)
            {
                case WatermarkPosition.CENTER:
                    return ((image.Width - watermark.Width) / 2);
                case WatermarkPosition.BOTTOM_LEFT:
                case WatermarkPosition.TOP_LEFT:
                    return ((image.Width - watermark.Width) / 20);
                case WatermarkPosition.BOTTOM_RIGHT:
                case WatermarkPosition.TOP_RIGHT:
                    return ((image.Width - watermark.Width));
                default:
                    return 0;
            }
        }

        private int GetY()
        {
            switch (position)
            {
                case WatermarkPosition.CENTER:
                    return ((image.Height - watermark.Height) / 2);
                case WatermarkPosition.TOP_RIGHT:
                case WatermarkPosition.TOP_LEFT:
                    return ((image.Height - watermark.Height) / 1000);
                case WatermarkPosition.BOTTOM_RIGHT:
                case WatermarkPosition.BOTTOM_LEFT:
                    return ((image.Height - watermark.Height));
                default:
                    return 0;
            }
        }

        public string GetFilename()
        {
            return filename;
        }

        public bool SetPosition(WatermarkPosition position)
        {
            this.position = position;
            return true;
        }
    }
}
