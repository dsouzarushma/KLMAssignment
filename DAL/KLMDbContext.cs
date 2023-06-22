using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KLMAssignment.Models;
using Microsoft.EntityFrameworkCore;


namespace KLMAssignment.DBContext
{
    public class KLMDbContext:DbContext
    {
        public KLMDbContext(DbContextOptions<KLMDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<VisitsTemp> VisitsTemp { get; set; }
    }
}
