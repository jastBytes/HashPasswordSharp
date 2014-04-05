using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace de.janbusch.HashPasswordSharp.HelpGuide
{
    public partial class Guide : Form
    {
        public delegate void UserGuideActionHandler(object sender, UserGuideActionArgs e);
        public event UserGuideActionHandler UserGuideAction;

        public LinkedList<GuidePage> Topics { get; set; }

        private GuidePage _currentTopic;

        public GuidePage CurrentTopic
        {
            get { return _currentTopic; }
            set
            {
                _currentTopic = value;
                this.guidePanel.Controls.Clear();
                if (_currentTopic == null) return;
                this.guidePanel.Controls.Add(_currentTopic);
                _currentTopic.Dock = DockStyle.Fill;
            }
        }

        public Guide()
        {
            InitializeComponent();
            this.Topics = new LinkedList<GuidePage>();
        }

        public Guide(GuidePage guidePage)
            : this()
        {
            this.Topics.AddLast(guidePage);
        }

        private void Guide_Load(object sender, EventArgs e)
        {
            comboBoxTopic.Items.Clear();

            foreach (var topic in Topics)
            {
                comboBoxTopic.Items.Add(topic);
                topic.UserGuidePageAction += topic_UserGuideAction;
            }
            comboBoxTopic.SelectedItem = Topics.FirstOrDefault();
            CurrentTopic = Topics.FirstOrDefault();
        }

        void topic_UserGuideAction(object sender, UserGuideActionArgs e)
        {
            if (UserGuideAction != null)
                UserGuideAction(sender, e);
            Close();
        }
    }

    public class UserGuideActionArgs : EventArgs
    {
        public enum UserActionType
        {
            CreateConfig,
            OpenConfig
        };

        public UserGuideActionArgs(UserActionType action)
        {
            this.UserAction = action;
        }

        public UserActionType UserAction { get; private set; }
    }
}
