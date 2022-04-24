using PocNugetEncryptDecrypt.Interfaces;
using PocNugetEncryptDecrypt.Services;
using Xunit;

namespace PocNugetEncryptDecryptTest
{
    public class PasswordServiceTest
    {
        private readonly IPasswordService _sut;

        public PasswordServiceTest()
        {
            _sut = new PasswordService();
        }

        [Fact(DisplayName = "Decrypt Valid Password")]
        [Trait("Category", "Services")]
        public void Decrypt_WhenPasswordIsValid()
        {
            // Act
            var respose = _sut.Decrypt("Dr6x+8h5zZPbJSiVbBky/Q==");

            // Assert
            Assert.NotNull(respose);
        }

        [Fact(DisplayName = "Encrypt Valid Password")]
        [Trait("Category", "Services")]
        public void Encrypt_WhenPasswordIsValid()
        {
            // Act
            var respose = _sut.Encrypt("@G147a258d3");

            // Assert
            Assert.NotNull(respose);
        }
    }
}
