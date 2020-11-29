namespace Laba4EXAMPLE
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
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnRefill = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtInfo
            // 
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Location = new System.Drawing.Point(12, 12);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(505, 46);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.Text = "";
            this.txtInfo.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(297, 176);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(220, 144);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Взять";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefill
            // 
            this.btnRefill.Location = new System.Drawing.Point(12, 64);
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.Size = new System.Drawing.Size(505, 106);
            this.btnRefill.TabIndex = 2;
            this.btnRefill.Text = "Перезаполнить";
            this.btnRefill.UseVisualStyleBackColor = true;
            this.btnRefill.Click += new System.EventHandler(this.btnRefill_Click);
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(13, 176);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(278, 144);
            this.txtOut.TabIndex = 3;
            this.txtOut.Text = "";
            this.txtOut.TextChanged += new System.EventHandler(this.txtOut_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 332);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.btnRefill);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtInfo;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnRefill;
        private System.Windows.Forms.RichTextBox txtOut;
    }
}

