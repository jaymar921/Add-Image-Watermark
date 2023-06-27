using JayMar.WatermarkAppender.Classes;

namespace JayMar.WatermarkAppender.Provider
{
    public interface IWatermarkProvider
    {
        /// <summary>
        /// Loads images from a Path, example: C:\LotsOfImagesFolder\
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool LoadImages(string path);
        /// <summary>
        /// Loads the watermark from Path, example: C:\watermark.jpg
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool LoadWatermark(string path);
        /// <summary>
        /// Sets the position of the watermark into an image
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool SetPosition(WatermarkPosition position);
        /// <summary>
        /// Saves all the watermarked images in a Path, example: C:\SaveFolder\
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool SavePath(string path);
        /// <summary>
        /// Loads and Save the watermarked images at the same time, call this method when more than 300 images are processed
        /// </summary>
        /// <param name="loadPath"></param>
        /// <param name="savePath"></param>
        /// <param name="watermarkPath"></param>
        /// <param name="watermarkScale"></param>
        /// <returns></returns>
        public bool LoadAndSave(string loadPath, string savePath, string watermarkPath, double watermarkScale = 1.0);
        public bool Reset();
    }
}
