namespace Demo.Plugin
{
  using System;
  using System.Runtime.InteropServices;
  using SBPluginInterfaceLibrary;

  public class Plugin : IPlugin
  {
    public virtual void GetDefaultSettings(IPluginSettings Settings) { }

    public void Initialize(IPluginSettings Settings) => Marshal.FinalReleaseComObject(Settings);

    public void CheckSettings(IPluginSettings Settings) { }

    public bool CheckEnvironment() => true;

    public string PlatformVersion { get; set; }

    public string Name { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }
  }
}
