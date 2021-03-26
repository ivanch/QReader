
namespace QReader
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.readClipboard = new System.Windows.Forms.Button();
			this.textResult = new System.Windows.Forms.Label();
			this.qrCodeImage = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.autoOpen = new System.Windows.Forms.CheckBox();
			this.autoCopy = new System.Windows.Forms.CheckBox();
			this.autoDetect = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.qrCodeImage)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// readClipboard
			// 
			this.readClipboard.Location = new System.Drawing.Point(13, 13);
			this.readClipboard.Name = "readClipboard";
			this.readClipboard.Size = new System.Drawing.Size(219, 49);
			this.readClipboard.TabIndex = 0;
			this.readClipboard.Text = "Read from Clipboard";
			this.readClipboard.UseVisualStyleBackColor = true;
			this.readClipboard.Click += new System.EventHandler(this.readClipboard_Click);
			// 
			// textResult
			// 
			this.textResult.AutoSize = true;
			this.textResult.Location = new System.Drawing.Point(6, 16);
			this.textResult.Name = "textResult";
			this.textResult.Size = new System.Drawing.Size(10, 13);
			this.textResult.TabIndex = 1;
			this.textResult.Text = "-";
			// 
			// qrCodeImage
			// 
			this.qrCodeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.qrCodeImage.Location = new System.Drawing.Point(238, 15);
			this.qrCodeImage.Name = "qrCodeImage";
			this.qrCodeImage.Size = new System.Drawing.Size(330, 330);
			this.qrCodeImage.TabIndex = 3;
			this.qrCodeImage.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textResult);
			this.groupBox1.Location = new System.Drawing.Point(12, 140);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(220, 205);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Results";
			// 
			// autoOpen
			// 
			this.autoOpen.AutoSize = true;
			this.autoOpen.Location = new System.Drawing.Point(13, 69);
			this.autoOpen.Name = "autoOpen";
			this.autoOpen.Size = new System.Drawing.Size(75, 17);
			this.autoOpen.TabIndex = 5;
			this.autoOpen.Text = "Auto open";
			this.autoOpen.UseVisualStyleBackColor = true;
			// 
			// autoCopy
			// 
			this.autoCopy.AutoSize = true;
			this.autoCopy.Location = new System.Drawing.Point(13, 92);
			this.autoCopy.Name = "autoCopy";
			this.autoCopy.Size = new System.Drawing.Size(132, 17);
			this.autoCopy.TabIndex = 6;
			this.autoCopy.Text = "Auto copy to clipboard";
			this.autoCopy.UseVisualStyleBackColor = true;
			// 
			// autoDetect
			// 
			this.autoDetect.AutoSize = true;
			this.autoDetect.Location = new System.Drawing.Point(13, 115);
			this.autoDetect.Name = "autoDetect";
			this.autoDetect.Size = new System.Drawing.Size(166, 17);
			this.autoDetect.TabIndex = 7;
			this.autoDetect.Text = "Auto detect clipboard change";
			this.autoDetect.UseVisualStyleBackColor = true;
			this.autoDetect.CheckedChanged += new System.EventHandler(this.autoDetect_CheckedChanged);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(582, 357);
			this.Controls.Add(this.autoDetect);
			this.Controls.Add(this.autoCopy);
			this.Controls.Add(this.autoOpen);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.qrCodeImage);
			this.Controls.Add(this.readClipboard);
			this.Name = "frmMain";
			this.Text = "QReader";
			((System.ComponentModel.ISupportInitialize)(this.qrCodeImage)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readClipboard;
        private System.Windows.Forms.Label textResult;
        private System.Windows.Forms.PictureBox qrCodeImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox autoOpen;
        private System.Windows.Forms.CheckBox autoCopy;
		private System.Windows.Forms.CheckBox autoDetect;
	}
}

