using DataEncryption.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppTesting.DataEncryption
{
    [TestClass]
    public class ReverseCaesarTest
    {
        #region Encrypt

        [TestMethod]
        public void WhenCaesarEncryptingMessage_HandlesNullOrEmptyMessage()
        {
            string expected = string.Empty;
            string message = EncryptionFactory.ExecuteCryption('A', string.Empty);

            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void WhenCaesarEncryptingMessage_ReturnsValidSingleMovedEncryption()
        {
            string expected = "Abcd";
            string message = EncryptionFactory.ExecuteCryption('A', "abc");

            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void WhenCaesarEncryptingMessage_ReturnsValidMultiMovedEncryption()
        {
            string expected = "Mfgh";
            string message = EncryptionFactory.ExecuteCryption('M', "abc");

            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void WhenCaesarEncryptingMessage_ReturnsValidEdgeMultiMovedEncryption()
        {
            string expected = "Zjkl";
            string message = EncryptionFactory.ExecuteCryption('Z', "abc");

            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void WhenCaesarEncryptingMessageWithBelowMinChar_ReturnsEmptyString()
        {
            string expected = string.Empty;
            string message = EncryptionFactory.ExecuteCryption('@', "abc");

            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void WhenCaesarEncryptingMessageWithAboveMaxChar_ReturnsEmptyString()
        {
            string expected = string.Empty;
            string message = EncryptionFactory.ExecuteCryption('[', "abc");

            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void WhenCaesarEncryptingMessage_ReturnsValidMultiMovedEdgeEncryption()
        {
            string expected = "ZiI8";
            string message = EncryptionFactory.ExecuteCryption('Z', "zZ9");

            Assert.AreEqual(expected, message);
        }

        #endregion Encrypt

        #region Decrypt

        [TestMethod]
        public void WhenCaesarDecryptingMessage_HandlesNullOrEmptyMessage()
        {
            string expected = string.Empty;
            string message = EncryptionFactory.ExecuteCryption('A', string.Empty, false);

            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void WhenCaesarDecryptingMessage_ReturnsValidSingleMovedEncryption()
        {
            string expected = "abc";
            string message = EncryptionFactory.ExecuteCryption('A', "bcd", false);

            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void WhenCaesarDecryptingMessage_ReturnsValidMultiMovedEncryption()
        {
            string expected = "abc";
            string message = EncryptionFactory.ExecuteCryption('M', "fgh", false);

            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void WhenCaesarDecryptingMessage_ReturnsValidEdgeMultiMovedEncryption()
        {
            string expected = "abc";
            string message = EncryptionFactory.ExecuteCryption('M', "jkl", false);

            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void WhenCaesarDecryptingMessageWithBelowMinChar_ReturnsEmptyString()
        {
            string expected = string.Empty;
            string message = EncryptionFactory.ExecuteCryption('@', "bcd", false);

            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void WhenCaesarDecryptingMessageWithAboveMaxChar_ReturnsEmptyString()
        {
            string expected = string.Empty;
            string message = EncryptionFactory.ExecuteCryption('[', "jkl", false);

            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void WhenCaesarDecryptingMessage_ReturnsValidSingleMovedEdgeDecryption()
        {
            string expected = "zZ9";
            string message = EncryptionFactory.ExecuteCryption('A', "aA0", false);

            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void WhenCaesarDecryptingMessage_ReturnsValidMultiMovedEdgeDecryption()
        {
            string expected = "zZ9";
            string message = EncryptionFactory.ExecuteCryption('Z', "iI8", false);

            Assert.AreEqual(expected, message);
        }

        #endregion Decrypt
    }
}
