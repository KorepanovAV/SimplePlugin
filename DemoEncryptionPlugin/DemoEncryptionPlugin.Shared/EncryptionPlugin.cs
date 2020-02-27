namespace DemoEncryptionPlugin.Shared
{
  using System;
  using System.Collections.Generic;
  using System.Text;
  using SBPluginInterfaceLibrary;

  class EncryptionPlugin: Plugin2, IEncryptionPlugin
  {
    public bool CreateSignature(string Content, ICertificate CreateCertificate, out string Signature, out string CreateMsg, ref DateTime CreateDateTime)
    {
      CreateMsg = string.Empty;
      CreateDateTime = DateTime.UtcNow;
      Signature = $"Signature: CreateDateTime={ CreateDateTime };";
      return true;
    }

    public string Decrypt(string Source, string Password) => throw new NotImplementedException();

    public string DecryptWithCertificate(string Source) => throw new NotImplementedException();

    public string Encrypt(string Source, string Password) => throw new NotImplementedException();

    public string EncryptWithCertificate(string Source, ICertificate Certificate) => throw new NotImplementedException();

    public ICertificate GetCertificate()
    {
      return new Certificate();
    }

    public ICertificateStorage GetCertificateStorage()
    {
      throw new NotImplementedException();
    }

    public string GetSessionKey() => throw new NotImplementedException();

    public string Hash(string Source) => throw new NotImplementedException();

    public bool VerifySignature(string Content, string Signature, out ICertificate VerifyCertificate, out string VerifyMsg, out DateTime SignDate)
    {
      VerifyCertificate = new Certificate();
      VerifyMsg = string.Empty;
      var signParts = Signature.Split(new string[] { ": " }, StringSplitOptions.None);
      var signParams = signParts[1].Split(';');
      SignDate = DateTime.Parse(signParams[0].Split('=')[1]).ToLocalTime();
      return true;
    }

    public bool IsCertificateStorageSupported => false;

    public bool CanEncrypt => false;
  }
}
