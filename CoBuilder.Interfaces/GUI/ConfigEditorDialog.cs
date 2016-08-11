using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoBuilder.Service.Infrastructure.Config;

namespace CoBuilder.Service.GUI
{
    public partial class ConfigEditorDialog : Form
    {
        private readonly Configuration _configuration;

        public ConfigEditorDialog(Configuration configuration)
        {
            _configuration = configuration;
            InitializeComponent();
        }

        private void CmdConfigAdd_Click(object sender, EventArgs e)
        {

        }

        private void CmdEdit_Click(object sender, EventArgs e)
        {

        }

        private void CmdRemove_Click(object sender, EventArgs e)
        {

        }

        private void CmdAddtoConfig_Click(object sender, EventArgs e)
        {

        }
    }
}
