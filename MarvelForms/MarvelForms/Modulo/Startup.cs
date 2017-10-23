using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using MarvelForms.ViewModels;
using MarvelForms.Views;
using MvvmLibrary.AutofacModulo;
using MvvmLibrary.Factorias.Factory;
using Xamarin.Forms;

namespace MarvelForms.Modulo
{
    public class Startup : AutofacBootstrapper
    {
        private readonly App _application;

        public Startup(App application)
        {
            _application = application;
        }

        public override void ConfigureContainer(ContainerBuilder builder)
        {
            base.ConfigureContainer(builder);
            builder.RegisterModule<MarvelModulo>();
        }

        protected override void RegisterViews(IViewFactory viewFactory)
        {
            viewFactory.Register<MainViewModel, MainView>();
            viewFactory.Register<LoginViewModel, LoginView>();
            viewFactory.Register<PersonajeDetailViewModel, PersonajeDetailView>();
        }

        protected override void ConfigureApplication(IContainer container)
        {
            var viewFactory = container.Resolve<IViewFactory>();
            {
                var login = viewFactory.Resolve<LoginViewModel>();
                var np = new NavigationPage(login);
                _application.MainPage = np;

            }
        }
    }
}
