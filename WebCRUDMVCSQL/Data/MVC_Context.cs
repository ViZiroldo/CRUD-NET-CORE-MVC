using Microsoft.EntityFrameworkCore;
using WebCRUDMVCSQL.Models;

namespace WebCRUDMVCSQL.Data
{
    public class MVC_Context : DbContext
    {
        public MVC_Context(DbContextOptions<MVC_Context> options)
            : base(options)
        {

        }

        public DbSet<Produto> Produto { get; set; }    
    }
}
