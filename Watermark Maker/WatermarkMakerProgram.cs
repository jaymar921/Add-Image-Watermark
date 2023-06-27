using Watermark_Maker.Classes;
using Watermark_Maker.Decorator;
using Watermark_Maker.Provider;

namespace Watermark_Maker
{
    public class WatermarkMakerProgram
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Doing on one file
             * 
            
            IWatermarkMaker watermarkMaker = new WatermarkMaker();
            watermarkMaker.LoadImage("D:\\PathToNoWatermarkImages");
            watermarkMaker.AddWatermark("D:\\myWatermark.png");
            watermarkMaker.SaveImage("D:\\PathToSaveWatermarkedImages");
            
            */

            // doing multiple files
            IWatermarkProvider provider = new WatermarkProvider();                           // creates the watermark provider
            IWatermarkProviderLogger providerLogger = new WatermarkProviderLogger(provider); // use this decorator for logging

            
            // load the images based on file Path
            providerLogger.LoadImages("D:\\PathToNoWatermarkImages");

            // load the watermark based on file Path + filename
            providerLogger.LoadWatermark("D:\\myWatermark.png");

            // set the position of the watermark
            providerLogger.SetPosition(WatermarkPosition.BOTTOM_LEFT);

            // save the images based on file Path
            providerLogger.SavePath("D:\\PathToSaveWatermarkedImages");

            // loading and saving images at a the same time, scaling feature is included
            providerLogger.LoadAndSave("D:\\PathToNoWatermarkImages", "D:\\PathToSaveWatermarkedImages", "D:\\myWatermark.png", 1.0);
        }
    }
}