using Control.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Control.Core.Repositories
{
    public interface IClientRepository
    {
        Task Add(Client client);
        Task<Client> GetById(int id);
        Task<List<Client>> GetAll();
    }
}
