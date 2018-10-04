![Screenshot](https://static1.squarespace.com/static/5a680d68fe54ef42d1f5f060/t/5acdcb4c70a6adb35386e98a/1523436792308/pprc.gif)

After playing Celeste I was inspired to play around with something similar in Unity. It seems no one has made a pixel perfect retro camera yet so I decided to create this super simple system for rendering your Unity game at a reference resolution such as 320x180 and also retaining pixel perfect movement with no shimmering whilst also supporting other aspect ratios.

Simply drag the camera prefab into your scene or add the PixelCamera component to your main camera, all image effects are supported but may be processed at native resolution before downscaling.

Highly Recommended: If you wish to add pixel perfect movement to your existing camera alongside the rendering then add a SnapToPixel component to your camera's parent GameObject.

Use a perfect multiple of your target resolution as your reference resolution for best results.
