using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop.UI.Client
{
    public partial class fmQRCode : Form
    {
        public fmQRCode()
        {
            InitializeComponent();
        }

        private void fmQRCode_Load(object sender, EventArgs e)
        {
            string url = "https://forms.gle/zozE2TggFFPexJUH8";
            picQRQode.Image = GenerateQRCode(url);
        }

        private Bitmap GenerateQRCode(string text)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(3);
            return qrCodeImage;
        }
    }
}
