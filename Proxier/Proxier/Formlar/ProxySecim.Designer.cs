﻿
namespace Proxier.Formlar
{
    partial class ProxySecim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProxySecim));
            this.secmeButton = new System.Windows.Forms.Button();
            this.yolTextBox = new System.Windows.Forms.TextBox();
            this.proxyBilgi = new System.Windows.Forms.Label();
            this.proxyBox = new System.Windows.Forms.TextBox();
            this.tamamButton = new System.Windows.Forms.Button();
            this.listeYaziLabel = new System.Windows.Forms.Label();
            this.TbUrl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // secmeButton
            // 
            this.secmeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.secmeButton.Location = new System.Drawing.Point(277, 62);
            this.secmeButton.Name = "secmeButton";
            this.secmeButton.Size = new System.Drawing.Size(27, 20);
            this.secmeButton.TabIndex = 0;
            this.secmeButton.Text = "...";
            this.secmeButton.UseVisualStyleBackColor = true;
            this.secmeButton.Click += new System.EventHandler(this.secmeButton_Click);
            // 
            // yolTextBox
            // 
            this.yolTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yolTextBox.Location = new System.Drawing.Point(12, 63);
            this.yolTextBox.Name = "yolTextBox";
            this.yolTextBox.ReadOnly = true;
            this.yolTextBox.Size = new System.Drawing.Size(259, 20);
            this.yolTextBox.TabIndex = 1;
            // 
            // proxyBilgi
            // 
            this.proxyBilgi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proxyBilgi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proxyBilgi.Location = new System.Drawing.Point(9, 9);
            this.proxyBilgi.Name = "proxyBilgi";
            this.proxyBilgi.Size = new System.Drawing.Size(295, 30);
            this.proxyBilgi.TabIndex = 2;
            this.proxyBilgi.Text = "Proxyleri aşağıya manuel olarak IP:PORT olarak girebilir ya da proxyleri içeren ." +
    "txt dosyasını seçebilirsiniz.";
            // 
            // proxyBox
            // 
            this.proxyBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proxyBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proxyBox.Location = new System.Drawing.Point(12, 157);
            this.proxyBox.Multiline = true;
            this.proxyBox.Name = "proxyBox";
            this.proxyBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.proxyBox.Size = new System.Drawing.Size(292, 242);
            this.proxyBox.TabIndex = 3;
            this.proxyBox.TextChanged += new System.EventHandler(this.proxyBox_TextChanged);
            // 
            // tamamButton
            // 
            this.tamamButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tamamButton.Enabled = false;
            this.tamamButton.Location = new System.Drawing.Point(12, 405);
            this.tamamButton.Name = "tamamButton";
            this.tamamButton.Size = new System.Drawing.Size(292, 26);
            this.tamamButton.TabIndex = 4;
            this.tamamButton.Text = "Tamam";
            this.tamamButton.UseVisualStyleBackColor = true;
            this.tamamButton.Click += new System.EventHandler(this.tamamButton_Click);
            // 
            // listeYaziLabel
            // 
            this.listeYaziLabel.AutoSize = true;
            this.listeYaziLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeYaziLabel.Location = new System.Drawing.Point(12, 127);
            this.listeYaziLabel.Name = "listeYaziLabel";
            this.listeYaziLabel.Size = new System.Drawing.Size(75, 15);
            this.listeYaziLabel.TabIndex = 5;
            this.listeYaziLabel.Text = "Proxy Listesi:";
            // 
            // TbUrl
            // 
            this.TbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbUrl.Location = new System.Drawing.Point(12, 104);
            this.TbUrl.Name = "TbUrl";
            this.TbUrl.Size = new System.Drawing.Size(259, 20);
            this.TbUrl.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(277, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "Yükle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dosya";
            // 
            // ProxySecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TbUrl);
            this.Controls.Add(this.listeYaziLabel);
            this.Controls.Add(this.tamamButton);
            this.Controls.Add(this.proxyBox);
            this.Controls.Add(this.proxyBilgi);
            this.Controls.Add(this.yolTextBox);
            this.Controls.Add(this.secmeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProxySecim";
            this.Text = "Proxier 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProxySecim_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button secmeButton;
        private System.Windows.Forms.TextBox yolTextBox;
        private System.Windows.Forms.Label proxyBilgi;
        private System.Windows.Forms.TextBox proxyBox;
        private System.Windows.Forms.Button tamamButton;
        private System.Windows.Forms.Label listeYaziLabel;
        private System.Windows.Forms.TextBox TbUrl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}