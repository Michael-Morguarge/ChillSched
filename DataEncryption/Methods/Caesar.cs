using DataEncryption.Interfaces;
using DataEncryption.Tools;
using System;
using System.Linq;

namespace DataEncryption.Methods
{
    internal class Caesar : ICipherOperation
    {
        private readonly int _shift;
        private readonly CharRange UPPER_LETTERS;
        private readonly CharRange LOWER_LETTERS;
        private readonly CharRange NUMBERS;

        private readonly bool DECRYPT;
        private readonly bool ENCRYPT;

        public Caesar(int shift)
        {
            UPPER_LETTERS = new CharRange('A', 'Z');
            LOWER_LETTERS = new CharRange('a', 'z');
            NUMBERS = new CharRange('0', '9');
            const int MIN_NUM = 49;
            const int DEF_MAX = 9;

            CharRange validRangeCheck = new CharRange('1', '9');

            if (validRangeCheck.IsWithinRange((char)shift))
            {
                _shift = (Math.Abs(shift - MIN_NUM) % DEF_MAX) + 1;
                DECRYPT = true;
                ENCRYPT = true;
            }
        }

        public string Decrypt(string message)
        {
            if (string.IsNullOrEmpty(message))
                return string.Empty;

            return DECRYPT ? string.Concat(message.Select(x => DecryptAround(x))) : string.Empty;
        }

        public string Encrypt(string message)
        {
            if (string.IsNullOrEmpty(message))
                return string.Empty;

            return ENCRYPT ? _shift + string.Concat(message.Select(x => EncryptAround(x))) : string.Empty;
        }

        private char DecryptAround(char value)
        {
            char newValue = value;

            if (LOWER_LETTERS.IsWithinRange(value))
            {
                newValue =
                    LOWER_LETTERS.IsLowerBound(value) ?
                        (char)('z' - _shift) :
                        (char)(LOWER_LETTERS.IsLessThanLowerBound((char)(value - _shift)) ?
                            ('z' + 1) - Math.Abs('a' - value + _shift) :  (value - _shift));
                
            }
            else if (UPPER_LETTERS.IsWithinRange(value))
            {
                newValue =
                    UPPER_LETTERS.IsLowerBound(value) ?
                        (char)('Z' - _shift) :
                        (char)(UPPER_LETTERS.IsLessThanLowerBound((char)(value - _shift)) ?
                            ('Z' + 1) - Math.Abs('A' - value + _shift) : (value - _shift));
            }
            else if (NUMBERS.IsWithinRange(value))
            {
                newValue =
                    NUMBERS.IsLowerBound(value) ?
                        (char)('9' - _shift) :
                        (char)(NUMBERS.IsLessThanLowerBound((char)(value - _shift)) ?
                            ('9' + 1) - Math.Abs('0' - value + _shift) : (value - _shift));
            }

            return newValue;
        }

        private char EncryptAround(char value)
        {
            char newValue = value;

            if (LOWER_LETTERS.IsWithinRange(value))
            {
                newValue =
                    LOWER_LETTERS.IsUpperBound(value) ?
                        (char)('a' + _shift) :
                        (char)(LOWER_LETTERS.IsGreaterThanUpperBound((char)(value + _shift)) ?
                            Math.Abs(value - 'z' + _shift) + ('a' - 1) : (value + _shift));
            }
            else if (UPPER_LETTERS.IsWithinRange(value))
            {
                newValue =
                    UPPER_LETTERS.IsUpperBound(value) ?
                        (char)('A' + _shift) :
                        (char)(UPPER_LETTERS.IsGreaterThanUpperBound((char)(value + _shift)) ?
                            Math.Abs(value - 'Z' + _shift) + ('A' - 1) : (value + _shift));
            }
            else if (NUMBERS.IsWithinRange(value))
            {
                newValue =
                    NUMBERS.IsUpperBound(value) ?
                        (char)('0' + _shift) :
                        (char)(NUMBERS.IsGreaterThanUpperBound((char)(value + _shift)) ?
                            Math.Abs(value - '9' + _shift) + ('0' - 1) : (value + _shift));
            }

            return newValue;
        }
    }
}
