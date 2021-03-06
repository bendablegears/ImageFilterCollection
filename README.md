# Image Filter Collection
Collection of Image Filters for PixelArt resizing. [(HQ, XBR, etc)](https://en.wikipedia.org/wiki/Pixel-art_scaling_algorithms)
based on the 2dImageFilter by Hawkynt: https://github.com/Hawkynt/2dimagefilter

Most likely i made a new gui (WPF) and added the option to use the clipboard as source for the images, and a wrapper to use the filters in any NetStandart2.0 environemt.

It supports PNG files and clipboard with alpha channel

![Screenshot](Docs/Screenshots/screenie.png)

# Installation (Windows binaries)
Just download the latest windows binaries [Here](https://github.com/Salmakis/ImageFilterCollection/releases/latest).

Unpack the contents of the zip archive somewhere and start ImageFilter.exe (no installation needed)
You might need some .net runtime stuff if you are not using Windows 10.
note: The windows defender does not like this tool for any reason, i dont know why. (and dont care)

# Usage
Its easy, in the top left corner you can provide an image (paste from the clipboard) or load from a PNG file.
Pasting from clipboard has ben tested with Gimp & Paint.Net

Pick a filte in the middle and adjust the settings for it and click on "Convert"

You can save the result to a PNG file or copy the result into the Clipboard on the right side.

## Tiledmode
With the Tilemode enabled, each tile of a given tileset image will be processed for itself and then it will be reassembled to an image.
This way you can prevent that the tiles affect each other.
You can use the checkbox Tiledmode, if you activate it you need to enter the tilesize into the textboxes below the checkbox.
Type the size of the tiles from the input image
![Screenshot](Docs/Screenshots/tiledmode.png)

# Projects in the Solution
## FilterWrapper (.NetStandard 2.0)
This Project contains a wrapper for the filters that wraps them into an interface that can than be used by other programms that can be .net4 or netCore.
Also a manager that reflects with an Interface and provides a settings system for the filters (they may have individual settings)
It also contains some code from [Hawkynt](https://github.com/Hawkynt) 2dImageFilter (the implementation of some filters) just changed a bit to be NetStandard 2.0 compatible.

## ImageFilter (Wpf application)
a gui app that can make use of all the filters that are Implemented with FilterWrapper.

## Make your own Filter
To add your filter, all you need is to Implement the IImageFilter interface, or copy and modify other IImageFilter implementations.
They will automaticly added to the Collection via Reflection.

## Others
There are also 2 console Projects, they was just to test some stuff.

## What i want to do next
+ a web version that uses the FilterWrapper project (.netCore ASP or maybe for Piranha CMS)
