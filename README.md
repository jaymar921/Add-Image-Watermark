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

// if you want to LoadAndSave faster with watermark scaling feature, use the LoadAndSave method
// params: string:pathToNoWaterMarkImages, string:pathToSaveWatermarkedImages, string:watermarkFilepath, double:scale
providerLogger.LoadAndSave("D:\\PathToNoWatermarkImages", "D:\\PathToSaveWatermarkedImages", "D:\\myWatermark.png", 1.0);
```


<p align="center">
    <span style="color:orange;font-weight:700;font-size:20px;">
        <img src="https://www.nuget.org/Content/gallery/img/logo-header.svg" width='200'>
    </span>
    <br/>
    <a style="color:greenyellow;text-decoration:underline;" href="https://www.nuget.org/packages/JayMar.WatermarkAppender/1.0.0">JayMar.WatermarkAppender</a>
</p>

```cmd
.NET CLI
> dotnet add package JayMar.WatermarkAppender --version 1.0.0

Package Manager
PM> NuGet\Install-Package JayMar.WatermarkAppender -Version 1.0.0

Package Reference
<PackageReference Include="JayMar.WatermarkAppender" Version="1.0.0" />

Paket CLI
> paket add JayMar.WatermarkAppender --version 1.0.0

Script & Interactive
> #r "nuget: JayMar.WatermarkAppender, 1.0.0"

Cake
// Install JayMar.WatermarkAppender as a Cake Addin
#addin nuget:?package=JayMar.WatermarkAppender&version=1.0.0

// Install JayMar.WatermarkAppender as a Cake Tool
#tool nuget:?package=JayMar.WatermarkAppender&version=1.0.0
```



<div>
<br/><br/><br/>
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




