using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watermark_Maker.Classes;
using Watermark_Maker.Provider;

namespace Watermark_Maker.Decorator
{
    public class WatermarkProviderLogger : IWatermarkProviderLogger
    {
        private readonly IWatermarkProvider provider;
        public WatermarkProviderLogger(IWatermarkProvider provider) 
        {
            this.provider = provider;
        }
        public bool LoadImages(string path)
        {
            Console.WriteLine($"Loading Images in '{path}'");
            bool res = provider.LoadImages(path);

            if (!res)
                Console.WriteLine($"Failed to load Images in '{path}'");
            else Console.WriteLine($"Images are loaded...");
            return res;
        }

        public bool LoadWatermark(string path)
        {
            Console.WriteLine("Loading the watermark");
            bool res = provider.LoadWatermark(path);

            if (!res)
                Console.WriteLine("Failed to load watermark");
            else Console.WriteLine("Watermark loaded");
            return res;
        }

        public bool Reset()
        {
            Console.WriteLine("Watermark Provider reset");
            return provider.Reset();
        }

        public bool SavePath(string path)
        {
            Console.WriteLine($"Saving Watermarked images at {path}");
            bool res = provider.SavePath(path);

            if (!res)
                Console.WriteLine("Failed to save watermarked images");
            else Console.WriteLine($"Saved watermarked images at\n{path}");
            return res;
        }

        public bool SetPosition(WatermarkPosition position)
        {
            Console.WriteLine($"Setting watermark position : {position}");
            return provider.SetPosition(position);
        }
    }
}
