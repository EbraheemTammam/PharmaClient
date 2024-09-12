using Pharmacy.Domain.Interfaces;
using System.Net.Http.Json;

namespace Pharmacy.Application.Repositories;


public class GenericRepository<TModel> : IRepository<TModel>
{
    protected readonly HttpClient _client;

    protected string _path;

    public GenericRepository(HttpClient client, string path)
    {
        _client = client;
        _path = path;
    }

    public async virtual Task<IEnumerable<TModel>> GetAll() =>
        (await _client.GetFromJsonAsync<IEnumerable<TModel>>(_path))!;

    public async virtual Task<TModel> GetById<TId>(TId id) =>
        (await _client.GetFromJsonAsync<TModel>($"{_path}/{id}"))!;

    public async virtual Task<TModel> Create<TModelCreate>(TModelCreate model) =>
        (await
            (await _client.PostAsJsonAsync(_path, model)).Content
            .ReadFromJsonAsync<TModel>()
        )!;

    public async virtual Task<TModel> Update<TId, TModelUpdate>(TId Id, TModelUpdate model) =>
        (await
            (await _client.PutAsJsonAsync($"{_path}/{Id}", model)).Content
            .ReadFromJsonAsync<TModel>()
        )!;

    public async virtual Task Delete<TId>(TId Id) =>
        await _client.DeleteAsync($"{_path}/{Id}");
}
