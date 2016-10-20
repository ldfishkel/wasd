namespace ClinicaFrba.DataAccess.DAO
{
    using Configuration;
    using Newtonsoft.Json;
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Text;

    public abstract class DaoBase
    {
        protected Database _ds;

        public DaoBase()
        {
            try
            {
                if (File.Exists(ClinicaFrbaResources.ConfigFilePath))
                {
                    var configJson = File.ReadAllText(ClinicaFrbaResources.ConfigFilePath, Encoding.UTF8);

                    ExternalConfiguration config = GetExternalConfiguration(configJson);

                    _ds = new Database(config.ConnectionString);
                }
            }
            catch (Exception ex)
            {
                Debug.Print("Error al deserializar la config \n{0}", ex.ToString());
            }
        }

        private ExternalConfiguration GetExternalConfiguration(string configJson)
        {
            return JsonConvert.DeserializeObject<ExternalConfiguration>(configJson);
        }

    }
}
