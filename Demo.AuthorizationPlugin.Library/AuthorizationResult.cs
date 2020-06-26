namespace Demo.AuthorizationPlugin
{
  using System;
  using System.Collections.Generic;
  using System.Text;

  class AuthorizationResult: SBPluginInterfaceLibrary.IAuthorizationResult
  {
    public bool IsSuccess { get; set; }

    public string ErrorMessage { get; set; }
  }
}
