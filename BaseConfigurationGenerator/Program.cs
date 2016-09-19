using System;
using System.Linq;
using System.Reflection;
using CoBuilder.Service.Interfaces;
using CoBuilder.Core;
using CoBuilder.Core.Authentication;

namespace BaseConfigurationGenerator
{
    public class Program
    {
        const string Filename = "%APPDATA%/CoBuilder/Base";

        private static void Main(string[] args)
        {
            Session session = null;

            try
            {
                session =  new ArgumentsProcessor(args).Process();
            }
            catch (Exception e)
            {
                if (e is ArgumentException)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            IConfiguration configuration = null;

            try
            {
                configuration = new ConfigurationProcessor(session).Process();
            }
            catch (Exception e)
            {
                
            }

            configuration?.BaseSave(Filename);
        }
    }

    internal class ConfigurationProcessor
    {
        private readonly Session _session;

        public ConfigurationProcessor(Session session)
        {
            _session = session;
        }

        public IConfiguration Process()
        {
            var client = new CoBuilderClient(new AppConfig(), new RestSharpHttpProvider(CoBuilder.Core.Constants.Authentication.CoBuilderBaseUrl),new CoBuilderAuthenticationProvider() )
                
        }
    }


    internal class ArgumentsProcessor
    {
        private readonly string[] _args;

        public ArgumentsProcessor(string[] args)
        {
            _args = args;
        }

        public Session Process()
        {
            var session = new Session();

            foreach (var arg in _args)
            {
                ArgProcess(session, arg);
            }

            Validate(session);

            return session;
        }

        private void Validate(Session session)
        {
            throw new NotImplementedException();
        }

        private void ArgProcess(Session session,string arg)
        {
            var split = arg.Split(' ');
            if (split.Length < 2) return;

            string value = null;

            if (split.Length > 2)
            {
                var val = new string[split.Length - 1];
                Array.Copy(split, 1, val, 0, split.Length - 1);

                value = string.Concat(val);
            }
            else
            {
                value = split[1];
            }

            switch (split[0])
            {
                case Parameters.Username:
                    session.Username = value;
                    break;
                case Parameters.Password:
                    session.Password = value;
                    break;
                case Parameters.AccessToken:
                    session.AccessToken = value;
                    break;
                case Parameters.WorkplaceId:
                    session.WorkplaceId = value;
                    break;
                default:
                    return;
            }
        }
    }

    internal class Session
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string AccessToken { get; set; }
        public string WorkplaceId { get; set; }
    }

    public static class Parameters
    {
        public const string Username = "-un";
        public const string Password = "-pw";
        public const string AccessToken = "-at";
        public const string WorkplaceId = "-wi";

    }
}
