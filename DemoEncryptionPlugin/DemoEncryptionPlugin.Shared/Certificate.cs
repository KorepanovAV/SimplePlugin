namespace DemoEncryptionPlugin.Shared
{
  using System;
  using System.Collections.Generic;
  using System.Text;
  using SBPluginInterfaceLibrary;

  class Certificate: ICertificate
  {
    public bool IsValid(DateTime VerificationDate, bool NeedCheckDateValidity) => true;

    public TCertificateLoadPublicKeyResult LoadPublicKeyFromFile(string FileName, string Password, out string LoadErrorMessage) => throw new NotImplementedException();

    public TCertificateLoadPublicKeyResult LoadPublicKeyFromStorage(string CertificateID, out string LoadErrorMessage)
    {
      LoadErrorMessage = string.Empty;
      return TCertificateLoadPublicKeyResult.lrSuccess;
    }

    public void Display() => throw new NotImplementedException();

    public void Save(string FileName, string Password, bool SavePrivateKey) => throw new NotImplementedException();

    public TCertificateLoadPrivateKeyResult LoadPrivateKeyFromFile(string FileName, string Password, out string LoadErrorMessage) => throw new NotImplementedException();

    public TCertificateLoadPrivateKeyResult LoadPrivateKeyFromStorage(string CertificateID, out string LoadErrorMessage)
    {
      LoadErrorMessage = "";
      return TCertificateLoadPrivateKeyResult.lpkrSuccess;
    }

    public bool CanLoadPublicKeyFromFile => false;

    public bool CanLoadPublicKeyFromStorage => true;

    public bool CanLoadPrivateKeyFromFile => false;

    public bool CanLoadPrivateKeyFromStorage => true;

    public bool HasPrivateKey => true;

    public bool EncryptionAllowed => false;

    public bool SigningAllowed => true;

    public string CertificateID => "DemoEncryptionPlugin.Certificate.CertificateID";

    public string IssuerName => "DemoEncryptionPlugin.Certificate.IssuerName";

    public string PluginName => "DemoEncryptionPlugin.Name";

    public string SerialNumber => "DemoEncryptionPlugin.Certificate.SerialNumber";

    public string SubjectName => "DemoEncryptionPlugin.Certificate.SubjectName";

    public DateTime ValidFromDate => DateTime.MinValue;

    public DateTime ValidToDate => DateTime.MaxValue;

    public int Version => 0;

    public string KeyFileExtensionFilter => "DemoEncryptionPlugin.Certificate.KeyFileExtensionFilter";
  }
}
