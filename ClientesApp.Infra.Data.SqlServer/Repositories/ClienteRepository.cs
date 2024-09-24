using ClientesApp.Domain.Entities;
using ClientesApp.Domain.Interfaces.Repositories;
using ClientesApp.Infra.Data.SqlServer.Contexts;

namespace ClientesApp.Infra.Data.SqlServer.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente, Guid>, IClienteRepository
    {
        public ClienteRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
