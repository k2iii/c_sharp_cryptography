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
            this.SuspendLayout();
            // 
            // buttonCaesarCipher
            // 
            this.buttonCaesarCipher.Location = new System.Drawing.Point(12, 12);
            this.buttonCaesarCipher.Name = "buttonCaesarCipher";
            this.buttonCaesarCipher.Size = new System.Drawing.Size(131, 23);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

