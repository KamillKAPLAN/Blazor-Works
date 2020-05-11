using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorLearn.Models;

namespace BlazorLearn.Services
{
    public class MyApi : IApiService
    {
        private HttpClient _http;
        public MyApi(HttpClient http)
        {
            _http = http;
        }

        public Task<PostsItem[]> GetPosts()
        {
            return _http.GetFromJsonAsync<PostsItem[]>("https://jsonplaceholder.typicode.com/posts?id=2");
        }
    }
}
