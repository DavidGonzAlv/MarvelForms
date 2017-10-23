using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MarvelForms.Util;
using RestSharp;

namespace MarvelForms.Services.BaseService
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private RestClient RestClient => new RestClient(Cadenas.MarvelApiUrl);

        public async Task<T> Get(string ruta)
        {
            try
            {
                var request = new RestRequest(ruta, Method.GET);

                var response = await RestClient.ExecuteGetTaskAsync<T>(request);

                return response.Data;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception();
            }
        }
    }
}
