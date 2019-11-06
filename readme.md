# GamingController
 
 - This package is available as a nuget package https://www.nuget.org/packages/GamingController/

GamingController presents the IGamingController interface and multiple classes for Xbox, Playstation, and Generic controller devices.

```C#
  using trashbo4t.GamingController;
  
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
