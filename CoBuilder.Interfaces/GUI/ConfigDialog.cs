using System;
using System.Windows.Forms;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.GUI
{
    public partial class ConfigDialog : Form, IConfigSelectionUi
    {
        private readonly IConfiguration _currentConfig;

        public ConfigDialog(IConfiguration currentConfig)
        {
            _currentConfig = currentConfig;
            InitializeComponent();
        }

        private void CmbEdit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CmbNew_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CmbImport_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CmbExport_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CmbSelect_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CmbCancel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public IConfiguration SelectConfiguration()
        {
            throw new NotImplementedException();
        }
    }
}
