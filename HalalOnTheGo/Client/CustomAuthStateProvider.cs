using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace HalalOnTheGo.Client
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService _localStorage;

        public CustomAuthStateProvider(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var state = new AuthenticationState(new ClaimsPrincipal()); //The "ClaimPrincipal" is the same in essence as assigned an UNATHENTICATED user. This is because it has no name, email or ID.

            string email = await _localStorage.GetItemAsStringAsync("email");
            if (!string.IsNullOrEmpty(email))
            {
                var identity = new ClaimsIdentity(new[]
                {
                    new Claim (ClaimTypes.Email, email),
                }, "test authentication type");

                state = new AuthenticationState(new ClaimsPrincipal(identity)); //NOW, the "claimsprinicpal" is NOT empty. It gets the current user identity which is the USER email.
            }

            NotifyAuthenticationStateChanged(Task.FromResult(state)); //IMPORTANT - the notifyauthenticatiuonstate EVENT gets called which tells it that the user state has changed. It then can assign the correct state to the correct user email / account! 
            return state;
        }
    }
}
