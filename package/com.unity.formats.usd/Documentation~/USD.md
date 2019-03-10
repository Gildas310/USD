# USD Unity SDK: USD C# Bindings for Unity

This repository contains a set of libraries designed to support the use of
USD in C#/Unity. The goal of this package is to make it maximally easy to
integrate and explore Universal Scene Description.

![USD screenshot](Images/USD_global_screenshot.png)


# Getting Started

To get started, install USD via the Unity Package manager, either by using
an official repository, or by browsing for a local package while working with
source.

Once the USD package is installed, a USD menu will appear, enabling you to
easily import and export USD files.

![USD menu](Images/USD_menu.png)


## Requirements

* Windows / OSX
* Unity version: 2018.3 (2018.3.4f1 and up) and 2019.1 (2019.1.0b2 and up)   
See ["2017 users" section](#2017-users) if you want to use the plugin in Unity 2017.4
* To build a standalone, Api Compatibility Level needs to be set to .NET 4.x   
   In Edit > Project Settings > Player :   
    ![USD .NET version](Images/USD_.NET_version.png)

## Samples

Unity USD package also includes samples to help getting up to speed.
Please note, the way to get them varies depending on the Unity version you are using. See below.

### Unity 2019.1 and above

Use Package Manager to import the samples into your Assets folder :

![USD .NET version](Images/USD_samples_import.png)

### Previous versions

Samples package can be downloaded from [Unity film-tv-toolbox repository](https://github.com/Unity-Technologies/film-tv-toolbox/tree/master/UsdSamples).

# Features

The following is a brief listing of currently supported features:

 * Import as GameObject, Prefab, or Timeline Clip
 * USDZ Export
 * Transform Override Export
 * Timeline Playback (Vertex Streaming & Skeletal Animation)
 * Timeline Recording Track
 * Mesh Import & Export
 * Material Import & Export (USD Preview Surface or DisplayColor)
 * Unity Materials: HDRP, Standard and limited LWRP support
 * Material Export Plugins
 * Variant Selection
 * Payload Load/Unload
 * Automatic Lightmap UV Unwrapping
 * Skeletal Animation via UsdSkel
 * Scene Instancing
 * Point Instancing
 * Integration with C# Job System
 * High and Low Level Access to USD API via C#

## Importing Materials

To import materials from USD, import the USD file using the USD menu. Next, click
on the root GameObject and select either DisplayColor or Preview Surface from the
materials dropdown menu.

## Streaming Playback via Timeline

After importing a USD file with either skeletal or point cache animation, open
the Timeline window. Select the root of the USD file.

Create a playable director by clicking the "Create" button in the Timeline window.
Next, drag the root USD file into the Timeline to create a track for this object.
Finally, drag the USD file once more to add a USD clip to the track for plaback.
Scrubbing through time will now update the USD scene by streaming dat from USD.

Timeline playback is multi-threaded using the C# Job System.

# 2017 users

The official package is not compatible with 2017.4 but a separate branch is maintained to allow 2017 users to benefit from the last developments.

Here's how to install the plugin from this branch :
 * Checkout [2017.4 branch](https://github.com/Unity-Technologies/usd-unity-sdk/tree/2017.4) from the github repository
 * Copy UsdUnitySdk in your Assets folder
 * Do not rename this folder