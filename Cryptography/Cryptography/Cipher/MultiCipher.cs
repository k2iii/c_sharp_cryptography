using Cryptography.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography.Cipher
{
    public class MultiCipher
    {
        // 암호화
        public string Encrypt(string message, int key)
        {
            char[] a = message.ToCharArray();

            for (int i = 0; i < a.Length; i++)
            {
                if (!char.IsWhiteSpace(a[i]))
                {
                    a[i] = (char)('A' + ((a[i] - 'A') * key) % 26);
                }
            }

            return new string(a);
        }

        // 복호화
        public string Decrypt(string message, int key)
        {
            char[] a = message.ToCharArray();

            // 곱셈 역원을 계산
            int inverseKey = GetMultiplicativeInverse(key);

            for (int i = 0; i < a.Length; i++)
            {
                if (!char.IsWhiteSpace(a[i]))
                {
                    a[i] = (char)('A' + ((a[i] - 'A') * inverseKey) % 26);
                }
            }

            return new string(a);
        }

        // 알파벳에 대한 곱셈 역원 구하기
        private int GetMultiplicativeInverse(int key)
        {
            // 1 ~ 25까지 순차적으로 대입하여
            //  역원을 찾아냄
            for (int i = 0; i < 26; i++)
            {
                if ((key * i) % 26 == 1)
                {
                    return i;
                }
            }

            throw new InvalidCastException(); 
        }

        public MessageJson HowToTest()
        {
            string message = "ATTACK WEST CASTLE".ToUpper();
            int key = 7;
            string cipher = Encrypt(message, key);
            string plain = Decrypt(cipher, key);

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
