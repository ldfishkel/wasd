namespace ClinicaFrba.DataAccess.IoC
{
    using Autofac;
    using DAO;

    public class DataAccessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            //Components
            builder.RegisterType<UsuarioDao>().AsSelf().SingleInstance();
        }
    }
}
