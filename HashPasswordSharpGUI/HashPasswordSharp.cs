using System;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Windows.Forms;
using de.janbusch.HashPasswordSharp.HelpGuide;
using de.janbusch.HashPasswordSharp.lib.Config;
using de.janbusch.HashPasswordSharp.Properties;

namespace de.janbusch.HashPasswordSharp
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
        private void CreateNewConfiguration()
        {
            var conf = new HashPasswordConfiguration();
            SaveConfig();
        }

        private void SaveConfig()
        {
            throw new NotImplementedException();
        }

        private void OpenConfiguration(string filePath = null)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                openFileDialog.ShowDialog();
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
            comboBoxHost.Items.AddRange(CurrentConfiguration.Hosts.Host.ToArray());

            if (!string.IsNullOrEmpty(CurrentConfiguration.LastHost))
            {
                comboBoxHost.SelectedItem =
                    CurrentConfiguration.Hosts.Host.FirstOrDefault(h => h.Name.Equals(CurrentConfiguration.LastHost));
            }
            else
            {
                comboBoxHost.SelectedItem = CurrentConfiguration.Hosts.Host.FirstOrDefault();
            }

            Settings.Default.LastConfigFilepath = CurrentConfiguration.Filepath;
            Settings.Default.Save();
            tabControl.Enabled = true;
        }
        #endregion

        #region Events
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenConfiguration();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
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
