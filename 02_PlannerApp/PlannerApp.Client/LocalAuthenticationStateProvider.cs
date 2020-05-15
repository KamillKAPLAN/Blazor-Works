using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using PlannerApp.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PlannerApp.Client
{
    public class LocalAuthenticationStateProvider : AuthenticationStateProvider
    {

        public readonly ILocalStorageService _storageService;

        public LocalAuthenticationStateProvider(ILocalStorageService storageService)
        {
            _storageService = storageService;
        }

        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            if (await _storageService.ContainKeyAsync("User"))
            {
                var userInfo = await _storageService.GetItemAsync<LocalUserInfo>("User");

                var claims = new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, userInfo.Id),
                    new Claim("FirstName", userInfo.FirstName),
                    new Claim("LastName", userInfo.LastName),
                    new Claim("AccessToken", userInfo.AccessToken),
                    new Claim("Email", userInfo.Email),
                };

                var identity = new ClaimsIdentity(claims, "BearerToken");
                var user = new ClaimsPrincipal(identity);

                return new AuthenticationState(user);
            }
            return new AuthenticationState(new ClaimsPrincipal());
        }
    }
}
