using QReader.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;

namespace QReader
{
    public partial class frmMain : Form
    {
        private ClipBoardMonitor clipboardMonitor = new ClipBoardMonitor();

        public frmMain()
        {
            InitializeComponent();
            qrCodeImage.SizeMode = PictureBoxSizeMode.StretchImage;
            textResult.MaximumSize = new Size(210, 0);
            textResult.AutoSize = true;
        }

		private void readClipboard_Click(object sender, EventArgs e)
        {
            QRCodeReader reader = new QRCodeReader();
            textResult.ResetText();

            Bitmap imageCode;
            try
            {
                Image image = Clipboard.GetImage();
                imageCode = new Bitmap(image);
                qrCodeImage.Image = image;
            }
            catch (NullReferenceException)
            {
                textResult.Text = "Clipboard doesn't contain an image!";
                return;
            }

            BitmapLuminanceSource bls = new BitmapLuminanceSource(imageCode);
            GlobalHistogramBinarizer binarizer = new GlobalHistogramBinarizer(bls);
            BinaryBitmap bb = new BinaryBitmap(binarizer);

            Result result = reader.decode(bb);

            if (result == null)
            {
                textResult.Text = "result is null!";
                return;
            }

            textResult.Text = result.Text;

            if (autoOpen.Checked &&
                ( result.Text.StartsWith("http://") ||
                  result.Text.StartsWith("https://") ))
            {
                System.Diagnostics.Process.Start(result.Text);
            }

            if (autoCopy.Checked)
            {
                Clipboard.SetText(result.Text);
            }
        }

		private void autoDetect_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			if (checkBox.Checked)
			{
				autoDetect.ForeColor = Color.FromKnownColor(KnownColor.Green);
                clipboardMonitor.NewImage += readClipboard_Click;
            }
			else
			{
				autoDetect.ForeColor = Color.FromKnownColor(KnownColor.Black);
                clipboardMonitor.NewImage -= readClipboard_Click;
            }
		}
	}
}
