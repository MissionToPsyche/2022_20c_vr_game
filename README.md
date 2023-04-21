# 2022_20c_vr_game

-- Far Flung VR --

Fall 2022 - Spring 2023 ASU capstone project
Sponsor: NASA Psyche
Development: ASU VR Space Team 20C - Silver Class: 

Antonio Moreno, 
Magali Lopez,
Pravesh Karki,
Yousuf Khoori,
Ahmad El Rayes,
Wilfredo Gumaru

# Description:
This is a virtual reality game developed with Unity game engine to be played on Oculus/Meta Quest devices (I and II).
The game is inspired by the existing game from the NASA Psyche's website "Far Flung!" and uses many of the assets from that game.

Original Far Flung! Github link: https://github.com/MissionToPsyche/2021_20G_Web-Based-Game_Far-Flung

# To Play the Game:
Before anything you will need:
- A Quest headset
- A USB-C to USB-_ cable (the Quest has a USB-C connection and your computer may have any USB connection)
- A Meta/Oculus/Facebook account
- Have your headset on Developer Mode

This is all in an effort to load a 3rd party .apk file onto your headset, which will show up as an app of an "unknouwn source". 
If you're familiar with loading custom beat maps in Beatsaber, it's pretty similar.

There are then 2 methods for loading the game onto your headset:

## Method 1: Sidequest (recommended)
In-depth video: https://www.youtube.com/watch?v=lFTXv2aScJ8

General Steps:
1) Download the apk file. If you don't already have it, it's saved on this repository. So you can clone the "vr-setup" branch of this repo, and find the latest apk in the "Builds" folder
2) On your computer, install Sidequest (drivers no longer necessary). Link: https://sidequestvr.com/setup-howto
3) Within your headset after connecting it to your computer with a cable, a prompt will show up on startup of the headset saying "Allow access to data". Choose allow. (They do not need to be on the same Wi-Fi)
4) Open Sidequest on your computer and on the top right corner you should see an icon of a box with a down arrow on it. Click it and select your apk. In order for this to work, the top left of Sidequest must display a green dot, meaning it has detected your headset.
5) After installation is complete, go into your headset -> navigate to your app library (the 9 dots button) -> click the top right button, right of the search icon -> then click the top right dropdown menu and select "Unknown Sources" -> you should see the game "Far Flung VR" for play

## Method 2: Build and run directly
Recommended software: Github desktop, Unity hub

General Steps:
1) Download the Github repository and switch branches to "vr-setup"
2) Download Unity hub (if not already installed) and add the Unity project from the downloaded repo. NOTE: The Unity project is saved 1 directory below the Github. The Unity project is NOT the folder "2022_20c_vr_game", it's in the folder "Fall2022Capstone" which is the 1 you add to Unity Hub.
3) Install the Unity editor the project is running on WITH Android build support. On the Projects tab of Unity Hub, you should see an orange triangle warning symbol indicating you don't have the exact Unity editor for the "Fall2022Capstone" project. Clicking on it should install it but make sure to toggle the Android build support AND the support packages already toggled with it. You can also install the build support later through "Installs" tab on Unity hub later. On the specific editor version just click the 3 dots in the corner and add modules.
4) Launch the project through Unity hub, and on the top left go to File -> Build Settings -> add Open Scenes -> then click Android below (should trigger some loading) -> toggle off "Development Build" if on -> then while your headset is connected to your computer with allowed access: Build and run -> save the apk file anywhere, ideally outside the project files -> the game should then install directly to your headset and will be run immediately. 
5) The game should be permanently stored in the headset. If you quit the game and want to see it again just go into your headset -> navigate to your app library (the 9 dots button) -> click the top right button, right of the search icon -> then click the top right dropdown menu and select "Unknown Sources" -> you should see the game "Far Flung VR" for play


# Disclaimer
This work was created in partial fulfillment of ASU Capstone Course CSE486 and IEE486. The work is a result of the Psyche Student Collaborations component of NASA’s Psyche Mission (https://psyche.asu.edu). “Psyche: A Journey to a Metal World” [Contract number NNM16AA09C] is part of the NASA Discovery Program mission to solar system targets. Trade names and trademarks of ASU and NASA are used in this work for identification only. Their usage does not constitute an official endorsement, either expressed or implied, by Arizona State University or National Aeronautics and Space Administration. The content is solely the responsibility of the authors and does not necessarily represent the official views of ASU or NASA.
