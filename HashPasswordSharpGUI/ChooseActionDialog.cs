using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using de.janbusch.HashPasswordSharp.Properties;
using QRCoder;

namespace de.janbusch.HashPasswordSharp
{
    public partial class ChooseActionDialog : Form
    {
        private string _password;

        public ChooseActionDialog(string password)
        {
            InitializeComponent();
            this._password = password;
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
