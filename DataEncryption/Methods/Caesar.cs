using DataEncryption.Interfaces;
using DataEncryption.Tools;
using System;
using System.Linq;

namespace DataEncryption.Methods
{
    internal class Caesar : Cipher, ICipherOperation
    {
        private readonly int _shift;
        private readonly bool DECRYPT;
        private readonly bool ENCRYPT;

        internal Caesar(int shift) : base()
        {
            const int MIN_NUM = 49;
            const int DEF_MAX = 9;

            CharRange validRangeCheck = new CharRange('1', '9');

            if (validRangeCheck.IsWithinRange((char)shift))
            {
                _shift = (Math.Abs(shift - MIN_NUM) % DEF_MAX) + 1;
                SetShift(_shift);

                DECRYPT = true;
                ENCRYPT = true;
            }
        }

        public string Decrypt(string message)
        {
            string result = string.Empty;

            if (!string.IsNullOrEmpty(message) && DECRYPT)
                result = string.Concat(message.Select(x => DecryptAround(x)));

            return result;
        }

        public string Encrypt(string message)
        {
            string result = string.Empty;

            if (!string.IsNullOrEmpty(message) && ENCRYPT)
                result = _shift + string.Concat(message.Select(x => EncryptAround(x)));

            return result;
        }
    }
}
