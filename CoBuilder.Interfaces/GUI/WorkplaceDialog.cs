using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Helpers;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.GUI
{
    public partial class WorkplaceDialog : Form, IWorkplaceSelectionUi
    {
        private readonly ICoBuilderContext _ctx;
        private Settings _settings;
        private readonly IServiceSession _session;
        private List<IWorkplace> _workplaces;
        private string _workplaceValue;


        public WorkplaceDialog(ICoBuilderContext ctx, Settings settings, IServiceSession session)
        {
            _ctx = ctx;
            _settings = settings;
            _session = session;
            InitializeComponent();
        }

        public IServiceSession Session
        {
            get { return _session; }
        }

        private void WorkplaceDialog_Load(object sender, EventArgs e)
        {
            GetRememberMe();
            _workplaces = _ctx.Workplaces().ToList();
            ComboRefresh();
            CboWorkplace.SelectedItem = _workplaces.FirstOrDefault(x => x.Name.ToString() == _workplaceValue) ??
                                        _workplaces.First();
        }

        private void CmbOK_Click(object sender, EventArgs e)
        {
            var result = DialogResult.Yes;
            if (Session.CurrentWorkplace != null && Session.CurrentWorkplace != CboWorkplace.SelectedItem as Workplace )
            {
                result = Warning();
            }

            if (result != DialogResult.Yes) return;
            ((ServiceSession)Session).CurrentWorkplace = CboWorkplace.SelectedItem as Workplace;
            SetRememberMe();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CmbCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ComboRefresh()
        {
            try
            {
                if (_workplaces != null && _workplaces.Count != 0)
                {
                    CboWorkplace.Items.Clear();
                    foreach (var workplace in _workplaces)
                    {
                        CboWorkplace.Items.Add(workplace);
                    }
                    CboWorkplace.DisplayMember = "Name";
                    CboWorkplace.ValueMember = "Id";
                }
                else
                {
                    MessageBox.Show(
                        "No Work Places found for current User! /n Please check your coBuilder Login details",
                        "No Workspaces", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception exception)
            {
                _settings.WriteLogFile(exception, GetType().Name, MethodBase.GetCurrentMethod().Name);
            }
        }

        private void GetRememberMe()
        {
            try
            {
                _workplaceValue = _session.WorkplaceSet ? _session.CurrentWorkplace.Name : _settings.WorkPlace;
                CboWorkplace.Text = _workplaceValue;
            }
            catch (Exception exception)
            {
                _settings.WriteLogFile(exception, GetType().Name, MethodBase.GetCurrentMethod().Name);
            }
        }

        /// <summary>
        /// Sets the remember me.
        /// </summary>
        private void SetRememberMe()
        {
            try
            {
                _settings.WorkPlace = CboWorkplace.Text;
            }
            catch (Exception exception)
            {
                _settings.WriteLogFile(exception, GetType().Name, MethodBase.GetCurrentMethod().Name);
            }
        }

        private DialogResult Warning()
        {
            return
                MessageBox.Show(
                    "WARNING! - Changing Workplace will cause problems with already attached products, Due to current Functionality. Do you wish to continue (This cannot be Undone)",
                    "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        }

        public IWorkplace SelectWorkplace()
        {
            ShowDialog();
            return _session.CurrentWorkplace;
        }
    }
}
