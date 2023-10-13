using CommunityToolkit.Mvvm.DependencyInjection;

using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TunghsPic
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var services = ConfigureServices();
            Ioc.Default.ConfigureServices(services);
        }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // ViewModel 등록

            return services.BuildServiceProvider();
        }
    }
}
