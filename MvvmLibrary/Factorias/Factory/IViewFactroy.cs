using System;
using System.Collections.Generic;
using System.Text;
using MvvmLibrary.BaseViewModel;

namespace MvvmLibrary.Factorias.Factory
{
    /// <summary>
    /// Interfaz que implementa los metodos basicos de un ServiceContainer.
    /// </summary>
    public interface IViewFactory
    {
        void Register<TViewModel, TView>() where TViewModel : class, IViewModel;
        Xamarin.Forms.Page Resolve<TViewModel>(Action<TViewModel> action = null) where TViewModel : class, IViewModel;
        Xamarin.Forms.Page Resolve<TViewModel>(out TViewModel viewModel, Action<TViewModel> action = null) where TViewModel : class, IViewModel;
        Xamarin.Forms.Page Resolve<TViewModel>(TViewModel viewModel) where TViewModel : class, IViewModel;
    }
}
