using System;
using System.Collections.Generic;
using Autofac;
using MvvmLibrary.BaseViewModel;
using Xamarin.Forms;

namespace MvvmLibrary.Factorias.Factory
{
    public class ViewFactory : IViewFactory
    {
        readonly IDictionary<Type, Type> _map = new Dictionary<Type, Type>();

        private readonly IComponentContext _componentContext;

        public ViewFactory(IComponentContext componentContext)
        {
            _componentContext = componentContext;
        }

        public void Register<TViewModel, TView>() where TViewModel : class, IViewModel
        {
            _map[typeof(TViewModel)] = typeof(TView);
        }

        public Xamarin.Forms.Page Resolve<TViewModel>(Action<TViewModel> action = null) where TViewModel : class, IViewModel
        {
            TViewModel viewModel;
            return Resolve<TViewModel>(out viewModel, action);
        }

        public Xamarin.Forms.Page Resolve<TViewModel>(out TViewModel viewModel, Action<TViewModel> action = null) where TViewModel : class, IViewModel
        {
            viewModel = _componentContext.Resolve<TViewModel>();
            var tipoVista = _map[typeof(TViewModel)];
            var vista = _componentContext.Resolve(tipoVista) as Xamarin.Forms.Page;
            if (action != null)
                viewModel.SetState(action);

            vista.BindingContext = viewModel;

            return vista;
        }

        public Xamarin.Forms.Page Resolve<TViewModel>(TViewModel viewModel) where TViewModel : class, IViewModel
        {
            var tipoVista = _map[typeof(TViewModel)];
            var vista = _componentContext.Resolve(tipoVista) as Xamarin.Forms.Page;
            vista.BindingContext = viewModel;
            return vista;
        }
    }
}
