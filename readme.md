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
  
  // Handle any controller type connected.
  void Determine()
  {
      GenericController Controller = new GenericController();

      Controller.Connected += (s,e) => 
      {
            switch (Controller.TypeString(Controller.Vendor()))
            {
             case "Xbox":
                 Controller = new XboxController();
             case "Playstation":
                 Controller = new PlaystationController();
             case "Generic":
                 break;
            }

      };

      Controller.Disconnected += (s,e) => { HandleDisconnectedAsync();  };
      
      Controller.Refresh();
   
      Start(Controller);
  }
  
  // Called once controller has been configured.
  void Start(IGamingController Controller)
  {
  
  }
```

 - This package is available in the nuget repository https://www.nuget.org/packages/NolanHodge.GamingController/

![nuget](https://i.imgur.com/Al51DE6.jpg)
