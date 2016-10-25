namespace ClinicaFrba.DataAccess.Configuration
{
    using Newtonsoft.Json;
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Text;

    public static class Config
    {
        public static ExternalConfiguration GetConfig()
        {
            try
            {
                if (File.Exists(ClinicaFrbaResources.ConfigFilePath))
                {
                    var configJson = File.ReadAllText(ClinicaFrbaResources.ConfigFilePath, Encoding.UTF8);

                    return GetExternalConfiguration(configJson);
                }

                throw new Exception(String.Format("Cannot find the configuration file in {0}", ClinicaFrbaResources.ConfigFilePath));
            }
            catch (Exception ex)
            {
                Debug.Print("Error al deserializar la config \n{0}", ex.ToString());
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
