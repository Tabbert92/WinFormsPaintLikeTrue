using System;
using System.Windows.Forms;
using Autofac;
using PaintLikeCore;

namespace WinFormsPaintLike
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var container = BuildContainer();
            Application.Run(container.Resolve<PaintLike>());
        }

        static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<WinFormsModule>();
            builder.RegisterModule<CoreModule>();
            return builder.Build();
        }
    }
}
