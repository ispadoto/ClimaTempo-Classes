using AgroClinic.Infra.CrossCutting.Shared.ExternalsViewModel.ClimaTempo;
using AgroClinic.Infra.CrossCutting.Shared.Utils.BaseClient;
using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Configuration;

namespace AgroClinic.Services.Externals.WeatherAPI
{
    public class ClimaTempo : BaseClient, IDisposable
    {
        public static string EndPoint { get { return ConfigurationManager.AppSettings["ClimaTempoEndPoint"].ToString(); } }
        public string APIKey { get; private set; }

        public ClimaTempo(ICacheService cache, IDeserializer serializer, IErrorLogger errorLogger)
               : base(cache, serializer, errorLogger, EndPoint)
        {
            this.APIKey = ConfigurationManager.AppSettings["ClimaTempoKey"];
        }

        /// <summary>
        /// Get forecast of X days for the specified city
        /// http://apiadvisor.climatempo.com.br/api/v1/forecast/locale/3477/days/15?token=your-app-token
        /// </summary>
        /// <param name="CityId">an int, reference: http://apiadvisor.climatempo.com.br/doc/index.html#api-Locale-GetCityByNameAndState</param>
        /// <param name="Days">number of the forecast days (default: 15)</param>
        /// <returns></returns>
        public Forecast GetForecastCity(int CityId, int Days=15)
        {
            RestRequest request = new RestRequest("v1/forecast/locale/{city}/days/{days}", Method.GET);
            request.AddUrlSegment("city", CityId.ToString());
            request.AddUrlSegment("days", Days.ToString());
            request.AddQueryParameter("token", APIKey);
            return Get<Forecast>(request);
        }


        #region IDisposable Support
        private bool disposedValue = false; // Para detectar chamadas redundantes

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: descartar estado gerenciado (objetos gerenciados).
                }

                // TODO: liberar recursos não gerenciados (objetos não gerenciados) e substituir um finalizador abaixo.
                // TODO: definir campos grandes como nulos.

                disposedValue = true;
            }
        }

        // TODO: substituir um finalizador somente se Dispose(bool disposing) acima tiver o código para liberar recursos não gerenciados.
        // ~ClimaTempoBase() {
        //   // Não altere este código. Coloque o código de limpeza em Dispose(bool disposing) acima.
        //   Dispose(false);
        // }

        // Código adicionado para implementar corretamente o padrão descartável.
        void IDisposable.Dispose()
        {
            // Não altere este código. Coloque o código de limpeza em Dispose(bool disposing) acima.
            Dispose(true);
            // TODO: remover marca de comentário da linha a seguir se o finalizador for substituído acima.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}