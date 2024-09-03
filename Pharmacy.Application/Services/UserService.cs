using System.Net.Http.Json;
using Pharmacy.Domain.Models;

namespace Pharmacy.Application.Services;



public class UserService : GenericService<User>
{
    public UserService(HttpClient client) : base(client, "Api/Users") {}

    public async override Task<User> Create<UserCreate>(UserCreate model) =>
        (await
            (await _client.PostAsJsonAsync("Api/Auth/Register", model)).Content
            .ReadFromJsonAsync<User>()
        )!;
}
