using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayMar.WatermarkAppender.Classes
{
    public interface IWatermarkMaker
    {
        /// <summary>
        /// Loads an image file that accepts the filepath : Example -> C:\\image.jpg
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool LoadImage(string filename);
        /// <summary>
        /// Saves a watermarked image to the filepath : Example -> C:\\image.jpg
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool SaveImage(string filename);
        /// <summary>
        /// Loads a watermark image from the filepath : Example -> C:\\watermark.jpg
        /// </summary>
        /// <param name="watermark"></param>
        /// <returns></returns>
        public bool AddWatermark(string watermark);
        /// <summary>
        /// Change the display position of the watermark into an image
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool SetPosition(WatermarkPosition position);

        /// <summary>
        /// ScaleWatermark accepts double value, 1.0 is the default value, putting -0.5 represents -50% scale
        /// </summary>
        /// <param name="percentage"></param>
        public void ScaleWatermark(double percentage);
        /// <summary>
        /// Returns a filename
        /// </summary>
        /// <returns></returns>
        public string GetFilename();
        public bool Reset();
    }
}
