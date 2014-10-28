using EasyArchive.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyArchive
{
    public partial class MainForm : Form
    {
        ActivityLogger _activityLogger;

        public MainForm()
        {
            InitializeComponent();
            _activityLogger = new ActivityLogger(new LabelDisplay(lblStatus));
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _activityLogger.Show("btnCancel clicked");
        }

        private void btnCancel3_click(object sender, EventArgs e)
        {
            _activityLogger.Show("btnOk clicked");
        }

    }
}
