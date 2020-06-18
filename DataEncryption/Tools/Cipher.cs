using DataEncryption.Tools;
using System;

namespace DataEncryption.Tools
{
    internal class Cipher
    {
        private int _shift;
        private readonly CharRange UPPER_LETTERS;
        private readonly CharRange LOWER_LETTERS;
        private readonly CharRange NUMBERS;

        internal protected Cipher()
        {
            UPPER_LETTERS = new CharRange('A', 'Z');
            LOWER_LETTERS = new CharRange('a', 'z');
            NUMBERS = new CharRange('0', '9');
        }

        internal protected void SetShift(int shift)
        {
            _shift = shift;
        }

        internal protected char DecryptAround(char value)
        {
            char newValue = value;
            CharRange range = GetRange(value);

            if (range != null)
            {
                newValue = ShiftDown(range, value, range.LowerBound, range.UpperBound);
            }

            return newValue;
        }

        internal protected char EncryptAround(char value)
        {
            char newValue = value;

            CharRange range = GetRange(value);

            if (range != null)
            {
                newValue = ShiftUp(range, value, range.LowerBound, range.UpperBound);
            }

            return newValue;
        }

        #region HELPERS

        private char ShiftDown(CharRange range, char value, char lowerBound, char upperBound)
        {
            int upper = upperBound;
            int lower = lowerBound - 1;
            int val = value - _shift;

            char test = range.IsLowerBound(value) ?
                    (char)((upper + 1) - _shift) : 
                    (char)(range.IsLessThanLowerBound((char)val) ?
                        upper - Math.Abs(lower - val) : val);

            return test;
        }

        private char ShiftUp(CharRange range, char value, char lowerBound, char upperBound)
        {
            int upper = upperBound + 1;
            int lower = lowerBound - 1;
            int val = value + _shift;

            return
                range.IsUpperBound(value) ?
                    (char)(lower + _shift) :
                    (char)(range.IsGreaterThanUpperBound((char)val) ?
                        Math.Abs(val - upper) + lower : val);
        }

        private CharRange GetRange(char value)
        {
            return
                LOWER_LETTERS.IsWithinRange(value) ?
                    new CharRange('a', 'z') :
                    UPPER_LETTERS.IsWithinRange(value) ?
                        new CharRange('A', 'Z') :
                            NUMBERS.IsWithinRange(value) ?
                                new CharRange('0', '9') : null;
        }

        #endregion HELPERS
    }
}
