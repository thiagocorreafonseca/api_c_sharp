using Control.Core.Entities;
using Control.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.Infrastructure.Persistence.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly ControlDbContext _dbContext;

        public ClientRepository(ControlDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Add(Client client)
        {
            await _dbContext.Clients.AddAsync(client);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Client>> GetAll()
        {
            return await _dbContext.Clients.ToListAsync();
        }

        public async Task<Client> GetById(int id)
        {
            return await _dbContext.Clients.SingleOrDefaultAsync(p => p.Id == id);
        }
    }
}
