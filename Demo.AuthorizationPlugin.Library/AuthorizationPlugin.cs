namespace Demo.AuthorizationPlugin
{
  using System;
  using System.Runtime.InteropServices;
  using Demo.Plugin;
  using SBPluginInterfaceLibrary;
  
  public class AuthorizationPlugin: Plugin2, IAuthorizationPlugin
  {
    public override void GetDefaultSettings(IPluginSettings Settings)
    {
      base.GetDefaultSettings(Settings);

      Settings.AddSetting("AuthorizationDialog", "AuthorizationDialog", TSettingValueType.svtString, TSettingStorage.ssServerStorage);

      Marshal.FinalReleaseComObject(Settings);
    }

    public IAuthorizationResult Authorize(IAuthorizationOptions AOptions)
    {
      if (!AOptions.IsInteractiveMode)
        return new AuthorizationResult { IsSuccess = false, ErrorMessage = "Authorization onle for interactive mode!" };

      var application = AOptions.Application;
      var dialogsFactory = application.GetProperty("DialogsFactory");
      var dialogFactory = dialogsFactory.GetProperty("DialogFactory", "AuthorizationDialog");
      var dialog = dialogFactory.InvokeMethod("CreateNew", GetType().Name);
      try
      {
        var dialogResult = (int)dialog.InvokeMethod("Show");
        const int OK_RESULT = 1;

        if (dialogResult == OK_RESULT)
          return new AuthorizationResult { IsSuccess = true, ErrorMessage = "" };
      }
      finally
      {
        Marshal.FinalReleaseComObject(dialog);
        Marshal.FinalReleaseComObject(dialogFactory);
        Marshal.FinalReleaseComObject(dialogsFactory);
        Marshal.FinalReleaseComObject(application);
        Marshal.FinalReleaseComObject(AOptions);
      }

      return new AuthorizationResult { IsSuccess = false, ErrorMessage = "Authorization canceled!" };
    }
  }
}