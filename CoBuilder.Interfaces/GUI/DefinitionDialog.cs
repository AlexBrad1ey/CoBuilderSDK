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

        private void DefinitionDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
