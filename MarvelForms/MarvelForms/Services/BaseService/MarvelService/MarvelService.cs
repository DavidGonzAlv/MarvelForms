using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Marvel.Core.Models.BaseMarvelModel;
using Marvel.Core.Models.PersonajesModel;

namespace MarvelForms.Services.BaseService.MarvelService
{
   public class MarvelService : IMarvelService
    {
        public async Task<List<Personaje>> GetPersonajes(string ruta)
        {
            try
            {
                var service = new BaseService<MarvelBase<Personaje>>();
                var marvelBase = await service.Get(ruta);
                return marvelBase.data.results;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Error al recuperar los Personajes");
            }
        }
    }
}
