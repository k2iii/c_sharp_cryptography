using Cryptography.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography.Cipher
{
    public class VigenereCipher
    {
        public string Encrypt(string message, string key)
        {
            char[] a = message.ToCharArray();
            char[] k = key.ToCharArray();
            int kIndex = -1;

            for (int i = 0; i < a.Length; i++)
            {
                if (char.IsWhiteSpace(a[i])) continue;

                // 키를 계속 반복해서 사용한다
                kIndex = (kIndex >= k.Length - 1) ? 0 : kIndex + 1;
                int iKey = k[kIndex] - 'A';

                a[i] = (char)('A' + ((a[i] - 'A') + iKey) % 26);
            }

            return new string(a);
        }

        public string Decrypt(string cipher, string key)
        {
            char[] a = cipher.ToCharArray();
            char[] k = key.ToCharArray();
            int kIndex = -1;

            for (int i = 0; i < a.Length; i++)
            {
                if (char.IsWhiteSpace(a[i])) continue;

                // 키를 계속 반복해서 사용한다.
                kIndex = (kIndex >= k.Length - 1) ? 0 : kIndex + 1;
                int iKey = k[kIndex] - 'A';

                a[i] = (char)('A' + (a[i] - 'A' - iKey + 26) % 26);
            }

            return new string(a);
        }

        public MessageJson HowToTest()
        {
            string message = "ATTACK WEST CASTLE".ToUpper();
            string key = "JULIA".ToUpper();

            string cipher = Encrypt(message, key);
            string plain = Decrypt(cipher, key);

            Console.WriteLine($"{message},{cipher},{plain}");
            Debug.Assert(cipher == "JNEICT QPAT LUDBLN");
            Debug.Assert(message == plain);

            MessageJson messageJson = new MessageJson();
            messageJson.Message = message;
            messageJson.Encrypt = cipher;
            messageJson.Decrypt = plain;

            return messageJson;
        }
    }
}
