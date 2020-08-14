# AR-Screen-Pixel-Sampler
Allows us to sample color of the screen pixel and store it locally on a raw image. After that it can be used to recolor other objects in the AR scene. 

## How To Use:
1. Clone/download the project
2. Open in Unity 2019.4 or later
3. Build the scene title "ARScene" on an ARCore compatible device 

## Reference:
https://github.com/programmercert/ScreenPointPixel

## What's New:
1. The eye dropper image UI included which indicates which screen pixel is selected.
2. Screen pixels over all UI elements are ignored for selection.
3. Use the selected color to adjust the material on a separate mesh renderer. In this case, a free Mario asset with Skinned Mesh Renderer is used. 
4. Option to restore the original material colors for all modified mesh renderers. 
