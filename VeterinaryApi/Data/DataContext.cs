using Microsoft.EntityFrameworkCore;

namespace VeterinaryApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
