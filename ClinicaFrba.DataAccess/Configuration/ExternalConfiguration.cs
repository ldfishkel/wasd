namespace ClinicaFrba.DataAccess.Configuration
{
    using System;

    [Serializable]
    public class ExternalConfiguration
    {
        public string ConnectionStringRemota { get; set; }
        public string ConnectionStringLocal { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
