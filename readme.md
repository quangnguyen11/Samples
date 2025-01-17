# ChilliConnect Sample Code

This repository contains Sample projects for ChilliConnect.

## Unity

The `UnitySamples`directory contains separate Unity projects for each sample.

### CreatePlayer

The CreatePlayerDemoScene uses the Game Jam Menu Template from the Asset store to create a basic test scene that shows creation of a new ChilliConnect player, logging in and persisting the ChilliConnect credentials using Unity `PlayerPrefs`. The `StartOptions` class contains the integration with the ChilliConnect SDK. To run this project under your own ChilliConnect account, change the `GAME_TOKEN` constant.

### Teams

The Teams scene is the accompanying demo project for the ChilliConnect [Teams tutorial](https://docs.chilliconnect.com/guide/tutorial-teams). The project will create and save an anonymous player account and then provide a UI for listing, creating, joining and leave teams. To run this project under your own ChilliConnect account, change the `GAME_TOKEN` constant in `TeamsDemoSceneController.cs`

### FBLeaderboard

The FBLeaderboardDemoScene uses the Facebook SDK to show how to implementation Facebook integration with ChilliConnect, allowing players to link their ChilliConnect account with a Facebook account and then sign in using Facebook. This project also shows how to retrieve leaderboard scores for Facebook friends.

### CharacterGacha

The Gacha sample project accompanies the ChilliConnect [Gacha and A/B Testing Tutorial](https://docs.chilliconnect.com/guide/tutorial-gacha) and shows how create and A/B Test a simple gacha style spawning system in ChilliConnect.

### TicTacToe

An asynchronous multiplayer game that uses Collection Data to save and search for matches. See the [Asynchronous Multiplayer Tutorial](https://docs.chilliconnect.com/guide/tutorial-async-multiplayer/) on the ChilliConnect docs site for a full write up. To run this project under your own ChilliConnect account, change the `GAME_TOKEN` constant in `SceneController.cs`

### IAP

The IAPDemoScene accompanies the ChilliConnect [IAP tutorial](https://docs.chilliconnect.com/tutorial-iaps) and contains an end-to-end example of integrating the Unity IAP Plugin with ChilliConnect to securely verify and redeem player purchases. 

*To run this project under your own account, you must enable the Unity IAP Plugin from the Services menu and configure the plugin with your own Google Play and App Store settings.* Full instructions are available on the [Unity website](https://unity3d.com/learn/tutorials/topics/analytics/integrating-unity-iap-your-game). You must also supply your own ChilliConnect Game Token in `IAPDemoSceneController.cs`.

## Objective-C

The `Objective-CSamples` directory contains XCode projects samples that use the iOS SDK.

### PlayerMessaging 

A XCode project that shows how to integrate the Player Messaging feature with Facebook to enable players to send currency to their friends. This code accompanies the [Player Message Tutorial](https://docs.chilliconnect.com/tutorial-messaging.md).

## Unreal

The `UnrealSamples`directory contains separate Unreal Engine projects for each sample.

### ChilliConnectExample

ChilliConnectExample is a standalone project that shows how the built in Http and Json libraries provided by Unreal can be used to invoke the ChilliConnect API directly. To run the sample, add your own Game Token to the `ChilliConnect.cpp` file.


## C++

The `CppSamples` directory contains a Visual Studio 2015 project showing a basic integration with ChilliConnect using WinHTTP and JsonCpp. <strong>Note that the example Http class is for an example only, uses a blocking API and is not intended for production usage.</strong>