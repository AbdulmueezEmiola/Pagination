using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Pagination.Models.Context
{
    public interface IApplicationDbContext
    {
        DbSet<Customer> Customers { get; set; }

        Task<int> SaveChanges();
    }
}