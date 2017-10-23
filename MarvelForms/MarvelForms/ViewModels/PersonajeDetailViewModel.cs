using System;
using System.Collections.Generic;
using System.Text;
using Marvel.Core.Models.PersonajesModel;
using MarvelForms.Services.BaseService.MarvelService;
using MvvmLibrary.Factorias;
using MvvmLibrary.Factorias.Navegacion;

namespace MarvelForms.ViewModels
{
    public class PersonajeDetailViewModel : BaseViewModel
    {
        public string RutaImagen { get; set; }
        public Personaje Personaje { get; set; }

        public PersonajeDetailViewModel(INavigator navigator, IMarvelService servicio, IPage page) : base(navigator, servicio, page)
        {
        }
    }
}
