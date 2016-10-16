namespace ClinicaFrba.DataAccess.DAO
{
    using System.Linq;

    public class ProfesionalDao
    {
        private Database _ds;

        public ProfesionalDao()
        {
            _ds = new Database();
        }

        public Profesional GetProfesional(int id)
        {
            return _ds.Profesionals.SingleOrDefault(x => x.profesional_id == id);
        }

        public void SaveAgendum(Profesional profesional)
        {
            _ds.Profesionals.Attach(profesional);
            _ds.SaveChanges();
        }
    }
}
