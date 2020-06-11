using DataEncryption.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpCompress.Crypto;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppTesting.DataEncryption
{
    [TestClass]
    public class CaesarTest
    {

        [TestInitialize]
        public void Setup()
        {
        }

        #region Encrypt

        [TestMethod]
        public void WhenCaesarEncryptingMessage_HandlesNullOrEmptyMessage()
        {
            string expected = string.Empty;
            string message = EncryptionFactory.ExecuteCryption('1', string.Empty);

            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void WhenCaesarEncryptingMessage_ReturnsValidSingleMovedEncryption()
        {
            string expected = "1bcd";
            string message = EncryptionFactory.ExecuteCryption('1', "abc");

            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void WhenCaesarEncryptingMessage_ReturnsValidMultiMovedEncryption()
        {
            string expected = "5fgh";
            string message = EncryptionFactory.ExecuteCryption('5', "abc");

            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void WhenCaesarEncryptingMessage_ReturnsValidEdgeMultiMovedEncryption()
        {
            string expected = "9jkl";
            string message = EncryptionFactory.ExecuteCryption('9', "abc");

            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void WhenCaesarEncryptingMessageWithBelowMinChar_ReturnsEmptyString()
        {
            string expected = string.Empty;
            string message = EncryptionFactory.ExecuteCryption('0', "abc");

            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void WhenCaesarEncryptingMessageWithAboveMaxChar_ReturnsEmptyString()
        {
            string expected = string.Empty;
            string message = EncryptionFactory.ExecuteCryption(':', "abc");

            Assert.AreEqual(expected, message);
        }

        // test edge cases when decrypting: 'a' and 'z', '0' and '9', 'A' and 'Z'

        #endregion Encrypt

        #region Decrypt

        [TestMethod]
        public void WhenCaesarDecryptingMessage_HandlesNullOrEmptyMessage()
        {
            string expected = string.Empty;
            string message = EncryptionFactory.ExecuteCryption('1', string.Empty, false);

            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void WhenCaesarDecryptingMessage_ReturnsValidSingleMovedEncryption()
        {
            string expected = "abc";
            string message = EncryptionFactory.ExecuteCryption('1', "bcd", false);

            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void WhenCaesarDecryptingMessage_ReturnsValidMultiMovedEncryption()
        {
            string expected = "abc";
            string message = EncryptionFactory.ExecuteCryption('5', "fgh", false);

            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void WhenCaesarDecryptingMessage_ReturnsValidEdgeMultiMovedEncryption()
        {
            string expected = "abc";
            string message = EncryptionFactory.ExecuteCryption('9', "jkl", false);

            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void WhenCaesarDecryptingMessageWithBelowMinChar_ReturnsEmptyString()
        {
            string expected = string.Empty;
            string message = EncryptionFactory.ExecuteCryption('0', "bcd");

            Assert.AreEqual(expected, message);
        }

        [TestMethod]
        public void WhenCaesarDecryptingMessageWithAboveMaxChar_ReturnsEmptyString()
        {
            string expected = string.Empty;
            string message = EncryptionFactory.ExecuteCryption(':', "jkl");

            Assert.AreEqual(expected, message);
        }

        // test edge cases when decrypting: 'a' and 'z', '0' and '9', 'A' and 'Z'

        #endregion Decrypt
    }
}
