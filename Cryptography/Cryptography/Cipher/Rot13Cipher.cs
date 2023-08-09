using Cryptography.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography.Cipher
{
    public class Rot13Cipher
    {
        // ROT13 매핑 테이블
        private string ROT = "NOPQRSTUVWXYZABCDEFGHIJKLM";

        public string Encrypt(string message)
        {
            return Rotate(message);
        }

        public string Decrypt(string cipher)
        {
            return Rotate(cipher);
        }

        private string Rotate(string str)
        {
            char[] a = str.ToCharArray();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = (a[i] == ' ') ? ' ' : ROT[a[i] - 'A'];
            }

            return new string(a);
        }

        public MessageJson HowToTest()
        {
            string message = "ATTACK WEST CASTLE";
            string cipher = this.Encrypt(message);
            string plain = this.Decrypt(cipher);

            Console.WriteLine($"{message}, {cipher}, {plain}");
            Debug.Assert(message == plain);

            MessageJson json = new MessageJson();
            json.Message = message;
            json.Encrypt = cipher;
            json.Decrypt = plain;

            return json;
        }
    }
}
