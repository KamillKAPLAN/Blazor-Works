using _02_BlazorProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNorthwindUI.Services
{
    interface IPostService
    {
        Task<PostListViewModel[]> GetPosts();
        Task<PostListViewModel> GetPostById(int postId);
        Task PostCreate(PostListViewModel postListViewModel); // Add
        Task PostUpdate(PostListViewModel postListViewModel); // Save
    }
}
