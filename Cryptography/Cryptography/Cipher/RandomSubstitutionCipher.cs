using Cryptography.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography.Cipher
{
    public class RandomSubstitutionCipher
    {
        // 랜덤 매핑 테이블
        private char[] table;
            
        public MessageJson test(string keyTable = null)
        {
            // 외부에서 키를 제공할 경우 그 키를 사용
            if (keyTable != null)
            {
                Debug.Assert(keyTable.Length == 26);
                table = keyTable.ToCharArray();
            }
            // 키가 제공되지 않으면 키를 생성함
            else
            {
                table = CreateRandomTable();
                Debug.WriteLine(string.Join("", table));
            }

            MessageJson json = new MessageJson();
            json.Message = new string(table);

            return json;
        }

        // A ~ Z 중 랜덤하게 하나씩 골라 랜덤테이블에 저장한 후,
        // A ~ Z 리스트에서 선택된 것을 제거하면서 루프를 돈다.
        private char[] CreateRandomTable()
        {
            List<char> randomTable = new List<char>();
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToList();
            Random random = new Random();

            while (alphabet.Count > 0) 
            {
                int rand = random.Next(0, alphabet.Count - 1);
                randomTable.Add(alphabet[rand]);
                alphabet.RemoveAt(rand);
            }

            return randomTable.ToArray();
        }
    }
}
