using DataEncryption.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataEncryption.Methods
{
    internal class ReverseCaesar : ICipherOperation
    {
        private readonly int _shift;
        private readonly int MIN = 65;
        private readonly int DEF_MIN = 1;
        private readonly int MAX = 90;
        private readonly int DEF_MAX = 26;

        private readonly bool DECRYPT;
        private readonly bool ENCRYPT;

        public ReverseCaesar(int shift)
        {


            if (shift >= MIN && shift <= MAX)
            {
                _shift = (Math.Abs(MAX - shift) % DEF_MAX) + 1;
                DECRYPT = true;
                ENCRYPT = true;
            }
        }

        public string Decrypt(string message)
        {
            throw new NotImplementedException();
        }

        public string Encrypt(string message)
        {
            throw new NotImplementedException();
        }
    }
}
