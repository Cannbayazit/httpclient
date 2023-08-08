using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using httpclient.Models;
using Newtonsoft.Json;

namespace httpclient.Services
{
    public class PhotosService
    {
        public HttpClient HttpClient { get; set; }

        public PhotosService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<List<Photos>> GetAllPhotoAsync()
        {
            var result = await HttpClient.GetAsync("/photos");
            if (result.IsSuccessStatusCode)
            {
                string resultData = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Photos>>(resultData);
            }
            else
            {
                return new List<Photos>();
            }
        }


    }
}