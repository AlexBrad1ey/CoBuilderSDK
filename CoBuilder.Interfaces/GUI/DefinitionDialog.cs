using System;
using System.Windows.Forms;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.GUI
{
    public partial class DefinitionDialog : Form
    {
        private readonly IDefinition _definition;

        public DefinitionDialog(IDefinition definition)
        {
            _definition = definition;
            InitializeComponent();
        }

        public IDefinition Definition
        {
            get { return _definition; }
        }

        private void DefinitionDialog_Load(object sender, EventArgs e)
        {
            txbDisplayName.Text = _definition.DisplayName;
            LblIdentifierValue.Text = _definition.Identifier;
            cbxVisible.Checked = _definition.Visible;
        }

        private void CmbOK_Click(object sender, EventArgs e)
        {
            _definition.DisplayName = txbDisplayName.Text;
            _definition.Identifier = LblIdentifierValue.Text;
            _definition.Visible = cbxVisible.Checked;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CmbCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
