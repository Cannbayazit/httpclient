using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using httpclient.Models;
using Newtonsoft.Json;

namespace httpclient.Services
{
    public class ToDoService
    {
        public HttpClient HttpClient { get; set; }


        public ToDoService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<ToDo> GetToDoAsync(int Id)
        {
            var result = await HttpClient.GetAsync($"/todos/{Id}");
            if (result.IsSuccessStatusCode)
            {
                string resultData = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ToDo>(resultData);
            }
            else
            {
                return new ToDo();
            }
        }

        public async Task<List<ToDo>> GetAllToDoAsync()
        {
            var result = await HttpClient.GetAsync("/todos");
            if (result.IsSuccessStatusCode)
            {
                string resultData = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ToDo>>(resultData);
            }
            else
            {
                return new List<ToDo>();
            }
        }

    }
}