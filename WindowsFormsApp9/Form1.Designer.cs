namespace WindowsFormsApp9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.RichTextBox();
            this.text = new System.Windows.Forms.RichTextBox();
            this.result = new System.Windows.Forms.RichTextBox();
            this.generete = new System.Windows.Forms.Button();
            this.iv = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "decrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "text for encrypt or decrypt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "result";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(26, 38);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(910, 65);
            this.password.TabIndex = 9;
            this.password.Text = "";
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(25, 138);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(350, 227);
            this.text.TabIndex = 10;
            this.text.Text = "";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(582, 138);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(350, 227);
            this.result.TabIndex = 11;
            this.result.Text = "";
            // 
            // generete
            // 
            this.generete.Location = new System.Drawing.Point(406, 238);
            this.generete.Name = "generete";
            this.generete.Size = new System.Drawing.Size(157, 44);
            this.generete.TabIndex = 8;
            this.generete.Text = "Generate ";
            this.generete.UseVisualStyleBackColor = true;
            this.generete.Click += new System.EventHandler(this.button3_Click);
            // 
            // iv
            // 
            this.iv.Location = new System.Drawing.Point(409, 304);
            this.iv.Name = "iv";
            this.iv.Size = new System.Drawing.Size(153, 44);
            this.iv.TabIndex = 12;
            this.iv.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 388);
            this.Controls.Add(this.iv);
            this.Controls.Add(this.result);
            this.Controls.Add(this.text);
            this.Controls.Add(this.password);
            this.Controls.Add(this.generete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox password;
        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.Button generete;
        private System.Windows.Forms.RichTextBox iv;
    }
}

