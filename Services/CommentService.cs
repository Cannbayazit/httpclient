using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using httpclient.Models;
using Newtonsoft.Json;

namespace httpclient.Services
{
    public class CommentService
    {
        public HttpClient HttpClient { get; set; }
        public CommentService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }


        public async Task<List<Comment>> GetAllCommentAsync()
        {
            var result = await HttpClient.GetAsync("/comments");
            if (result.IsSuccessStatusCode)
            {
                string resultData = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Comment>>(resultData);
            }
            else
            {
                return new List<Comment>();
            }
        }



    }
}