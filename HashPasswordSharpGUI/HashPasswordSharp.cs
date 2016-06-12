using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using JaSt.HashPasswordSharp.Helper;
using JaSt.HashPasswordSharp.HelpGuide;
using JaSt.HashPasswordSharp.Library;
using JaSt.HashPasswordSharp.Library.Config;
using JaSt.HashPasswordSharp.Properties;

namespace JaSt.HashPasswordSharp
{
    public partial class HashPasswordSharp : Form
    {
        public HashPasswordSharp()
        {
            InitializeComponent();
        }

        #region Guide interaction
        private void ShowGuide(GuidePage topic = null)
        {
            var guide = new Guide();
            guide.UserGuideAction += guide_UserGuideAction;
            if (topic != null) guide.Topics.AddLast(topic);
            guide.ShowDialog();
        }

        void guide_UserGuideAction(object sender, UserGuideActionArgs e)
        {
            switch (e.UserAction)
            {
                case UserGuideActionArgs.UserActionType.CreateConfig:
                    CreateNewConfiguration();
                    break;
                case UserGuideActionArgs.UserActionType.OpenConfig:
                    OpenConfiguration();
                    break;
            }
        }
        #endregion

        #region Control methods
        private void LoadSettings()
        {
            checkBoxClearPwOnExit.Checked = Settings.Default.ClearOnExit;
            checkBoxStartMinimized.Checked = Settings.Default.StartMinimized;
            try
            {
                checkBoxStartup.Checked = RegistryHelper.GetStartup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (Settings.Default.StartMinimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void GeneratePassword()
        {
            HashUtil.SupportedHashAlgorithm algorithm;
            var host = comboBoxHost.SelectedItem as HashPasswordHost;
            var loginName = comboBoxLogin.SelectedItem as HashPasswordLogin;

            if (host == null || loginName == null) return;

            var hashAlgorithm = string.IsNullOrEmpty(loginName.HashType)
                ? (string.IsNullOrEmpty(host.HashType) ? Settings.Default.HashType : host.HashType)
                : loginName.HashType;
            var characterSet = string.IsNullOrEmpty(loginName.Charset)
                ? (string.IsNullOrEmpty(host.Charset) ? Settings.Default.Charset : host.Charset)
                : loginName.Charset;
            var maxPwLength = string.IsNullOrEmpty(loginName.PasswordLength)
                ? (string.IsNullOrEmpty(host.PasswordLength) ? Settings.Default.PasswordLength : host.PasswordLength)
                : loginName.PasswordLength;

            if (!Enum.TryParse(hashAlgorithm, out algorithm)) return;

            var password = HashUtil.GeneratePassword(host.Name, loginName.Name,
                txtPassphrase.Text, algorithm, characterSet, Convert.ToInt32(maxPwLength));
            new ChooseActionDialog(password).ShowDialog();
        }

        private void EnableSaveChanges()
        {
            saveToolStripMenuItem.Enabled = true;
            saveAsToolStripMenuItem.Enabled = true;
        }

        private void DisableSaveChanges()
        {
            saveToolStripMenuItem.Enabled = false;
            saveAsToolStripMenuItem.Enabled = false;
        }

        private void CreateNewConfiguration()
        {
            var conf = new HashPasswordConfiguration();
            SaveConfig();
        }

        private void SaveConfig(string path = null)
        {
            CurrentConfiguration.SaveToXml(path);
            lblConfigPath.Text = CurrentConfiguration.Filepath;
            Settings.Default.LastConfigFilepath = CurrentConfiguration.Filepath;
            Settings.Default.Save();
        }

        private void OpenConfiguration(string filePath = null)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
                filePath = openFileDialog.FileName;
            }

            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                CurrentConfiguration = HashPasswordConfiguration.LoadFromXml(filePath);
            }
        }
        private void LoadConfiguration()
        {
            comboBoxHost.Items.Clear();
            if (CurrentConfiguration == null) return;
            if (CurrentConfiguration.Hosts?.Host != null)
            {
                comboBoxHost.Items.AddRange(CurrentConfiguration.Hosts.Host.ToArray());
                comboBoxHost.SelectedItem = !string.IsNullOrEmpty(CurrentConfiguration.LastHost) ? CurrentConfiguration.Hosts.Host.FirstOrDefault(h => h.Name.Equals(CurrentConfiguration.LastHost)) : CurrentConfiguration.Hosts.Host.FirstOrDefault();
            }

            DisableSaveChanges();
            CurrentConfiguration.HasChanged = false;
            saveAsToolStripMenuItem.Enabled = true;
            CurrentConfiguration.ConfigChanged += CurrentConfiguration_ConfigChanged;
            Settings.Default.LastConfigFilepath = CurrentConfiguration.Filepath;
            Settings.Default.Save();
            tabControl.Enabled = true;
            lblConfigPath.Text = CurrentConfiguration.Filepath;
        }

        private void LoadLogins()
        {
            if (comboBoxHost.SelectedItem == null) return;

            var host = comboBoxHost.SelectedItem as HashPasswordHost;
            comboBoxLogin.Items.Clear();
            if (host == null) return;

            comboBoxLogin.Items.AddRange(host.LoginNames.LoginName.ToArray());

            if (!string.IsNullOrEmpty(host.LastLogin))
            {
                comboBoxLogin.SelectedItem =
                    host.LoginNames.LoginName.FirstOrDefault(l => l.Name.Equals(host.LastLogin));
            }
            else
            {
                comboBoxLogin.SelectedItem = CurrentConfiguration.Hosts.Host.FirstOrDefault();
            }
        }
        #endregion

        #region Events
        private void HashPasswordSharp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Settings.Default.ClearOnExit)
            {
                Clipboard.SetText("42");
            }
        }

        private void checkBoxClearPwOnExit_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.ClearOnExit = checkBoxClearPwOnExit.Checked;
            Settings.Default.Save();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Minimized : FormWindowState.Normal;
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void HashPasswordSharp_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon.ShowBalloonTip(1000, "JHashPassword", "I'm down here if you need me...", ToolTipIcon.Info);
            }
            else
                this.ShowInTaskbar = true;
        }

        private void checkBoxStartMinimized_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.StartMinimized = checkBoxStartMinimized.Checked;
            Settings.Default.Save();
        }

        private void checkBoxStartup_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RegistryHelper.SetStartup(checkBoxStartup.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPassphraseReenter_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGeneratePassword.PerformClick();
        }

        private void txtPassphrase_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGeneratePassword.PerformClick();
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            GeneratePassword();
        }


        void CurrentConfiguration_ConfigChanged(object sender, EventArgs e)
        {
            EnableSaveChanges();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenConfiguration();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            if (CurrentConfiguration != null && CurrentConfiguration.HasChanged)
            {
                var res = MessageBox.Show(Resources.HashPasswordSharp_Question_SaveChanges, Resources.HashPasswordSharp_QuestionTitle_SaveChanges,
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                switch (res)
                {
                    case DialogResult.Yes:
                        SaveConfig();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }
            this.Close();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnExit.PerformClick();
        }

        private void btnHelp_Click(object sender, System.EventArgs e)
        {
            ShowGuide();
        }

        private void HashPasswordSharp_Shown(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Settings.Default.LastConfigFilepath))
            {
                ShowGuide(new FirstStartupGP());
            }
            else
            {
                if (File.Exists(Settings.Default.LastConfigFilepath))
                {
                    OpenConfiguration(Settings.Default.LastConfigFilepath);
                }
            }

            notifyIcon.Visible = true;
            notifyIcon.Icon = new Icon(Path.Combine("Resources", Settings.Default.AppIcon));
            txtPassphrase.Focus();

            LoadSettings();
        }

        private void comboBoxHost_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLogins();
            var hashPasswordHost = comboBoxHost.SelectedItem as HashPasswordHost;
            if (hashPasswordHost == null) return;
            CurrentConfiguration.LastHost = hashPasswordHost.Name;
            CurrentConfiguration.HasChanged = true;
        }

        private void comboBoxLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hashPasswordHost = comboBoxHost.SelectedItem as HashPasswordHost;
            if (hashPasswordHost == null) return;
            CurrentConfiguration.LastHost = hashPasswordHost.Name;
            CurrentConfiguration.HasChanged = true;
            var hashPasswordLogin = comboBoxLogin.SelectedItem as HashPasswordLogin;
            if (hashPasswordLogin != null) hashPasswordHost.LastLogin = hashPasswordLogin.Name;
        }

        private void txtPassphrase_TextChanged(object sender, EventArgs e)
        {
            btnGeneratePassword.Enabled = !string.IsNullOrEmpty(txtPassphrase.Text);
            if (!string.IsNullOrEmpty(txtPassphrase.Text) && !string.IsNullOrEmpty(txtPassphraseReenter.Text) &&
                txtPassphrase.Text == txtPassphraseReenter.Text)
            {
                btnGeneratePassword.ForeColor = Color.DarkGreen;
            }
            else
            {
                btnGeneratePassword.ForeColor = Color.DarkRed;
            }
        }

        private void txtPassphraseReenter_TextChanged(object sender, EventArgs e)
        {
            btnGeneratePassword.Enabled = !string.IsNullOrEmpty(txtPassphrase.Text) && ((!string.IsNullOrEmpty(txtPassphraseReenter.Text) && txtPassphrase.Text == txtPassphraseReenter.Text) || string.IsNullOrEmpty(txtPassphraseReenter.Text));
            if (!string.IsNullOrEmpty(txtPassphrase.Text) && !string.IsNullOrEmpty(txtPassphraseReenter.Text) &&
                txtPassphrase.Text == txtPassphraseReenter.Text)
            {
                btnGeneratePassword.ForeColor = Color.DarkGreen;
            }
            else
            {
                btnGeneratePassword.ForeColor = Color.DarkRed;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;
            var filename = saveFileDialog.FileName;
            SaveConfig(filename);
        }

        private void HashPasswordSharp_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ShowGuide();
        }

        private void HashPasswordSharp_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            ShowGuide();
        }
        #endregion

        #region Complex properties
        private HashPasswordConfiguration _currentConfiguration;

        public HashPasswordConfiguration CurrentConfiguration
        {
            get
            {
                return _currentConfiguration;
            }
            set
            {
                _currentConfiguration = value;
                if (_currentConfiguration != null)
                {
                    LoadConfiguration();
                }
            }
        }

        #endregion

    }
}
