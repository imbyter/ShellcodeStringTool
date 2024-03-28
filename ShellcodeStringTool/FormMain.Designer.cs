namespace ShellcodeStringTool
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtUnicode = new System.Windows.Forms.TextBox();
            this.btnCopyUnicode = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAnsi = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnCopyAnsi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCopyCode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chckUnicode = new System.Windows.Forms.CheckBox();
            this.txtCipherText = new System.Windows.Forms.TextBox();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.btnExample = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnCopyCipherText = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 428);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtUnicode);
            this.tabPage2.Controls.Add(this.btnCopyUnicode);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtAnsi);
            this.tabPage2.Controls.Add(this.txtSource);
            this.tabPage2.Controls.Add(this.btnCopyAnsi);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(638, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "简单转换";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtUnicode
            // 
            this.txtUnicode.Location = new System.Drawing.Point(79, 252);
            this.txtUnicode.Multiline = true;
            this.txtUnicode.Name = "txtUnicode";
            this.txtUnicode.Size = new System.Drawing.Size(514, 83);
            this.txtUnicode.TabIndex = 38;
            // 
            // btnCopyUnicode
            // 
            this.btnCopyUnicode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyUnicode.Location = new System.Drawing.Point(79, 347);
            this.btnCopyUnicode.Name = "btnCopyUnicode";
            this.btnCopyUnicode.Size = new System.Drawing.Size(514, 30);
            this.btnCopyUnicode.TabIndex = 37;
            this.btnCopyUnicode.Text = "复制";
            this.btnCopyUnicode.UseVisualStyleBackColor = true;
            this.btnCopyUnicode.Click += new System.EventHandler(this.btnCopyUnicode_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F);
            this.label7.Location = new System.Drawing.Point(20, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 36;
            this.label7.Text = "UNICODE:";
            // 
            // txtAnsi
            // 
            this.txtAnsi.Location = new System.Drawing.Point(79, 103);
            this.txtAnsi.Multiline = true;
            this.txtAnsi.Name = "txtAnsi";
            this.txtAnsi.Size = new System.Drawing.Size(514, 83);
            this.txtAnsi.TabIndex = 35;
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(79, 28);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(514, 53);
            this.txtSource.TabIndex = 31;
            this.txtSource.TextChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // btnCopyAnsi
            // 
            this.btnCopyAnsi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyAnsi.Location = new System.Drawing.Point(79, 198);
            this.btnCopyAnsi.Name = "btnCopyAnsi";
            this.btnCopyAnsi.Size = new System.Drawing.Size(514, 30);
            this.btnCopyAnsi.TabIndex = 34;
            this.btnCopyAnsi.Text = "复制";
            this.btnCopyAnsi.UseVisualStyleBackColor = true;
            this.btnCopyAnsi.Click += new System.EventHandler(this.btnCopyAnsi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F);
            this.label5.Location = new System.Drawing.Point(38, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 33;
            this.label5.Text = "ANSI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F);
            this.label6.Location = new System.Drawing.Point(26, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 32;
            this.label6.Text = "字符串:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCopyCode);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.chckUnicode);
            this.tabPage1.Controls.Add(this.txtCipherText);
            this.tabPage1.Controls.Add(this.txtPlainText);
            this.tabPage1.Controls.Add(this.btnExample);
            this.tabPage1.Controls.Add(this.btnClearAll);
            this.tabPage1.Controls.Add(this.btnCopyCipherText);
            this.tabPage1.Controls.Add(this.btnEncrypt);
            this.tabPage1.Controls.Add(this.txtKey);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(638, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "加密转换";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCopyCode
            // 
            this.btnCopyCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyCode.Location = new System.Drawing.Point(472, 355);
            this.btnCopyCode.Name = "btnCopyCode";
            this.btnCopyCode.Size = new System.Drawing.Size(102, 20);
            this.btnCopyCode.TabIndex = 33;
            this.btnCopyCode.Text = "[ 复制算法 ]";
            this.btnCopyCode.UseVisualStyleBackColor = true;
            this.btnCopyCode.Click += new System.EventHandler(this.btnCopyCode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(76, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 12);
            this.label1.TabIndex = 32;
            this.label1.Text = "采用微型加密算法（Tiny Encryption Algorithm）加密算法，简洁高效";
            // 
            // chckUnicode
            // 
            this.chckUnicode.AutoSize = true;
            this.chckUnicode.Location = new System.Drawing.Point(414, 112);
            this.chckUnicode.Name = "chckUnicode";
            this.chckUnicode.Size = new System.Drawing.Size(156, 16);
            this.chckUnicode.TabIndex = 31;
            this.chckUnicode.Text = " 字符串为 Unicode 编码";
            this.chckUnicode.UseVisualStyleBackColor = true;
            this.chckUnicode.CheckedChanged += new System.EventHandler(this.chckUnicode_CheckedChanged);
            // 
            // txtCipherText
            // 
            this.txtCipherText.Location = new System.Drawing.Point(78, 152);
            this.txtCipherText.Multiline = true;
            this.txtCipherText.Name = "txtCipherText";
            this.txtCipherText.Size = new System.Drawing.Size(496, 127);
            this.txtCipherText.TabIndex = 30;
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(78, 28);
            this.txtPlainText.Multiline = true;
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(281, 100);
            this.txtPlainText.TabIndex = 20;
            this.txtPlainText.TextChanged += new System.EventHandler(this.txtPlainText_TextChanged);
            // 
            // btnExample
            // 
            this.btnExample.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExample.Location = new System.Drawing.Point(489, 66);
            this.btnExample.Name = "btnExample";
            this.btnExample.Size = new System.Drawing.Size(85, 28);
            this.btnExample.TabIndex = 29;
            this.btnExample.Text = "随机密钥";
            this.btnExample.UseVisualStyleBackColor = true;
            this.btnExample.Click += new System.EventHandler(this.btnExample_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearAll.Location = new System.Drawing.Point(472, 295);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(102, 30);
            this.btnClearAll.TabIndex = 28;
            this.btnClearAll.Text = "清空";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnCopyCipherText
            // 
            this.btnCopyCipherText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyCipherText.Location = new System.Drawing.Point(78, 295);
            this.btnCopyCipherText.Name = "btnCopyCipherText";
            this.btnCopyCipherText.Size = new System.Drawing.Size(372, 30);
            this.btnCopyCipherText.TabIndex = 27;
            this.btnCopyCipherText.Text = "复制处理后内容";
            this.btnCopyCipherText.UseVisualStyleBackColor = true;
            this.btnCopyCipherText.Click += new System.EventHandler(this.btnCopyCipherText_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncrypt.Location = new System.Drawing.Point(414, 66);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(69, 28);
            this.btnEncrypt.TabIndex = 25;
            this.btnEncrypt.Text = "加密";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(414, 28);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(160, 21);
            this.txtKey.TabIndex = 24;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F);
            this.label4.Location = new System.Drawing.Point(372, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "密钥:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F);
            this.label3.Location = new System.Drawing.Point(26, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "处理后:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F);
            this.label2.Location = new System.Drawing.Point(26, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "字符串:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 428);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sst [ imbyter.com ]";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCopyCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chckUnicode;
        private System.Windows.Forms.TextBox txtCipherText;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.Button btnExample;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnCopyCipherText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnsi;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnCopyAnsi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnicode;
        private System.Windows.Forms.Button btnCopyUnicode;
        private System.Windows.Forms.Label label7;
    }
}

