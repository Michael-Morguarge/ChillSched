using DataEncryption.Interfaces;
using DataEncryption.Methods;
using DataEncryption.Tools;

namespace DataEncryption.Factories
{
    public static class EncryptionFactory
    {
        public static string ExecuteCryption(char value, string message, bool encrypt = true)
        {
            return encrypt ? Encrypt(value, message) : Decrypt(value, message);
        }

        private static string Encrypt(char value, string message)
        {
            if (!char.IsLetterOrDigit(value) || string.IsNullOrEmpty(message))
                return string.Empty;

            ICipherOperation method = GetMethod(value);

            if (method == null)
                return string.Empty;

            return $"{method.Encrypt(message)}";
        }

        private static string Decrypt(char value, string message)
        {
            if (!char.IsLetterOrDigit(value) || string.IsNullOrEmpty(message))
                return string.Empty;

            ICipherOperation method = GetMethod(value);

            if (method == null)
                return string.Empty;

            return $"{method.Decrypt(message)}";
        }

        private static ICipherOperation GetMethod(char value)
        {
            ICipherOperation method = null;
            CharRange[] ranges = { new CharRange('0', '9'), new CharRange('A', 'Z'), new CharRange('a', 'z') };

            if (ranges[0].IsWithinRange(value))
                method = new Caesar(value);
            else if (ranges[1].IsWithinRange(value))
                method = new ReverseCaesar(value);
            else if (ranges[2].IsWithinRange(value))
                method = new RangedFakeCaesar();

            return method;
        }
    }
}
