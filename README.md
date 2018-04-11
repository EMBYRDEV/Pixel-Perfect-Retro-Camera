![](https://thumbs.gfycat.com/BraveEnchantedKittiwake-max-14mb.gif)

After playing Celeste I was inspired to play around with something similar in Unity. It seems no one has made a pixel perfect retro camera yet so I decided to create this super simple system for rendering your Unity game at a reference resolution such as 320x180 and also retaining pixel perfect movement with no shimmering whilst also supporting other aspect ratios.

Simply drag the camera prefab into your scene or add the PixelCamera component to your main camera, all image effects are supported but may be processed at native resolution before downscaling. If you wish to add pixel perfect movement to your existing camera alongside the rendering then add a SnapToPixel component to your camera's parent GameObject.

Known Issues: 
There is a but that leads to me adding 1px black bars to the screen to prevent shimmering with some common resolutions. It's explained further in PixelCamera.cs but I think it looks rather nice.
