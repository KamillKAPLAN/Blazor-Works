using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorLearn.Models;

namespace BlazorLearn.Services
{
    interface IApiService
    {
        Task<PostsItem[]> GetPosts();
    }
}
