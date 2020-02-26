namespace DemoEncryptionPlugin.Shared
{
  using System;
  using System.Runtime.InteropServices;
  using SBPluginInterfaceLibrary;

  class Plugin: IPlugin
  {
    public void GetDefaultSettings(IPluginSettings Settings) {}

    public void Initialize(IPluginSettings Settings) => Marshal.FinalReleaseComObject(Settings);

    public void CheckSettings(IPluginSettings Settings) {}

    public bool CheckEnvironment() => true;

    public string PlatformVersion => "7.54";

    public string Name => "DemoEncryptionPlugin.Name";

    public string Title => "DemoEncryptionPlugin.Title";

    public string Description => "DemoEncryptionPlugin.Description";
  }
}
