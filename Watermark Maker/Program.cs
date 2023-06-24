﻿using Watermark_Maker.Classes;
using Watermark_Maker.Decorator;
using Watermark_Maker.Provider;

namespace Watermark_Maker
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Doing on one file
             * 
            
            IWatermarkMaker watermarkMaker = new WatermarkMaker();
            watermarkMaker.LoadImage("C:\\Users\\jayha\\OneDrive\\Desktop\\noWatermark\\IMG_0899.JPG");
            watermarkMaker.AddWatermark("C:\\Users\\jayha\\OneDrive\\Desktop\\watermark.png");
            watermarkMaker.SaveImage("C:\\Users\\jayha\\OneDrive\\Desktop\\withWatermark\\IMG_0899.JPG");
            
            */

            // doing multiple files
            IWatermarkProvider provider = new WatermarkProvider();                           // creates the watermark provider
            IWatermarkProviderLogger providerLogger = new WatermarkProviderLogger(provider); // use this decorator for logging

            // load the images based on file Path
            providerLogger.LoadImages("D:\\PathToNoWatermarkImages");

            // load the watermark based on file Path + filename
            providerLogger.LoadWatermark("D:\\myWatermark.png");

            // set the position of the watermark
            providerLogger.SetPosition(WatermarkPosition.CENTER);

            // save the images based on file Path
            providerLogger.SavePath("D:\\PathToSaveWatermarkedImages");
        }
    }
}