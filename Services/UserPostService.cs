using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using httpclient.Models;
using Newtonsoft.Json;

namespace httpclient.Services
{

    public class UserPostService
    {
        public HttpClient HttpClient { get; set; }
        public UserPostService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<List<UserPost>> GetAllPostAsync()
        {
            var result = await HttpClient.GetAsync("/posts");
            if (result.IsSuccessStatusCode)
            {
                string resultData = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<UserPost>>(resultData);
            }
            else
            {
                return new List<UserPost>();
            }
        }

        public async Task PostAllContentAsync()
        {
            var pData = JsonContent.Create(UserPost.userPosts);
            var data = await HttpClient.PostAsync("/posts", pData);
        }
    }
}