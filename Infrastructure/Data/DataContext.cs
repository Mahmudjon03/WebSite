using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace WebSite.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> option):base(option)
        { }
        DbSet<Product> Products { get; set; }
    }
}
