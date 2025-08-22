using DemoMVC.Models;

namespace DemoMVC.Services
{
    public class SmartyService
    {
        private readonly HttpClient _httpClient;
        private readonly string _authId = "YOUR_SMARTY_AUTH_ID";
        private readonly string _authToken = "YOUR_SMARTY_AUTH_TOKEN";

        public SmartyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> ValidateAddressAsync(AddressRequestViewModel address)
        {
            var url = $"https://us-street.api.smarty.com/street-address?auth-id={_authId}&auth-token={_authToken}&street={address.Street}&city={address.City}&state={address.State}";

            var response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
                return "Address validation failed.";

            var json = await response.Content.ReadAsStringAsync();
            return json;
        }
    }
}
