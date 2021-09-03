using Control.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.Infrastructure.Persistence
{
    public class ControlDbContext: DbContext
    {
        public ControlDbContext(DbContextOptions<ControlDbContext> options) : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
    }
}
