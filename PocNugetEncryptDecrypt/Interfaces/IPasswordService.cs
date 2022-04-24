namespace PocNugetEncryptDecrypt.Interfaces
{
    public interface IPasswordService
    {
        string Encrypt(string password);
        string Decrypt(string password);
    }
}
