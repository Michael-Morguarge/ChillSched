using System;

namespace DataEncryption.Interfaces
{
    /// <summary>
    /// Interfaces for Cipher Methodologies
    /// </summary>
    internal interface ICipherOperation
    {
        /// <summary>
        /// Encrypts a message
        /// </summary>
        /// <param name="message">The message to encrypt</param>
        /// <returns>The encrypted message</returns>
        string Encrypt(string message);

        /// <summary>
        /// Dectrypts a message
        /// </summary>
        /// <param name="message">The message to decrypt</param>
        /// <returns>The decrypted message</returns>
        string Decrypt(string message);
    }
}
