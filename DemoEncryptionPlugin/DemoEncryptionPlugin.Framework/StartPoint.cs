namespace DemoEncryptionPlugin.Framework
{
  using System;
  using System.Collections.Generic;
  using System.Text;
  using DemoEncryptionPlugin.Shared;

  public static class StartPoint
  {
    public static SBPluginInterfaceLibrary.IPlugin GetInterface() => new EncryptionPlugin2();
  }
}
