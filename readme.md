# GamingController
 
GamingController presents the IGamingController interface to the .NET framework for Xbox, Playstation, and Generic Controller device support.

## Playstation Controller
```C#
  using NolanHodge.GamingController;
  
  PlaystationController Controller = new PlaystationController();
  
  Controller.Connected += (s,e) => { HandleConnectedAsync(); };
  Controller.Disconnected += (s,e) => { HandleDisconnectedAsync();  };
  Controller.Refresh();
```

## Xbox Controller
```C#
  using NolanHodge.GamingController;
  
  XboxController Controller = new XboxController();
  
  Controller.Connected += (s,e) => { HandleConnectedAsync(); };
  Controller.Disconnected += (s,e) => { HandleDisconnectedAsync();  };
  Controller.Refresh();
```

## Generic Controller
```C#
  using NolanHodge.GamingController;
  
  GenericController Controller = new GenericController();
  
  Controller.Connected += (s,e) => { HandleConnectedAsync(); };
  Controller.Disconnected += (s,e) => { HandleDisconnectedAsync();  };
  Controller.Refresh();
```

## Auto-Determine Controller
```C#
  using NolanHodge.GamingController;
  
  AutoController Controller = new AutoController();
  
  Controller.Connected += (s,e) => { HandleConnectedAsync(); };
  Controller.Disconnected += (s,e) => { HandleDisconnectedAsync();  };
  controller.Refresh();
```

 - This package is available in the nuget repository https://www.nuget.org/packages/NolanHodge.GamingController/

![nuget](https://i.imgur.com/Al51DE6.jpg)
