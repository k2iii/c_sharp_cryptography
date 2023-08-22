namespace Cryptography
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCaesarCipher = new System.Windows.Forms.Button();
            this.textBoxCaesarCipher = new System.Windows.Forms.TextBox();
            this.textBoxRot13 = new System.Windows.Forms.TextBox();
            this.buttonRot13 = new System.Windows.Forms.Button();
            this.textBoxRandomCipher = new System.Windows.Forms.TextBox();
            this.buttonRandomCipher = new System.Windows.Forms.Button();
            this.textBoxMulticipher = new System.Windows.Forms.TextBox();
            this.buttonMultiCipher = new System.Windows.Forms.Button();
            this.textBoxAffineCipher = new System.Windows.Forms.TextBox();
            this.buttonAffineCipher = new System.Windows.Forms.Button();
            this.textBoxAffineCipher2 = new System.Windows.Forms.TextBox();
            this.buttonAffineCipher2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCaesarCipher
            // 
            this.buttonCaesarCipher.Location = new System.Drawing.Point(12, 12);
            this.buttonCaesarCipher.Name = "buttonCaesarCipher";
            this.buttonCaesarCipher.Size = new System.Drawing.Size(198, 23);
            this.buttonCaesarCipher.TabIndex = 0;
            this.buttonCaesarCipher.Text = "CaesarCipher";
            this.buttonCaesarCipher.UseVisualStyleBackColor = true;
            this.buttonCaesarCipher.Click += new System.EventHandler(this.buttonCaesarCipher_Click);
            // 
            // textBoxCaesarCipher
            // 
            this.textBoxCaesarCipher.Location = new System.Drawing.Point(15, 51);
            this.textBoxCaesarCipher.Multiline = true;
            this.textBoxCaesarCipher.Name = "textBoxCaesarCipher";
            this.textBoxCaesarCipher.Size = new System.Drawing.Size(195, 110);
            this.textBoxCaesarCipher.TabIndex = 1;
            // 
            // textBoxRot13
            // 
            this.textBoxRot13.Location = new System.Drawing.Point(219, 51);
            this.textBoxRot13.Multiline = true;
            this.textBoxRot13.Name = "textBoxRot13";
            this.textBoxRot13.Size = new System.Drawing.Size(195, 110);
            this.textBoxRot13.TabIndex = 3;
            // 
            // buttonRot13
            // 
            this.buttonRot13.Location = new System.Drawing.Point(216, 12);
            this.buttonRot13.Name = "buttonRot13";
            this.buttonRot13.Size = new System.Drawing.Size(198, 23);
            this.buttonRot13.TabIndex = 2;
            this.buttonRot13.Text = "ROT13Cipher";
            this.buttonRot13.UseVisualStyleBackColor = true;
            this.buttonRot13.Click += new System.EventHandler(this.buttonRot13_Click);
            // 
            // textBoxRandomCipher
            // 
            this.textBoxRandomCipher.Location = new System.Drawing.Point(423, 51);
            this.textBoxRandomCipher.Multiline = true;
            this.textBoxRandomCipher.Name = "textBoxRandomCipher";
            this.textBoxRandomCipher.Size = new System.Drawing.Size(195, 110);
            this.textBoxRandomCipher.TabIndex = 5;
            // 
            // buttonRandomCipher
            // 
            this.buttonRandomCipher.Location = new System.Drawing.Point(420, 12);
            this.buttonRandomCipher.Name = "buttonRandomCipher";
            this.buttonRandomCipher.Size = new System.Drawing.Size(198, 23);
            this.buttonRandomCipher.TabIndex = 4;
            this.buttonRandomCipher.Text = "RandomCipher";
            this.buttonRandomCipher.UseVisualStyleBackColor = true;
            this.buttonRandomCipher.Click += new System.EventHandler(this.buttonRandomCipher_Click);
            // 
            // textBoxMulticipher
            // 
            this.textBoxMulticipher.Location = new System.Drawing.Point(627, 51);
            this.textBoxMulticipher.Multiline = true;
            this.textBoxMulticipher.Name = "textBoxMulticipher";
            this.textBoxMulticipher.Size = new System.Drawing.Size(195, 110);
            this.textBoxMulticipher.TabIndex = 7;
            // 
            // buttonMultiCipher
            // 
            this.buttonMultiCipher.Location = new System.Drawing.Point(624, 12);
            this.buttonMultiCipher.Name = "buttonMultiCipher";
            this.buttonMultiCipher.Size = new System.Drawing.Size(198, 23);
            this.buttonMultiCipher.TabIndex = 6;
            this.buttonMultiCipher.Text = "MultiCipher";
            this.buttonMultiCipher.UseVisualStyleBackColor = true;
            this.buttonMultiCipher.Click += new System.EventHandler(this.buttonMultiCipher_Click);
            // 
            // textBoxAffineCipher
            // 
            this.textBoxAffineCipher.Location = new System.Drawing.Point(831, 51);
            this.textBoxAffineCipher.Multiline = true;
            this.textBoxAffineCipher.Name = "textBoxAffineCipher";
            this.textBoxAffineCipher.Size = new System.Drawing.Size(195, 110);
            this.textBoxAffineCipher.TabIndex = 9;
            // 
            // buttonAffineCipher
            // 
            this.buttonAffineCipher.Location = new System.Drawing.Point(828, 12);
            this.buttonAffineCipher.Name = "buttonAffineCipher";
            this.buttonAffineCipher.Size = new System.Drawing.Size(198, 23);
            this.buttonAffineCipher.TabIndex = 8;
            this.buttonAffineCipher.Text = "AffineCipher";
            this.buttonAffineCipher.UseVisualStyleBackColor = true;
            this.buttonAffineCipher.Click += new System.EventHandler(this.buttonAffineCipher_Click);
            // 
            // textBoxAffineCipher2
            // 
            this.textBoxAffineCipher2.Location = new System.Drawing.Point(1035, 51);
            this.textBoxAffineCipher2.Multiline = true;
            this.textBoxAffineCipher2.Name = "textBoxAffineCipher2";
            this.textBoxAffineCipher2.Size = new System.Drawing.Size(195, 110);
            this.textBoxAffineCipher2.TabIndex = 11;
            // 
            // buttonAffineCipher2
            // 
            this.buttonAffineCipher2.Location = new System.Drawing.Point(1032, 12);
            this.buttonAffineCipher2.Name = "buttonAffineCipher2";
            this.buttonAffineCipher2.Size = new System.Drawing.Size(198, 23);
            this.buttonAffineCipher2.TabIndex = 10;
            this.buttonAffineCipher2.Text = "AffineCipher2";
            this.buttonAffineCipher2.UseVisualStyleBackColor = true;
            this.buttonAffineCipher2.Click += new System.EventHandler(this.buttonAffineCipher2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 450);
            this.Controls.Add(this.textBoxAffineCipher2);
            this.Controls.Add(this.buttonAffineCipher2);
            this.Controls.Add(this.textBoxAffineCipher);
            this.Controls.Add(this.buttonAffineCipher);
            this.Controls.Add(this.textBoxMulticipher);
            this.Controls.Add(this.buttonMultiCipher);
            this.Controls.Add(this.textBoxRandomCipher);
            this.Controls.Add(this.buttonRandomCipher);
            this.Controls.Add(this.textBoxRot13);
            this.Controls.Add(this.buttonRot13);
            this.Controls.Add(this.textBoxCaesarCipher);
            this.Controls.Add(this.buttonCaesarCipher);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCaesarCipher;
        private System.Windows.Forms.TextBox textBoxCaesarCipher;
        private System.Windows.Forms.TextBox textBoxRot13;
        private System.Windows.Forms.Button buttonRot13;
        private System.Windows.Forms.TextBox textBoxRandomCipher;
        private System.Windows.Forms.Button buttonRandomCipher;
        private System.Windows.Forms.TextBox textBoxMulticipher;
        private System.Windows.Forms.Button buttonMultiCipher;
        private System.Windows.Forms.TextBox textBoxAffineCipher;
        private System.Windows.Forms.Button buttonAffineCipher;
        private System.Windows.Forms.TextBox textBoxAffineCipher2;
        private System.Windows.Forms.Button buttonAffineCipher2;
    }
}

