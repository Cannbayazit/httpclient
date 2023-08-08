using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using httpclient.Models;
using Newtonsoft.Json;

namespace httpclient.Services
{
    public class UserService
    {
        public HttpClient HttpClient { get; set; }

        public UserService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<List<User>> GetAllUserAsync()
        {
            var result = await HttpClient.GetAsync("/users");
            if (result.IsSuccessStatusCode)
            {
                string resultData = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<User>>(resultData);
            }
            else
            {
                return new List<User>();
            }
        }


        // public async Task<List<Photos>> GetPhotoAsync(int id)
        // {
        //     var result = await HttpClient.GetAsync($"/photos/{id}");
        //     if (result.IsSuccessStatusCode)
        //     {
        //         var resultData = await result.Content.ReadAsStringAsync();
        //         return JsonConvert.DeserializeObject<List<Photos>>(resultData);
        //     }
        //     else
        //     {
        //         return new List<Photos>();
        //     }
        // }

        // public async Task<List<Comment>> GetCommentAsync(int id)
        // {
        //     var result = await HttpClient.GetAsync($"/comments/{id}");
        //     if (result.IsSuccessStatusCode)
        //     {
        //         var resultData = await result.Content.ReadAsStringAsync();
        //         return JsonConvert.DeserializeObject<List<Comment>>(resultData);
        //     }
        //     else
        //     {
        //         return new List<Comment>();
        //     }
        // }
    }
}