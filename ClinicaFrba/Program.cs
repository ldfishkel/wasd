namespace ClinicaFrba
{
    using Autofac;
    using ClinicaFrba.IoC;
    using System;
    using System.Windows.Forms;

    static class Program
    {
        private static IContainer _container;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitializeDependencies();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(_container.Resolve<LoginForm>());

        }

        public static void InitializeDependencies()
        {
            var bootstrapper = new Bootstrapper();
            _container = bootstrapper.Build();
        }
    }
}
