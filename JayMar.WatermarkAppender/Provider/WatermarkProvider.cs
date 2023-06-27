using JayMar.WatermarkAppender.Classes;

namespace JayMar.WatermarkAppender.Provider
{
    public class WatermarkProvider : IWatermarkProvider
    {
        private List<IWatermarkMaker> watermarkMakers;

        public WatermarkProvider()
        {
            watermarkMakers = new List<IWatermarkMaker>();
        }

        public bool LoadAndSave(string loadPath, string savePath, string watermarkPath, double watermarkScale = 1.0)
        {
            string[]? filePath = null;
            try
            {
                filePath = Directory.GetFiles(loadPath);
            }
            catch
            {
                Console.WriteLine($"ERROR: Directory '{loadPath}' does not exist");
            }
            if (filePath == null)
                return false;

            foreach (var files in filePath)
            {
                var fileSplit = files.Split(new char[] {'\\','/'});
                var fileName = fileSplit[fileSplit.Length - 1];

                IWatermarkMaker watermarkMaker = new WatermarkMaker();
                watermarkMaker.LoadImage(files);
                watermarkMaker.AddWatermark(watermarkPath);
                watermarkMaker.ScaleWatermark(watermarkScale);
                watermarkMaker.SaveImage(savePath + "\\" + fileName);
                watermarkMaker.Reset();
            }

            return true;
        }

        public bool LoadImages(string path)
        {
            string[]? filePath = null;
            try
            {
                filePath = Directory.GetFiles(path);
            }
            catch
            {
                Console.WriteLine($"ERROR: Directory '{path}' does not exist");
            }
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
