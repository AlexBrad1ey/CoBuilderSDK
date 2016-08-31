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
