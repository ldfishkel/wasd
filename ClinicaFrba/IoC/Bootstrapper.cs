using Autofac;
using ClinicaFrba.DataAccess.IoC;

namespace ClinicaFrba.IoC
{
    public class Bootstrapper
    {
        public IContainer Build()
        {
            var builder = new ContainerBuilder();

            //Modulo de Comunicación Servidor.
            builder.RegisterModule<DataAccessModule>();

            builder.RegisterType<LoginForm>().AsSelf();

            return builder.Build();
        }
    }
}
