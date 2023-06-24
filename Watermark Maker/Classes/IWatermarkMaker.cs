using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watermark_Maker.Classes
{
    public interface IWatermarkMaker
    {

        public bool LoadImage(string filename);
        public bool SaveImage(string filename);
        public bool AddWatermark(string watermark);
        public bool SetPosition(WatermarkPosition position);
        public string GetFilename();
        public bool Reset();
    }
}
