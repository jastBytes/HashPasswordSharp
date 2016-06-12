using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JaSt.HashPasswordSharp.HelpGuide
{
    public partial class GuidePage : UserControl
    {
        public delegate void UserGuidePageActionHandler(object sender, UserGuideActionArgs e);
        public virtual event UserGuidePageActionHandler UserGuidePageAction;

        public string Title { get; set; }

        public GuidePage()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            return Title;
        }

        protected void CallUserGuidePageAction(object sender, UserGuideActionArgs e)
        {
            if (UserGuidePageAction != null) UserGuidePageAction(sender, e);
        }
    }
}
