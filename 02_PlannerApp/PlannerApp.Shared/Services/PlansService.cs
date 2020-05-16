using AKSoftware.WebApi.Client;
using PlannerApp.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlannerApp.Shared.Services
{
    public class PlansService
    {
        private readonly string _baseUrl;

        ServiceClient serviceClient = new ServiceClient();

        public PlansService(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public string AccessToken
        {
            get => serviceClient.AccessToken;
            set
            {
                serviceClient.AccessToken = value;
            }
        }

        /// <summary>
        /// Retrieve all the plans from the API with pagination
        /// (TR) Sayfalandırma ile API'den tüm planları alırız.
        /// </summary>
        /// <param name="page">Number of page</param>
        /// <returns></returns>
        public async Task<PlansCollectionPagingResponse> GetAllPlansByPageAsync(int page = 1)
        {
            var response = await serviceClient.GetProtectedAsync<PlansCollectionPagingResponse>($"{_baseUrl}/api/Plans?page={page}");
            return response.Result;
        }

        /// <summary>
        /// Retrieve all the plans from the API with pagination
        /// (TR) Sayfalandırma ile API'den tüm planları alırız.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="page">Number of page</param>
        /// <returns></returns>
        public async Task<PlansCollectionPagingResponse> SearchPlansByPageAsync(string query, int page = 1)
        {
            var response = await serviceClient.GetProtectedAsync<PlansCollectionPagingResponse>($"{_baseUrl}/api/plans/search?query={query}&page={page}");
            return response.Result;
        }
    }
}
