
namespace BookAPI.Controllers
{
    internal interface IBookRepository
    {
        Task Delete(object id);
    }
}