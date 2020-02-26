namespace DemoEncryptionPlugin.Shared
{
  using System;
  using System.Collections.Generic;
  using System.Text;
  using SBPluginInterfaceLibrary;

  class EncryptionPlugin2 : EncryptionPlugin, IEncryptionPlugin2
  {
    public bool CreateSignature2(string Content, ICertificate CreateCertificate, IAdditionalInfoList AdditionalInfo, out string Signature, out string CreateMsg, ref DateTime CreateDateTime)
    {
      CreateMsg = string.Empty;
      CreateDateTime = DateTime.UtcNow;
      Signature = $"Signature: CreateDateTime={ CreateDateTime };";
      return true;
    }

    public bool VerifySignature2(string Content, string Signature, out ICertificate VerifyCertificate, out string VerifyMsg, out DateTime SignDate, out IAdditionalInfoList AdditionalInfo)
    {
      VerifyCertificate = new Certificate();
      VerifyMsg = string.Empty;
      AdditionalInfo = new AdditionalInfoList();
      var signParts = Signature.Split(new string[] { ": " }, StringSplitOptions.None);
      var signParams = signParts[1].Split(';');
      SignDate = DateTime.Parse(signParams[0].Split('=')[1]);
      return true;
    }
  }
}
