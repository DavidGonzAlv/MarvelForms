using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using MvvmLibrary.Factorias.Factory;

namespace MvvmLibrary.AutofacModulo
{
    public abstract class AutofacBootstrapper
    {
        public void Run()
        {
            var builder = new ContainerBuilder();
            ConfigureContainer(builder);
            var cont = builder.Build();
            var viewFactory = cont.Resolve<IViewFactory>();
            RegisterViews(viewFactory);
            ConfigureApplication(cont);

        }
        public virtual void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule<AutofacModulo>();
        }

        protected abstract void RegisterViews(IViewFactory viewFactory);
        protected abstract void ConfigureApplication(IContainer container);
    }
}

