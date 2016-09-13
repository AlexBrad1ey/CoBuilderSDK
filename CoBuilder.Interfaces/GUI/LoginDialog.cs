using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoBuilder.Core.Authentication;
using CoBuilder.Core.Interfaces;
using CoBuilder.Core.Requests;
using CoBuilder.Core.RestModels;
using CoBuilder.Service.Enums;
using CoBuilder.Service.Helpers;

namespace CoBuilder.Service.GUI
{
    public partial class LoginDialog : Form
    {
        private readonly Settings _settings;
        private IHttpProvider _httpProvider;

        public LoginDialog(IHttpProvider httpProvider, Settings settings)
        {
            if (httpProvider == null) throw new ArgumentNullException(nameof(httpProvider));

            _settings = settings;
            _httpProvider = httpProvider;
            InitializeComponent();
        }

        public ISession Session { get; set; }

        private void CmbLogin_Click(object sender, EventArgs e)
        {
            var result = SignIn(TxbName.Text, TxbPassword.Text);
            DialogState(result);

        }

        private SignInResult SignIn(string username, string password)
        {
            var request = new LoginRequestBuilder("Login", _httpProvider).Request(username, password);
            LoginResult result = null;
            try
            {
                result = request.GetAsync().Result;
                Session = new Session(result, username) {CanSignOut = true};
                return Session.AccessToken == null ? SignInResult.Failed : SignInResult.Succeeded;
            }
            catch(Exception e)
            {
                _settings.WriteLogFile(e, GetType().Name, MethodBase.GetCurrentMethod().Name);
                return SignInResult.Error;
            }
        }


        private void DialogState(SignInResult? result)
        {
            switch (result)
            {
                case SignInResult.Succeeded:
                    MessageBox.Show("Login Successful");
                    CmbOK.Enabled = true;
                    break;
                case SignInResult.Failed:
                    MessageBox.Show("Login Failed Please Try Again");
                    TxbPassword.Clear();
                    TxbPassword.Focus();
                    CmbOK.Enabled = false;
                    break;
                case SignInResult.Error:
                    MessageBox.Show("Error during sign in please try again in a moment");
                    TxbPassword.Clear();
                    TxbPassword.Focus();
                    break;
                default:
                    CmbOK.Enabled = false;
                    CmbCancel.Enabled = true;
                    break;
            }
        }

        private void LoginDialog_Load(object sender, EventArgs e)
        {
            GetRememberMe();
            DialogState(null);
        }

        private void GetRememberMe()
        {
            try
            {
                TxbName.Text = _settings.Username;
                if (_settings.PasswordSaved)
                {
                    CbxRemember.CheckState = CheckState.Checked;
                    TxbPassword.Text = _settings.Password;
                }
                else
                {
                    CbxRemember.CheckState = CheckState.Unchecked;
                    TxbPassword.Text = "";
                }
            }
            catch (Exception exception)
            {
                _settings.WriteLogFile(exception, GetType().Name, MethodBase.GetCurrentMethod().Name);

                //Reset
                TxbName.Text = "";
                CbxRemember.CheckState = CheckState.Unchecked;
                TxbPassword.Text = "";
            }
        }

        private void SetRememberMe()
        {
            try
            {
                _settings.Username = TxbName.Text;
                if (CbxRemember.Checked)
                {
                    _settings.SavePassword(TxbPassword.Text);
                }
                else
                {
                    _settings.RemovePassword();
                }
            }
            catch (Exception exception)
            {
                _settings.WriteLogFile(exception, GetType().Name, MethodBase.GetCurrentMethod().Name);
            }
        }

        private void CmbOK_Click(object sender, EventArgs e)
        {
            SetRememberMe();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CmbCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Session = null;
            Close();
        }
    }
}
