using AKSoftware.WebApi.Client;
using PlannerApp.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlannerApp.Shared.Services
{
    public class ToDoItemsService
    {
        private readonly string _baseUrl;

        ServiceClient serviceClient = new ServiceClient();

        public ToDoItemsService(string baseUrl)
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
        /// Insert a new ToDo item inside a specific Plan
        /// </summary>
        /// <param name="model">object represent the item to be added</param>
        /// <returns></returns>
        public async Task<ToDoItemSingleResponse> CreateItemAsync(ToDoItemRequest model)
        {
            var response = await serviceClient.PostProtectedAsync<ToDoItemSingleResponse>($"{_baseUrl}/api/ToDoItems", model);
            return response.Result;
        }

        /// <summary>
        /// Edit the descripiton of a specific item
        /// </summary>
        /// <param name="model">object represent the item to be edited</param>
        /// <returns></returns>
        public async Task<ToDoItemSingleResponse> EditItemAsync(ToDoItemRequest model)
        {
            var response = await serviceClient.PutProtectedAsync<ToDoItemSingleResponse>($"{_baseUrl}/api/ToDoItems", model);
            return response.Result;
        }

        /// <summary>
        /// Mark the item as done if it's undone and vice versa
        /// </summary>
        /// <param name="id">Id of the item to be updated</param>
        /// <returns></returns>
        public async Task<ToDoItemSingleResponse> ChangeItemsStateAsync(string id)
        {
            var response = await serviceClient.PutProtectedAsync<ToDoItemSingleResponse>($"{_baseUrl}/api/ToDoItems/{id}", null);
            return response.Result;
        }

        /// <summary>
        /// Mark the item as done if it's undone and vice versa
        /// </summary>
        /// <param name="id">Id of the item to be updated</param>
        /// <returns></returns>
        public async Task<ToDoItemSingleResponse> DeleteItemAsync(string id)
        {
            var response = await serviceClient.DeleteProtectedAsync<ToDoItemSingleResponse>($"{_baseUrl}/api/ToDoItems/{id}");
            return response.Result;
        }
    }
}
