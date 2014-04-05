using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace de.janbusch.HashPasswordSharp.HelpGuide
{
    public partial class FirstStartupGP : GuidePage
    {
        public FirstStartupGP()
        {
            InitializeComponent();
            this.Title = "How to get started";
        }

        private void btnCreateConfig_Click(object sender, EventArgs e)
        {
            CallUserGuidePageAction(this, new UserGuideActionArgs(UserGuideActionArgs.UserActionType.CreateConfig));
        }

        private void btnOpenConfig_Click(object sender, EventArgs e)
        {
            CallUserGuidePageAction(this, new UserGuideActionArgs(UserGuideActionArgs.UserActionType.OpenConfig));
        }
    }
}
