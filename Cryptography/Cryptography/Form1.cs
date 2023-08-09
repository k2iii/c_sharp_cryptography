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
    }
}
