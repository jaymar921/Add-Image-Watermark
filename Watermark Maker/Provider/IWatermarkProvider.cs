using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watermark_Maker.Classes;

namespace Watermark_Maker.Provider
{
    public interface IWatermarkProvider
    {
        public bool LoadImages(string path);
        public bool LoadWatermark(string path);
        public bool SetPosition(WatermarkPosition position);
        public bool SavePath(string path);
        public bool Reset();
    }
}
