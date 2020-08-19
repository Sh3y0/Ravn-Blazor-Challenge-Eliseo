using System.Threading.Tasks;
using Ravn.Logic.Utilities;
using Ravn.Factory.Models;
using Ravn.Domain.Entities;

namespace Ravn.Factory.Interfaces
{
    public interface IPersonLoader
    {
        Task<BasePagination<PersonModel>> LoadPerson(string page = null);
    }
}
