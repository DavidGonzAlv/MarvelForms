using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Marvel.Core.Models.PersonajesModel;
using MarvelForms.Services.BaseService.MarvelService;
using MvvmLibrary.Factorias;
using MvvmLibrary.Factorias.Navegacion;
using MvvmLibrary.Util;

namespace MarvelForms.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        private ObservableRangeCollection<Personaje> _personajes;
        public ObservableRangeCollection<Personaje> Personajes
        {
            get => _personajes;
            set => SetProperty(ref _personajes, value);
        }

        private Personaje _personajeSeleccionado;
        public Personaje PersonajeSeleccionado
        {
            get { return _personajeSeleccionado; }
            set
            {


                SetProperty(ref _personajeSeleccionado, value);
                if (value != null)
                    VerDetallePersonaje();
            }
        }


        public MainViewModel(INavigator navigator, IMarvelService servicio, IPage page) : base(navigator, servicio, page)
        {
            Personajes = new ObservableRangeCollection<Personaje>();
        }

        public async void VerDetallePersonaje()
        {
            try
            {
                if (_personajeSeleccionado == null) return;
                await _navigator.PushAsync<PersonajeDetailViewModel>(viewModel =>
                {
                    viewModel.Personaje = PersonajeSeleccionado;
                    viewModel.Titulo = PersonajeSeleccionado.name;
                    viewModel.RutaImagen = PersonajeSeleccionado.thumbnail.rutaImagen;
                });
                PersonajeSeleccionado = null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}
