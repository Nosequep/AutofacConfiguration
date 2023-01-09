
using AutofacTest.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutofacTest.Data
{
    public class DbModel : DbContext
    {
        public virtual DbSet<User> users { get; set; }

        public DbModel(DbContextOptions<DbModel> options) : base(options)
        {
        }
    }
}
