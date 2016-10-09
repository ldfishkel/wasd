namespace ClinicaFrba.DataAccess.IoC
{
    using Autofac;

    internal class Bootstrapper
    {
        public IContainer Build()
        {
            var container = new ContainerBuilder();

            container.RegisterModule<DataAccessModule>();

            return container.Build();
        }
    }
}
