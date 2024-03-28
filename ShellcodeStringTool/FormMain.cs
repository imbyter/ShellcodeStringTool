using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShellcodeStringTool
{
    public partial class FormMain : Form
    {
        private string ciphertext;

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (txtPlainText.TextLength == 0)
            {
                this.Text = "请输入字符串";
            }
            else if (txtKey.TextLength != 16)
            {
                this.Text = "密钥必须为16个字节长度（128比特）！";
            }
            else
            {
                TEA tea = new TEA();

                int n = txtPlainText.Text.Length / 8 + 1;

                if (chckUnicode.Checked == true)
                {
                    ciphertext = tea.Encrypt(txtPlainText.Text, txtKey.Text, true);
                    n *= 2;
                }
                else
                {
                    ciphertext = tea.Encrypt(txtPlainText.Text, txtKey.Text, false);
                }


                string sParamName = "LPBYTE_" + CreateName(txtPlainText.Text);

                if (chckUnicode.Checked == true)
                {
                    ciphertext = "// Unicode: " + txtPlainText.Text + "\r\n" + "BYTE " + sParamName + "[] = {" + ciphertext + "};\r\n";
                }
                else
                {
                    ciphertext = "// ANSI: " + txtPlainText.Text + "\r\n" + "BYTE " + sParamName + "[] = {" + ciphertext + "};\r\n";
                }

                ciphertext = ciphertext + "// 解密处理\r\n";
                ciphertext = ciphertext + "CTea::tea_decrypt(" + sParamName + "," + n.ToString() + ");";
                txtCipherText.Text = ciphertext;

                this.Text = "字符串已被加密！";
            }
        }

        private void btnExample_Click(object sender, EventArgs e)
        {
            txtKey.Text = GetRandomString(16, true, true, true, false, null);
            if (txtPlainText.Text.Length != 0)
            {
                btnEncrypt_Click(sender, e);
                this.Text = "字符串已被加密！";
            }
            else
            {
                this.Text = "sst [ imbyter.com ]";
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (txtKey.TextLength != 0 || txtPlainText.TextLength != 0 || txtPlainText.TextLength != 0)
            {
                //txtKey.Text = "";
                txtPlainText.Text = "";
                txtCipherText.Text = "";
            }
            this.Text = "sst [ imbyter.com ]";
        }

        private void btnCopyCipherText_Click(object sender, EventArgs e)
        {
            if (txtCipherText.TextLength != 0)
            {
                Clipboard.SetText(txtCipherText.Text);
                this.Text = "[+] 内容已复制！";
            }
            else
            {
                this.Text = "sst [ imbyter.com ]";
            }
        }
        public static string GetRandomString(int length, bool useNum, bool useLow, bool useUpp, bool useSpe, string custom)
        {
            byte[] b = new byte[4];
            new System.Security.Cryptography.RNGCryptoServiceProvider().GetBytes(b);
            Random r = new Random(BitConverter.ToInt32(b, 0));
            string s = null, str = custom;
            if (useNum == true) { str += "0123456789"; }
            if (useLow == true) { str += "abcdefghijklmnopqrstuvwxyz"; }
            if (useUpp == true) { str += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; }
            if (useSpe == true) { str += "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~"; }
            for (int i = 0; i < length; i++)
            {
                s += str.Substring(r.Next(0, str.Length - 1), 1);
            }
            return s;
        }

        private void chckUnicode_CheckedChanged(object sender, EventArgs e)
        {
            if (txtKey.Text.Length == 16 && txtPlainText.Text.Length != 0)
            {
                btnEncrypt_Click(sender, e);
                this.Text = "字符串已被加密！";
            }
            this.Text = "sst [ imbyter.com ]";
        }

        private void txtPlainText_TextChanged(object sender, EventArgs e)
        {
            if (txtKey.Text.Length == 16)
            {
                btnEncrypt_Click(sender, e);
                this.Text = "字符串已被加密！";
            }
            else
            {
                this.Text = "密钥必须为16个字节长度（128比特）！";
                txtKey.SelectAll();
                txtKey.Focus();
            }
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            this.Text = "sst [ imbyter.com ]";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            txtKey.Text = "uCa4iz01vb6mA58Q";
        }

        public static string CreateName(string s)
        {
            string strReturn = string.Empty;
            if (s == null || s.Trim() == "")
            {
                return strReturn;
            }

            foreach (char chrTemp in s)
            {
                if (Char.IsLetter(chrTemp) || Char.IsNumber(chrTemp))
                {
                    strReturn += chrTemp.ToString();
                    if (strReturn.Length == 30)
                    {
                        break;
                    }
                }
            }
            return strReturn;
        }

        private void btnCopyCode_Click(object sender, EventArgs e)
        {
            string s =
                @"
// this is a tea.h file

#pragma once

#include <stdio.h>
#include <windows.h>

class CTea
{
public:
	static void tea_encrypt(unsigned char *Data, int BlockCount)
	{
		//const unsigned char *Key = CGlobal::Object()->g_teaKey; 
		const char *Key = ""uCa4iz01vb6mA58Q"";

        unsigned int y, z, sum, i, j;
            unsigned int delta = 0x9e3779b9;  /* a key schedule constant */
            unsigned int a = 0, b = 0, c = 0, d = 0;   /* cache key */

            a = (unsigned int)((Key[3] << 24) | (Key[2] << 16) | (Key[1] << 8) | Key[0]);
            b = (unsigned int)((Key[7] << 24) | (Key[6] << 16) | (Key[5] << 8) | Key[4]);
            c = (unsigned int)((Key[11] << 24) | (Key[10] << 16) | (Key[9] << 8) | Key[8]);
            d = (unsigned int)((Key[15] << 24) | (Key[14] << 16) | (Key[13] << 8) | Key[12]);

            for (i = 0; i < (unsigned)BlockCount; i++)
            {
                sum = 0;
                y = (unsigned int)((Data[i * 8 + 0] << 24) | (Data[i * 8 + 1] << 16) | (Data[i * 8 + 2] << 8) | Data[i * 8 + 3]);
            z = (unsigned int)((Data[i * 8 + 4] << 24) | (Data[i * 8 + 5] << 16) | (Data[i * 8 + 6] << 8) | Data[i * 8 + 7]);

            for (j = 0; j < 32; j++)
            {
                sum += delta;
                y += ((z << 4) + a) ^ (z + sum) ^ ((z >> 5) + b);
                z += ((y << 4) + c) ^ (y + sum) ^ ((y >> 5) + d);
            }
            Data[i * 8 + 0] = (unsigned char)((y >> 24) & 0xFF);
            Data[i * 8 + 1] = (unsigned char)((y >> 16) & 0xFF);
            Data[i * 8 + 2] = (unsigned char)((y >> 8) & 0xFF);
            Data[i * 8 + 3] = (unsigned char)((y >> 0) & 0xFF);
            Data[i * 8 + 4] = (unsigned char)((z >> 24) & 0xFF);
            Data[i * 8 + 5] = (unsigned char)((z >> 16) & 0xFF);
            Data[i * 8 + 6] = (unsigned char)((z >> 8) & 0xFF);
            Data[i * 8 + 7] = (unsigned char)((z >> 0) & 0xFF);
        }
    }
    static void tea_decrypt(unsigned char* Data, int BlockCount)
    {
        //const unsigned char *Key = CGlobal::Object()->g_teaKey; 
        const char* Key = ""uCa4iz01vb6mA58Q"";

        unsigned int y, z, sum, i, j; /* set up */
        unsigned int delta = 0x9e3779b9; /* a key schedule constant */
        unsigned int a, b, c, d;    /* cache key */

        a = (unsigned int)((Key[3] << 24) | (Key[2] << 16) | (Key[1] << 8) | Key[0]);
        b = (unsigned int)((Key[7] << 24) | (Key[6] << 16) | (Key[5] << 8) | Key[4]);
        c = (unsigned int)((Key[11] << 24) | (Key[10] << 16) | (Key[9] << 8) | Key[8]);
        d = (unsigned int)((Key[15] << 24) | (Key[14] << 16) | (Key[13] << 8) | Key[12]);

        for (i = 0; i < (unsigned)BlockCount; i++)
        {
            sum = 0xC6EF3720;
            y = (unsigned int)((Data[i * 8 + 0] << 24) | (Data[i * 8 + 1] << 16) | (Data[i * 8 + 2] << 8) | Data[i * 8 + 3]);
        z = (unsigned int)((Data[i * 8 + 4] << 24) | (Data[i * 8 + 5] << 16) | (Data[i * 8 + 6] << 8) | Data[i * 8 + 7]);
        for (j = 0; j < 32; j++)
        {
            z -= ((y << 4) + c) ^ (y + sum) ^ ((y >> 5) + d);
            y -= ((z << 4) + a) ^ (z + sum) ^ ((z >> 5) + b);
            sum -= delta;
        }
        Data[i * 8 + 0] = (unsigned char)((y >> 24) & 0xFF);
        Data[i * 8 + 1] = (unsigned char)((y >> 16) & 0xFF);
        Data[i * 8 + 2] = (unsigned char)((y >> 8) & 0xFF);
        Data[i * 8 + 3] = (unsigned char)((y >> 0) & 0xFF);
        Data[i * 8 + 4] = (unsigned char)((z >> 24) & 0xFF);
        Data[i * 8 + 5] = (unsigned char)((z >> 16) & 0xFF);
        Data[i * 8 + 6] = (unsigned char)((z >> 8) & 0xFF);
        Data[i * 8 + 7] = (unsigned char)((z >> 0) & 0xFF);
    }
}
}; ";
            Clipboard.SetText(s);
            this.Text = "[+] 代码已复制！";
        }

        private void txtSource_TextChanged(object sender, EventArgs e)
        {
            this.Text = "sst [ imbyter.com ]";

            string sAnsi = "";
            string sUnicode = "";
            for (int i = 0; i < txtSource.Text.Length; i++)
            {
                if(txtSource.Text[i] == '\\')
                {
                    sAnsi += "'\\\\',";
                    sUnicode += "L'\\\\',";
                }
                else
                {
                    sAnsi += "'" + txtSource.Text[i] + "',";
                    sUnicode += "L'" + txtSource.Text[i] + "',";
                }
            }

            if (txtSource.Text.Length != 0)
            {
                sAnsi += "0";
                sUnicode += "0";
            }

            txtAnsi.Text = "// ANSI: " + txtSource.Text + "\r\n" + "char " + "PCHAR_" + CreateName(txtSource.Text) + "[] = { " + sAnsi + " };\r\n";
            txtUnicode.Text = "// Unicode: " + txtSource.Text + "\r\n" + "wchar_t " + "PWCHAR_" + CreateName(txtSource.Text) + "[] = { " + sUnicode + " };\r\n";
        }

        private void btnCopyAnsi_Click(object sender, EventArgs e)
        {
            if (txtAnsi.TextLength != 0)
            {
                Clipboard.SetText(txtAnsi.Text);
                this.Text = "[+] ANSI内容已复制！";
            }
            else
            {
                this.Text = "sst [ imbyter.com ]";
            }
        }

        private void btnCopyUnicode_Click(object sender, EventArgs e)
        {
            if (txtUnicode.TextLength != 0)
            {
                Clipboard.SetText(txtUnicode.Text);
                this.Text = "[+] UNICODE内容已复制！";
            }
            else
            {
                this.Text = "sst [ imbyter.com ]";
            }
        }
    }
}
