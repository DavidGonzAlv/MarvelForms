using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Marvel.Core.Models.PersonajesModel;

namespace MarvelForms.Services.BaseService.MarvelService
{
    public interface IMarvelService
    {

        /// <summary>
        /// Devuelve una <see cref="List{T}"/> where <see cref="{T}"/> : <see cref="Personaje"/>
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns></returns>
        Task<List<Personaje>> GetPersonajes(string ruta);
    }
}
