using Cryptography.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography.Cipher
{
    public class AffineCipher2
    {
        private const int N = 26;
        private char[] encryptTable = new char[N];
        private char[] decryptTable = new char[N];

        public AffineCipher2(int k1, int k2)
        {
            // 암호화/복호화 매핑 테이블 생성
            for (int i = 0; i < N; i++)
            {
                int c = (i * k1 + k2) % N;
                encryptTable[i] = (char)('A' + c);
                decryptTable[c] = (char)('A' + i);
            }
        }

        // 암호화
        public string Encrypt(string message)
        {
            char[] a = message.ToCharArray();

            for (int i = 0; i < a.Length; i++)
            {
                if (!char.IsWhiteSpace(a[i]))
                {
                    a[i] = encryptTable[a[i] - 'A'];
                }
            }

            return new string(a);
        }

        // 복호화
        public string Decrypt(string cipher)
        {
            char[] a = cipher.ToCharArray();

            for (int i = 0; i < a.Length; i++)
            {
                if (!char.IsWhiteSpace(a[i]))
                {
                    a[i] = decryptTable[a[i] - 'A'];
                }
            }

            return new string(a);
        }

        public MessageJson HowToTest()
        {
            string message = "ATTACK WEST CASTLE";
            string cipher = this.Encrypt(message);
            string plain = this.Decrypt(cipher);

            Console.WriteLine($"{message},{cipher},{plain}");
            Debug.Assert(message == plain);

            MessageJson messageJson = new MessageJson();
            messageJson.Message = message;
            messageJson.Encrypt = cipher;
            messageJson.Decrypt = plain;

            return messageJson;
        }
    }
}
