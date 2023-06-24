using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watermark_Maker.Classes;

namespace Watermark_Maker.Provider
{
    public class WatermarkProvider : IWatermarkProvider
    {
        private List<IWatermarkMaker> watermarkMakers;

        public WatermarkProvider()
        {
            watermarkMakers = new List<IWatermarkMaker>();
        }
        public bool LoadImages(string path)
        {
            var filePath = Directory.GetFiles(path);
            if (filePath == null)
                return false;

            foreach(var files in filePath)
            {
                //var fileSplit = files.Split(new char[] {'\\','/'});
                //var fileName = fileSplit[fileSplit.Length - 1];

                IWatermarkMaker watermarkMaker = new WatermarkMaker();
                watermarkMaker.LoadImage(files);

                watermarkMakers.Add(watermarkMaker);
            }

            return true;
        }

        public bool LoadWatermark(string fileName)
        {
            foreach(IWatermarkMaker watermarkMaker in watermarkMakers)
            {
                if (!watermarkMaker.AddWatermark(fileName))
                    return false;
            }

            return true;
        }

        public bool Reset()
        {
            watermarkMakers = new List<IWatermarkMaker>();
            return true;
        }

        public bool SavePath(string path)
        {
            foreach(IWatermarkMaker watermarkMaker in watermarkMakers)
            {
                if (!watermarkMaker.SaveImage(path + $"\\{watermarkMaker.GetFilename()}"))
                    return false;
            }
            return true;
        }

        public bool SetPosition(WatermarkPosition position)
        {
            foreach(IWatermarkMaker watermarkMaker in watermarkMakers)
                watermarkMaker.SetPosition(position);
            return true;
        }
    }
}
