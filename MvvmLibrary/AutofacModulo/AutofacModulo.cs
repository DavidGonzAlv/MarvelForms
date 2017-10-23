
using Autofac;
using MvvmLibrary.Factorias.Factory;
using MvvmLibrary.Factorias.Navegacion;

namespace MvvmLibrary.AutofacModulo
{
    public class AutofacModulo : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<ViewFactory>().As<IViewFactory>().SingleInstance();

            builder.RegisterType<Navigator>().As<INavigator>().SingleInstance();


        }
    }
}
