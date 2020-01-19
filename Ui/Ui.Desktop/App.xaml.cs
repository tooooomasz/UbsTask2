using Castle.Windsor;
using Castle.Windsor.Installer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace tomaszbaginski.UbsTask2.Ui.Desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IWindsorContainer _container;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            _container = new WindsorContainer();
            _container.Install(FromAssembly.This());

            var start = _container.Resolve<IShell>();
            start.Run();

            _container.Release(start);
        }
    }
}
