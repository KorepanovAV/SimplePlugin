namespace Demo.Plugin
{
  using System;
  using System.Runtime.InteropServices;
  using SBPluginInterfaceLibrary;

  public class Plugin2: Plugin, IPlugin2
  {
    public string CurrentVersion { get => string.Empty; set { } }

    public int VersionCount => 0;

    public string get_Versions(int index) => string.Empty;
  }
}
