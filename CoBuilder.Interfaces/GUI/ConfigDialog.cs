using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using CoBuilder.Service.Helpers;
using CoBuilder.Service.Infrastructure.Config;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.GUI
{
    public partial class ConfigDialog : Form, IConfigSelectionUi
    {
        private readonly Settings _settings;
        private readonly IServiceSession _session;
        public IConfiguration SelectedConfiguration { get; set; }
        private IList<IConfiguration> _configurations;

        public ConfigDialog(IServiceSession session, Settings settings)
        {
            _settings = settings;
            SelectedConfiguration = session.CurrentConfiguration;
            InitializeComponent();
        }

        private void CmbEdit_Click(object sender, EventArgs e)
        {
            if (LstConfig.SelectedItem != null)
            {
                var config = LstConfig.SelectedItem as IConfiguration;
                if (config == null) return;

                _configurations.Remove(config);

                var editor = new ConfigEditorDialog(config);
                var result = editor.ShowDialog();
                switch(result)
                {
                    case DialogResult.OK:
                        _configurations.Add(editor.Configuration);
                        break;
                    case DialogResult.Cancel:
                        _configurations.Add(Configuration.Load(Constants.FilePathBase + config.ConfigId + Constants.ConfigFileType));
                        break;
                }
            }
        }

        private void CmbNew_Click(object sender, EventArgs e)
        {
            var editor = new ConfigEditorDialog();
            var result = editor.ShowDialog();

            if (editor.Configuration != null)
                _configurations.Add(editor.Configuration);
            ListRefresh();
            
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
            DialogResult = DialogResult.OK;
            SelectedConfiguration = LstConfig.SelectedItem as IConfiguration;
            Close();
        }

        private void CmbCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            SelectedConfiguration = null;
            Close();
        }

        public IConfiguration SelectConfiguration()
        {
            ShowDialog();
            return SelectedConfiguration;
        }

        private void LstConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            var config = LstConfig.SelectedItem as IConfiguration;
            lblNameValue.Text = config.Name;
            lblAuthorValue.Text = config.Author;
        }

        private void ConfigDialog_Load(object sender, EventArgs e)
        {
            _configurations = GetConfigurations();
            ListRefresh();
            if (SelectedConfiguration == null) return;
            LstConfig.SelectedItem = SelectedConfiguration;
        }

        private void ListRefresh()
        {
            try
            {
                if (_configurations != null && _configurations.Count != 0)
                {
                    LstConfig.Items.Clear();
                    foreach (var config in _configurations)
                    {
                        LstConfig.Items.Add(config);
                    }
                    LstConfig.DisplayMember = "Name";
                    LstConfig.ValueMember = "Id";
                }
                else
                {
                    MessageBox.Show(
                        "No Configurations found",
                        "No Configurations found", MessageBoxButtons.OK);
                }
            }
            catch (Exception exception)
            {
                _settings.WriteLogFile(exception, GetType().Name, MethodBase.GetCurrentMethod().Name);
            }
        }

        private IList<IConfiguration> GetConfigurations()
        {

            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            var dirPath = Path.Combine(Path.GetDirectoryName(path),"Configurations");

            var files = Directory.GetFiles(dirPath, "*" + Constants.ConfigFileType);

            var serializer = new ConfigurationSerializer();

            var result = new List<IConfiguration>();

            foreach (var file in files)
            {
                var config = serializer.Deserialize(file);
                if (config == null) continue;
                result.Add(config);
            }
            return result;
        }
    }
}
