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
                string path = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "ExternalConfig.txt");
                
                if (File.Exists(path))
                {
                    var configJson = File.ReadAllText(path, Encoding.UTF8);

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

        public static string ConnectionString(ConnectionStringType connection)
        {
            if (connection == ConnectionStringType.Remota)
                return GetConfig().ConnectionStringRemota;
            else if (connection == ConnectionStringType.Local)
                return GetConfig().ConnectionStringLocal;
            else
                return null;
        }

        public static DateTime SystemDate()
        {
            return GetConfig().BeginDate;
        }
    }

    public enum ConnectionStringType
    {
        Remota,
        Local
    }
}
