using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoSalesWebMvc.Models
{
    public class ProjetoSalesWebMvcContext : DbContext
    {
        public ProjetoSalesWebMvcContext (DbContextOptions<ProjetoSalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoSalesWebMvc.Models.Department> Department { get; set; }
    }
}
