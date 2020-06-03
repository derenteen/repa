using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
       
        private int BlockSize = 128;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (password.Text == "") return;
            if (text.Text == "") return;
            if (iv.Text == "") return;
            byte[] bytes = Encoding.Unicode.GetBytes(text.Text);
            //Encrypt
            Aes aes = Aes.Create();
            HashAlgorithm hash = MD5.Create();
            
            aes.BlockSize = BlockSize;
            aes.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(password.Text));
            aes.IV = Convert.FromBase64String(iv.Text);

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(bytes, 0, bytes.Length);
                }

                result.Text = Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (password.Text == "") return;
            if (text.Text == "") return;
            if (iv.Text == "") return;
            
            byte[] bytes = Convert.FromBase64String(text.Text);
            Aes aes = Aes.Create();
            HashAlgorithm hash = MD5.Create();
            aes.BlockSize=BlockSize;
            aes.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(password.Text));
            aes.IV = Convert.FromBase64String(iv.Text);

            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    byte[] decryptedBytes = new byte[bytes.Length];
                    cryptoStream.Read(decryptedBytes, 0, decryptedBytes.Length);
                    result.Text = Encoding.Unicode.GetString(decryptedBytes);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Aes aes = Aes.Create();
            aes.GenerateKey();
            aes.GenerateIV();
            iv.Text = Convert.ToBase64String(aes.IV);
            password.Text = Convert.ToBase64String(aes.Key);

        }

      
    }
}
