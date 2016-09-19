using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoBuilder.Core.Authentication;
using CoBuilder.Core.Interfaces;
using CoBuilder.Service.Helpers;

namespace CoBuilder.Service.GUI
{
    public class CoBuilderAuthenticationUi:IAuthenticationUi
    {
        private IHttpProvider _httpProvider;

        public Task<ISession> AuthenticateAsync(IHttpProvider httpProvider)
        {
            _httpProvider = httpProvider;
            var dialog = new LoginDialog(_httpProvider, new Settings());
            dialog.ShowDialog();
            return Task.FromResult(dialog.Session);
        }
    }
}
