using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cryptography.Cipher;
using Cryptography.Common;

namespace Cryptography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCaesarCipher_Click(object sender, EventArgs e)
        {
            CaesarCipher caesarCipher = new CaesarCipher();
            MessageJson message = caesarCipher.HowToTest();
            this.textBoxCaesarCipher.Text = $"{message.Message}\r\n{message.Encrypt}\r\n{message.Decrypt}";
        }

        private void buttonRot13_Click(object sender, EventArgs e)
        {
            Rot13Cipher rot13Cipher = new Rot13Cipher();
            MessageJson message = rot13Cipher.HowToTest();
            this.textBoxRot13.Text = $"{message.Message}\r\n{message.Encrypt}\r\n{message.Decrypt}";
        }

        private void buttonRandomCipher_Click(object sender, EventArgs e)
        {
            RandomSubstitutionCipher random = new RandomSubstitutionCipher();
            MessageJson message = random.test();
            this.textBoxRandomCipher.Text = $"{message.Message}";
        }

        private void buttonMultiCipher_Click(object sender, EventArgs e)
        {
            MultiCipher multiCipher = new MultiCipher();
            MessageJson message = multiCipher.HowToTest();
            this.textBoxMulticipher.Text = $"{message.Message}\r\n{message.Encrypt}\r\n{message.Decrypt}";
        }

        private void buttonAffineCipher_Click(object sender, EventArgs e)
        {
            // C = 7 * P + 5;
            AffineCipher affineCipher = new AffineCipher(7, 5);
            MessageJson message = affineCipher.HowToTest();
            this.textBoxAffineCipher.Text = $"{message.Message}\r\n{message.Encrypt}\r\n{message.Decrypt}";
        }

        private void buttonAffineCipher2_Click(object sender, EventArgs e)
        {
            // C = 7 * P + 5;
            AffineCipher2 affineCipher2 = new AffineCipher2(7, 5);
            MessageJson message = affineCipher2.HowToTest();
            this.textBoxAffineCipher2.Text = $"{message.Message}\r\n{message.Encrypt}\r\n{message.Decrypt}";
        }
    }
}
