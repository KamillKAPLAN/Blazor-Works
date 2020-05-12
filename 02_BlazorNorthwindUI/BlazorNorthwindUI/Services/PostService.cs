using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorNorthwindUI.Models;

namespace BlazorNorthwindUI.Services
{
    public class PostService : IPostService /* IPostService'i implemente ediyoruz. */
    {
        private HttpClient _httpClient;

        public PostService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PostListViewModel> GetPostById(int postId)
        {
            return await _httpClient.GetJsonAsync<PostListViewModel[]>("https://jsonplaceholder.typicode.com/posts/" + postId);
        }

        public async Task<PostListViewModel[]> GetPosts()
        {
            return await _httpClient.GetJsonAsync<PostListViewModel[]>("https://jsonplaceholder.typicode.com/posts");
        }

        public async Task PostCreate(PostListViewModel postListViewModel)
        {
            await _httpClient.PostJsonAsync("https://jsonplaceholder.typicode.com/posts", postListViewModel);
        }

        public async Task PostUpdate(PostListViewModel postListViewModel)
        {
            await _httpClient.PostJsonAsync("https://jsonplaceholder.typicode.com/posts", postListViewModel);
        }
    }
}
