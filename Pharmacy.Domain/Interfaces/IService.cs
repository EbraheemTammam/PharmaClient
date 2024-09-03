namespace Pharmacy.Domain.Interfaces;


public interface IService<TModel>
{
    Task<IEnumerable<TModel>> GetAll();
    Task<TModel> GetById<TId>(TId id);
    Task<TModel> Create<TModelCreate>(TModelCreate model);
    Task<TModel> Update<TId, TModelUpdate>(TId Id, TModelUpdate model);
    Task Delete<TId>(TId Id);
}
