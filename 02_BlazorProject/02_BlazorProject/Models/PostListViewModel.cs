using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_BlazorProject.Models
{
    public class PostListViewModel
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}
