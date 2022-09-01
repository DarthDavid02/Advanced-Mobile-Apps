using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using News.ViewModel;
using News.Services;

namespace News
{
    public static class Bootstrapper
    {
        public static void Initialize()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<MainShell>();
            containerBuilder.RegisterType<NewsService>();
            containerBuilder.RegisterAssemblyTypes(typeof(App).Assembly)
                            .Where(x => x.IsSubclassOf(typeof(ViewModel.ViewModel)));

            var container = containerBuilder.Build();
            Resolver.Initialize(container);
        }
    }
}
