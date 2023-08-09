using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cryptography.Common;

namespace Cryptography.Cipher
{
    public class CaesarCipher
    {
        private const int DEFAULT_KEY = 3;
        private readonly int key;

        public CaesarCipher(int key = DEFAULT_KEY)
        {
            this.key = key;
        }

        // 암호화
        public string Encrypt(string message)
        {
            char[] a = message.ToCharArray();
            for (int i = 0; i < a.Length; i++) 
            {
                if (char.IsWhiteSpace(a[i])) continue;
                a[i] = (char)('A' + (a[i] - 'A' + key) % 26);
            }

            return new string(a);
        }

        // 복호화
        public string Decrypt(string cipher) 
        {
            char[] a = cipher.ToCharArray();
            for(int i = 0;i < a.Length;i++)
            {
                if (char.IsWhiteSpace(a[i])) continue;

                int ch = (a[i] - 'A' + 26 - key) % 26;
                a[i] = (char)('A' + ch);
            }

            return new string(a);
        }

        // 테스트
        public MessageJson HowToTest()
        {
            string message = "ATTACK WEST CASTLE".ToUpper();
            var caesar = new CaesarCipher();
            string cipher = caesar.Encrypt(message);
            string plain = caesar.Decrypt(cipher);

            MessageJson messageJson = new MessageJson();
            messageJson.Message = message;
            messageJson.Encrypt = cipher;
            messageJson.Decrypt = plain;

            Console.WriteLine($"{message}, {cipher}, {plain}");
            Debug.Assert(cipher == "DWWDFN ZHVW FDVWOH");
            Debug.Assert(message == plain);

            return messageJson;
        }
    }
}
