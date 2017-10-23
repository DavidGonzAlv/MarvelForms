using System;
using System.Collections.Generic;
using System.Text;
using MarvelForms.Services.BaseService;
using MarvelForms.Services.BaseService.MarvelService;
using MvvmLibrary.Factorias;
using MvvmLibrary.Factorias.Navegacion;

namespace MarvelForms.ViewModels
{
   public class BaseViewModel : MvvmLibrary.BaseViewModel.BaseViewModel
    {
        protected INavigator _navigator;
        public IMarvelService _servicio;
        public IPage _page;
        public BaseViewModel(INavigator navigator, IMarvelService servicio, IPage page)
        {
            _navigator = navigator;
            _servicio = servicio;
            _page = page;
        }
    }
}
