# GamingController
 
GamingController presents the IGamingController interface and multiple classes for Xbox, Playstation, and Generic controller devices.

```C#
  using NolanHodge.GamingController;
  
  XboxController controller = new XboxController();
  PlaystationController controller = new PlaystationController();
  GenericController controller = new GenericController();
  
  controller.Connected += (s,e) => 
  {
      // controller has been detected.
      Run();
  };
  
  controller.Disconnected += (s,e) => 
  {
      // controller has been disconnected.
      Kill();
  };
  
  // handle a pre-connected controller.
  controller.Refresh()
```

 - This package is available in the nuget repository https://www.nuget.org/packages/NolanHodge.GamingController/

![nuget](https://i.imgur.com/Al51DE6.jpg)
