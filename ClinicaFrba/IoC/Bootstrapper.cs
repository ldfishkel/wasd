namespace ClinicaFrba.IoC
{
    using Autofac;
    using DataAccess.IoC;

    public class Bootstrapper
    {
        public IContainer Build()
        {
            var builder = new ContainerBuilder();

            //Modulo de Comunicación Servidor.
            builder.RegisterModule<DataAccessModule>();
            builder.RegisterModule<ClinicaFrbaModule>();

            builder.RegisterType<LoginForm>().AsSelf();

            return builder.Build();
        }
    }
}
