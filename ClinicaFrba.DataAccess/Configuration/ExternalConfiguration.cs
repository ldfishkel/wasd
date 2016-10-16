namespace ClinicaFrba.DataAccess.Configuration
{
    using System;

    [Serializable]
    public class ExternalConfiguration
    {
        public string ConnectionString { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
