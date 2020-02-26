namespace DemoEncryptionPlugin.Shared
{
  using System;
  using System.Collections.Generic;
  using System.Text;
  using SBPluginInterfaceLibrary;

  class AdditionalInfoList : IAdditionalInfoList
  {
    public int Count => 0;

    public string get_Items(int index) => string.Empty;
  }
}
