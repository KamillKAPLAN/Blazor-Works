using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AKSoftware.WebApi.Client;
using PlannerApp.Shared.Models;

namespace PlannerApp.Shared.Services
{
    public class AuthenticationService
    {
        private readonly string _baseUrl;

        ServiceClient serviceClient = new ServiceClient();

        public AuthenticationService(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public async Task<UserManagerResponse> RegisterUserAsync(RegisterRequest request)
        {
            var response = await serviceClient.PostAsync<UserManagerResponse>($"{_baseUrl}/api/Auth/Register", request);
            return response.Result;
        }

        public async Task<UserManagerResponse> LoginUserAsync(LoginRequest request)
        {
            var response = await serviceClient.PostAsync<UserManagerResponse>($"{_baseUrl}/api/Auth/Login", request);
            return response.Result;
        }

        /*
         * Login Users
         * 
         * "email": "kamilkaplnn@gmail.com",
         * "password": "M123l_"
         * 
         * "email": "hsynAkin@gmail.com",
         * "password": "Hsyn123_"
         * 
         * "email": "ilyasbural@gmail.com",
         * "password": "Ilyas_123"
         * 
         * "email": "ardaParlak@gmail.com",
         * "password": "Arda123_"
         */
    }
}
