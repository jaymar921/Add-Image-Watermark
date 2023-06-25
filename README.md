# Watermark Appender
> By [Jayharron Mar Abejar](https://jayharronabejar.info)

This is basically a simple C# program that will add your desired watermark in all images you've provided in a file path.

## How to use:
```c#
// creates the watermark provider
IWatermarkProvider provider = new WatermarkProvider(); 

// use this decorator for logging [optional]
IWatermarkProviderLogger providerLogger = new WatermarkProviderLogger(provider);

// load the images based on file Path
providerLogger.LoadImages("D:\\PathToNoWatermarkImages");

// load the watermark based on file Path + filename
providerLogger.LoadWatermark("D:\\myWatermark.png");

// set the position of the watermark
providerLogger.SetPosition(WatermarkPosition.CENTER);

// save the images based on file Path
providerLogger.SaveP("D:\\PathToSaveWatermarkedImages");

// if you want to LoadAndSave faster, use the provider.LoadAndSave method
// params: string:pathToNoWaterMarkImages, string:pathToSaveWatermarkedImages, string:watermarkFilepath
provider.LoadAndSave("D:\\PathToNoWatermarkImages", "D:\\PathToSaveWatermarkedImages", "D:\\myWatermark.png");
```




<div>
<p align="center">
    <span style="color:orange;font-weight:700;font-size:20px;">
        Sample watermark
    </span>
</p>
<p align="center">
    <img src='Watermark%20Maker/Images/watermark/myWatermark.png' width='200px'>
</p>
<p align="center">Here is an example watermark that I want to add into an image</p>
<br />
<br />
<br />
<p align="center">
    <span style="color:orange;font-weight:700;font-size:20px;">
        Sample output
    </span>
</p>
<p align="center"><img src='Watermark%20Maker/Images/noWatermark/sampleImageCCTO.jpg' width='300px'></p>
<p align="center">Sample image without watermark</p>

<p align="center"><img src='Watermark%20Maker/Images/withWatermark/sampleImageCCTO.jpg' width='300px'></p>
<p align="center">Sample image with watermark added</p>
</div>
