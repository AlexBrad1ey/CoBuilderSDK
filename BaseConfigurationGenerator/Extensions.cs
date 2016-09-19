using System;
using CoBuilder.Service.Interfaces;

namespace BaseConfigurationGenerator
{
    public static class Extensions
    {
        public static bool BaseSave(this IConfiguration config, string filename)
        {
            try
            {


                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }
    }
}
