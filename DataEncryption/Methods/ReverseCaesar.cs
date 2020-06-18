using DataEncryption.Interfaces;
using DataEncryption.Tools;
using System;
using System.Linq;

namespace DataEncryption.Methods
{
    internal class ReverseCaesar : Cipher, ICipherOperation 
    {
        private readonly int _shift;
        private readonly bool DECRYPT;
        private readonly bool ENCRYPT;

        internal ReverseCaesar(int shift) : base()
        {
            const int MIN_NUM = 65;
            const int DEF_MAX = 26;

            CharRange validRangeCheck = new CharRange('B', 'Z');

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
            if (string.IsNullOrEmpty(message))
                return string.Empty;

            return DECRYPT ? string.Concat(message.Select(x => EncryptAround(x))) : string.Empty;
        }

        public string Encrypt(string message)
        {
            if (string.IsNullOrEmpty(message))
                return string.Empty;

            return ENCRYPT ? _shift + string.Concat(message.Select(x => DecryptAround(x))) : string.Empty;
        }
    }
}
