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
using CoBuilder.Service.Infrastructure.Structures;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.GUI
{
    public partial class ConfigEditorDialog : Form
    {
        private readonly Configuration _configuration;
        private readonly Configuration _baseConfiguration;
        private ConfigEditState _configEditState;
        private OpenState _openState;

        #region Constructors
        public ConfigEditorDialog(Configuration configuration, Configuration baseConfiguration, OpenState state )
        {
            _configuration = configuration;
            _baseConfiguration = baseConfiguration;
            _openState = state;
            InitializeComponent();
        }

        public ConfigEditorDialog(Configuration configuration, Configuration baseConfiguration)
            : this(configuration, baseConfiguration, OpenState.Edit)
        {
        }

        public ConfigEditorDialog(Configuration baseConfiguration)
            : this(new Configuration(), baseConfiguration, OpenState.New)
        {
        }

        #endregion

        #region Porperties
        public Configuration Configuration { get; private set; }
        #endregion

        #region Event Handlers
        private void ConfigEditorDialog_Load(object sender, EventArgs e)
        {
            SwitchConfigEditState(ConfigEditState.Viewing);
            UpdateTreeView(TrvRoot, _baseConfiguration);
            UpdateTreeView(TrvConfiguration, _configuration);
        }

        private void cmdConfigEdit_Click(object sender, EventArgs e)
        {
            _configEditState = SwitchConfigEditState(_configEditState);
        }

        private void cmdConfigCancel_Click(object sender, EventArgs e)
        {
            _configEditState = SwitchConfigEditState(ConfigEditState.Cancel);
        }

        private void CmbOK_Click(object sender, EventArgs e)
        {
            Configuration = _configuration;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CmbCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        #endregion

        #region Methods
        private ConfigEditState SwitchConfigEditState(ConfigEditState state)
        {
            switch (state)
            {
                case ConfigEditState.Editing:

                    tbxName.Visible = false;
                    _configuration.Name = tbxName.Text;
                    tbxAuthor.Visible = false;
                    _configuration.Author = tbxAuthor.Text;

                    lblNameValue.Visible = true;
                    lblNameValue.Text = _configuration.Name;
                    lblAuthorValue.Visible = true;
                    lblAuthorValue.Text = _configuration.Author;

                    cmdConfigEdit.Text = "&Edit";
                    cmdConfigEdit.Location = new Point(cmdConfigEdit.Location.X + 55, cmdConfigEdit.Location.Y);
                    cmdConfigCancel.Visible = false;

                    SpCForm.Enabled = true;
                    return ConfigEditState.Viewing;

                case ConfigEditState.Viewing:

                    tbxName.Visible = true;
                    tbxName.Text = _configuration.Name;
                    tbxAuthor.Visible = true;
                    tbxAuthor.Text = _configuration.Author;

                    lblNameValue.Visible = false;
                    lblAuthorValue.Visible = false;

                    cmdConfigEdit.Text = "&Save";
                    cmdConfigEdit.Location = new Point(cmdConfigEdit.Location.X - 55, cmdConfigEdit.Location.Y);
                    cmdConfigCancel.Visible = true;

                    SpCForm.Enabled = false;
                    tbxName.Focus();
                    return ConfigEditState.Editing;

                case ConfigEditState.Cancel:

                    tbxName.Visible = false;
                    tbxAuthor.Visible = false;

                    lblNameValue.Visible = true;
                    lblNameValue.Text = _configuration.Name;
                    lblAuthorValue.Visible = true;
                    lblAuthorValue.Text = _configuration.Author;

                    cmdConfigEdit.Text = "&Edit";
                    cmdConfigEdit.Location = new Point(cmdConfigEdit.Location.X + 55, cmdConfigEdit.Location.Y);
                    cmdConfigCancel.Visible = false;

                    SpCForm.Enabled = true;
                    return ConfigEditState.Viewing;

                default:
                    throw new ArgumentOutOfRangeException(nameof(state), state, "Invalid State Arguement Supplied");
            }
        }

        private void UpdateTreeView(TreeView treeView, Configuration config)
        {
            treeView.BeginUpdate();
            treeView.Nodes.Clear();

            var root = treeView.Nodes.Add(config.Structure.Root.Value.Identifier, config.Structure.Root.Value.DisplayName);

            AddChildren(root, config.Structure.Root);

            treeView.EndUpdate();
        }

        private void AddChildren(TreeNode displayNode, TreeNode<IDefinition> node)
        {
            foreach (var child in node.Children)
            {
                var newNode = displayNode.Nodes.Add(child.Value.Identifier, child.Value.DisplayName);
                AddChildren(newNode,child);
            } 
        }
        #endregion

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            if (TrvRoot.SelectedNode == null)
            {
                MessageBox.Show("Please Select a Property to Add");
                return;
            }

            var definition = _baseConfiguration.GetDefinition();


        }
    }

    public enum OpenState
    {
        Edit,
        New
    }
    internal enum ConfigEditState
    {
        Editing,
        Viewing,
        Cancel
    }
}
