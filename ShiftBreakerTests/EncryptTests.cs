using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShiftBreaker;

namespace ShiftBreakerTests
{
    [TestClass]
    public class EncryptTests
    {
        [TestMethod]
        public void BShiftedtoHShouldReturnI()
        {
            Encrypt encrypt = new Encrypt();

            char result = encrypt.EncryptChar('h', 'b');
            Assert.AreEqual('i', result);
        }

        [TestMethod]
        public void CShiftHShouldReturnJ()
        {
            Encrypt encrypt = new Encrypt();

            char result = encrypt.EncryptChar('h', 'c');
            Assert.AreEqual('j', result);
        }

        [TestMethod]
        public void DadShiftedByDShouldReturnGdg()
        {
            Encrypt encrypt = new Encrypt();

            string message = "dad";
            string keyWord = "d";
            string expected = "gdg";

            string cipherText = encrypt.GenerateCipher(message, keyWord);

            Assert.AreEqual(expected, cipherText);
        }

        [TestMethod]
        public void TooManySecretsShiftedBySetecAstronomyShouldYieldLshqcnqlvqesfq()
        {
            Encrypt encrypt = new Encrypt();

            string message = "toomanysecrets";
            string keyWord = "setecastronomy";

            string expected = "lshqcnqlvqesfq";
            string result = encrypt.GenerateCipher(message, keyWord);

            Assert.AreEqual(expected, result);
        }
    }
}
