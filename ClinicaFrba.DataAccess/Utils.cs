namespace ClinicaFrba.DataAccess
{
    using System;

    public static class Utils
    {
        public static string FormatDate(DateTime date)
        {
            return String.Format("{0}/{1}/{2}", date.Day, date.Month, date.Year);
        }
    }
}
