using System;
using System.Windows.Forms;
using JaSt.HashPasswordSharp.Properties;
using QRCoder;

namespace JaSt.HashPasswordSharp
{
    public partial class ChooseActionDialog : Form
    {
        private readonly string _password;

        public ChooseActionDialog(string password)
        {
            InitializeComponent();
            _password = password;
            txtPassword.Text = password;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            btnShow.Text = txtPassword.UseSystemPasswordChar ? Resources.ChooseActionDialog_btnShowPassword : Resources.ChooseActionDialog_btnHidePassword;
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(_password);
        }

        private void btnShowQRCode_Click(object sender, EventArgs e)
        {
            var qrGenerator = new QRCodeGenerator();
            var qrCode = qrGenerator.CreateQrCode(_password, QRCodeGenerator.ECCLevel.Q);
            pbQrCode.Image = qrCode.GetGraphic(20);
        }

        private void ChooseActionDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (pbQrCode.Image)
            {
                pbQrCode.Image = null;
            }
        }
    }
}
