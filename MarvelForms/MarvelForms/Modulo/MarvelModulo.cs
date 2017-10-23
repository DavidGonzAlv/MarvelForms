
using System;
using Autofac;
using MarvelForms.Services.BaseService;
using MarvelForms.Services.BaseService.MarvelService;
using MarvelForms.ViewModels;
using MarvelForms.Views;
using MvvmLibrary.Factorias;
using MvvmLibrary.Factorias.DialogService;
using MvvmLibrary.Factorias.Page;
using Xamarin.Forms;

namespace MarvelForms.Modulo
{
    public class MarvelModulo : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register<INavigation>(ctx => Application.Current.MainPage.Navigation).SingleInstance();

            builder.RegisterInstance<Func<Page>>(() =>
            {
                var masterP = App.Current.MainPage as MasterDetailPage;
                var page = masterP != null ? masterP.Detail : App.Current.MainPage;
                var navigation = page as IPageContainer<Page>;
                return navigation != null ? navigation.CurrentPage : page;
            });

            builder.RegisterType<DialogService>().As<IDialogService>().SingleInstance();
            builder.RegisterType<PageProxy>().As<IPage>().SingleInstance();

            builder.RegisterType<MarvelService>().As<IMarvelService>().SingleInstance();
            builder.RegisterType<LoginViewModel>().SingleInstance();
            builder.RegisterType<LoginView>().SingleInstance();
            builder.RegisterType<MainViewModel>().SingleInstance();
            builder.RegisterType<MainView>().SingleInstance();
            builder.RegisterType<PersonajeDetailViewModel>().SingleInstance();
            builder.RegisterType<PersonajeDetailView>();
        }
    }
}
