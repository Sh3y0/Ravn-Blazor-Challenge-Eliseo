using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace Ravn.Logic.Extentions
{
    public static class httpClientExtentions
    {
        public static async Task<T> GetDataAsync<T>(this HttpClient httpClient, string requestUri)
        {
            var response = await httpClient.GetAsync(requestUri).ConfigureAwait(false);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Api fail with status code: {response.StatusCode}");
            }

            var streamData = await response.Content.ReadAsStreamAsync();
            var data = await JsonSerializer.DeserializeAsync<T>(streamData, options: new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return data;
        }
    }
}
