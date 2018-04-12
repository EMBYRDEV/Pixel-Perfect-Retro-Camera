After playing Celeste I was inspired to play around with something similar in
Unity. It seems no one has made a pixel perfect retro camera yet so I decided
to create this super simple system for rendering your Unity game at a reference
resolution such as 320x180 and also retaining pixel perfect movement with no 
shimmering whilst also supporting other aspect ratios.

Simply drag the camera prefab into your scene or add the PixelCamera component
to your main camera, all image effects are supported but may be processed at 
native resolution before downscaling. 

Highly Recommended: If you wish to add pixel perfect movement to your existing 
camera alongside the rendering then add a SnapToPixel component to your camera's 
parent GameObject.

Known Issues: 
To prevent shimmering required that we add a 1px border to the render image to 
account for a possible fraction of a pixel overlap. This can't be fixed however 
I do enjoy the aesthetic it creates.

Contact: hannah@wolv.co

GitHub: https://github.com/wolv-interactive/Pixel-Perfect-Retro-Camera

---------------------------------- Licence ----------------------------------

This is free and unencumbered software released into the public domain.

Anyone is free to copy, modify, publish, use, compile, sell, or
distribute this software, either in source code form or as a compiled
binary, for any purpose, commercial or non-commercial, and by any
means.

In jurisdictions that recognize copyright laws, the author or authors
of this software dedicate any and all copyright interest in the
software to the public domain. We make this dedication for the benefit
of the public at large and to the detriment of our heirs and
successors. We intend this dedication to be an overt act of
relinquishment in perpetuity of all present and future rights to this
software under copyright law.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR
OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
OTHER DEALINGS IN THE SOFTWARE.

For more information, please refer to <http://unlicense.org/>

-----------------------------------------------------------------------------

Demo assets are not distrubted under this licence.

Knight Sprites by Warren Clark
Provided free on itch.io. 
https://lionheart963.itch.io/knight-sprite

Caverns Environment by ansimuz
Provided under CC4 Licence on itch.io
https://ansimuz.itch.io/caverns-environment