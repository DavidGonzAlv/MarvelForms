using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Marvel.Core.Models.PersonajesModel;
using MarvelForms.Services.BaseService.MarvelService;
using MarvelForms.Util;
using MvvmLibrary.Factorias;
using MvvmLibrary.Factorias.Navegacion;
using MvvmLibrary.Util;
using Xamarin.Forms;

namespace MarvelForms.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; set; }

        public LoginViewModel(INavigator navigator, IMarvelService servicio, IPage page) : base(navigator, servicio, page)
        {
            LoginCommand = new Command(Login);
            Titulo = "Marvel";
        }


        private async void Login()
        {
            try
            {
                IsBusy = true;
                Metodos.Instance.SetQueryString("characters");
                var personajes = await _servicio.GetPersonajes(Cadenas.Query);

                await _navigator.PushAsync<MainViewModel>(
                    viewModel =>
                    {
                        viewModel.Titulo = "Personajes";
                        viewModel.Personajes = new ObservableRangeCollection<Personaje>(personajes);

                    });
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
