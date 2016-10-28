namespace ClinicaFrba.DataAccess.Configuration
{
    using Newtonsoft.Json;
    using System;
    using System.IO;
    using System.Text;

    public static class Config
    {
        public static ExternalConfiguration GetConfig()
        {
            try
            {
                if (File.Exists("/ExternalConfig.txt"))
                {
                    var configJson = File.ReadAllText("/ExternalConfig.txt", Encoding.UTF8);

                    return GetExternalConfiguration(configJson);
                }

                throw new Exception("Cannot find the configuration file ");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static ExternalConfiguration GetExternalConfiguration(string configJson)
        {
            return JsonConvert.DeserializeObject<ExternalConfiguration>(configJson);
        }

        public static string ConnectionString()
        {
            return GetConfig().ConnectionString;
        }

        public static DateTime SystemDate()
        {
            return GetConfig().BeginDate;
        }
    }
}
