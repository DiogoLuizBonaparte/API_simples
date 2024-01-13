using Microsoft.EntityFrameworkCore;

namespace API.Infraestrutura
{
    public class SQLContext : DbContext
    {
        public SQLContext() { }
        public SQLContext(DbContextOptions<SQLContext> options) : base(options) { }
    }
}
