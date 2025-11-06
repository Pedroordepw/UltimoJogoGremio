namespace UltimoJogoGremio.Services
{
    public class ServicoPlacarGremio
    {
        private HttpClient _httpClient;
        public ServicoPlacarGremio(HttpClient clienteHttp)
        {
            _httpClient = clienteHttp;
            _httpClient.DefaultRequestHeaders.Add("X-Auth-Token", "bf9ff51b6a5548ca8be0c55c2f40188e");
        }
    }
}
