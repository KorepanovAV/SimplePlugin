namespace Demo.AuthorizationPlugin
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using System.Diagnostics;

  public static class StartPoint
  {
    public static SBPluginInterfaceLibrary.IPlugin2 GetInterface()
    {
      //Debugger.Launch();
      return new Demo.AuthorizationPlugin.AuthorizationPlugin
      {
        CurrentVersion = "1.0",
        Description = "Description.Demo.AuthorizationPlugin",
        Name = "Demo.AuthorizationPlugin",
        PlatformVersion = "7.58.3",
        Title = "Title.Demo.AuthorizationPlugin"
      };
    }
  }
}
