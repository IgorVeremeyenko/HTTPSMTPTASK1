namespace HTTPSMTPTASK1
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
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Request = new System.Windows.Forms.Button();
            this.groupBoxStatusCode = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxResponseBody = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBoxStatusCode.SuspendLayout();
            this.groupBoxResponseBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(38, 32);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(332, 20);
            this.textBoxUrl.TabIndex = 0;
            this.textBoxUrl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите URL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Request
            // 
            this.Request.Location = new System.Drawing.Point(398, 28);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(116, 23);
            this.Request.TabIndex = 2;
            this.Request.Text = "Получить ответ";
            this.Request.UseVisualStyleBackColor = true;
            this.Request.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // groupBoxStatusCode
            // 
            this.groupBoxStatusCode.Controls.Add(this.label2);
            this.groupBoxStatusCode.Location = new System.Drawing.Point(38, 85);
            this.groupBoxStatusCode.Name = "groupBoxStatusCode";
            this.groupBoxStatusCode.Size = new System.Drawing.Size(332, 61);
            this.groupBoxStatusCode.TabIndex = 3;
            this.groupBoxStatusCode.TabStop = false;
            this.groupBoxStatusCode.Text = "Код ответа";
            this.groupBoxStatusCode.Enter += new System.EventHandler(this.groupBoxStatusCode_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // groupBoxResponseBody
            // 
            this.groupBoxResponseBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResponseBody.Controls.Add(this.webBrowser1);
            this.groupBoxResponseBody.Location = new System.Drawing.Point(38, 163);
            this.groupBoxResponseBody.Name = "groupBoxResponseBody";
            this.groupBoxResponseBody.Size = new System.Drawing.Size(750, 275);
            this.groupBoxResponseBody.TabIndex = 5;
            this.groupBoxResponseBody.TabStop = false;
            this.groupBoxResponseBody.Text = "Тело ответа";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(3, 16);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(744, 256);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxResponseBody);
            this.Controls.Add(this.groupBoxStatusCode);
            this.Controls.Add(this.Request);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxStatusCode.ResumeLayout(false);
            this.groupBoxStatusCode.PerformLayout();
            this.groupBoxResponseBody.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Request;
        private System.Windows.Forms.GroupBox groupBoxStatusCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxResponseBody;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

