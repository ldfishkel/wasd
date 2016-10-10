namespace ClinicaFrba.DataAccess.DAO
{
    using System.Collections.Generic;

    public class AfiliadoDao
    {
        private Database _ds;

        public AfiliadoDao()
        {
            _ds = new Database();
        }

        public List<Afiliado> GetAfiliados()
        {
            return new List<Afiliado>()
            {
                new Afiliado("asdasd asdas", "asdas", "asdas", "234234234", "asdas@asdas.asd", "99/99/9999", "mucho", "single", "0", "dental", "000000001" ),
                new Afiliado("asdasd asdas", "asdas", "asdas", "234234234", "asdas@asdas.asd", "99/99/9999", "mucho", "single", "0", "dental", "000000002" ),
                new Afiliado("asdasd asdas", "asdas", "asdas", "234234234", "asdas@asdas.asd", "99/99/9999", "mucho", "single", "0", "dental", "000000003" ),
                new Afiliado("asdasd asdas", "asdas", "asdas", "234234234", "asdas@asdas.asd", "99/99/9999", "mucho", "single", "0", "dental", "000000004" ),
                new Afiliado("asdasd asdas", "asdas", "asdas", "234234234", "asdas@asdas.asd", "99/99/9999", "mucho", "single", "0", "dental", "000000005" ),
                new Afiliado("asdasd asdas", "asdas", "asdas", "234234234", "asdas@asdas.asd", "99/99/9999", "mucho", "single", "0", "dental", "000000006" ),
                new Afiliado("asdasd asdas", "asdas", "asdas", "234234234", "asdas@asdas.asd", "99/99/9999", "mucho", "single", "0", "dental", "000000007" ),
                new Afiliado("asdasd asdas", "asdas", "asdas", "234234234", "asdas@asdas.asd", "99/99/9999", "mucho", "single", "0", "dental", "000000008" ),
            };
        }
    }
}
