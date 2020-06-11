using System;

namespace DataEncryption.Tools
{
    /// <summary>
    /// Creates a character range
    /// </summary>
    public class CharRange
    {
        private readonly char _lowerBound;
        private readonly char _upperBound;

        /// <summary>
        /// Checks whether the key is within the char range.
        /// </summary>
        /// <param name="key">The value to check</param>
        /// <returns>Whether the key is valid for this range</returns>
        public bool IsWithinRange(char key) => key >= _lowerBound && key <= _upperBound;

        /// <summary>
        /// Checks whether the key is greater than upper bound.
        /// </summary>
        /// <param name="key">The value to check</param>
        /// <returns>Whether the key is a valid value for this range</returns>
        public bool IsGreaterThanUpperBound(char key) => key > _upperBound;

        /// <summary>
        /// Checks whether the key is less than the lower bound.
        /// </summary>
        /// <param name="key">The value to check</param>
        /// <returns>Whether the key is a valid value for this range</returns>
        public bool IsLessThanLowerBound(char key) => _lowerBound > key;

        /// <summary>
        /// Checks if the key is the upper bound.
        /// </summary>
        /// <param name="key">The value to check</param>
        /// <returns>Whether the key is the upper bound</returns>
        public bool IsUpperBound(char key) => key == _upperBound;

        /// <summary>
        /// Checks if the key is the lower bound.
        /// </summary>
        /// <param name="key">The value to check</param>
        /// <returns>Whether the key is the lower bound</returns>
        public bool IsLowerBound(char key) => key == _lowerBound;

        /// <summary>
        /// Constructor for the CharRange class. Sets the min and max chars.
        /// </summary>
        /// <param name="lowerBound">The lower bound character range</param>
        /// <param name="upperBound">The upper bound character range</param>
        public CharRange(char lowerBound, char upperBound)
        {
            if (lowerBound == upperBound || upperBound - lowerBound < 2)
                throw new Exception("Range is too small.");

            if (lowerBound > upperBound)
            {
                _lowerBound = upperBound;
                _upperBound = lowerBound;
            }
            else
            {
                _lowerBound = lowerBound;
                _upperBound = upperBound;
            }
        }
    }
}
