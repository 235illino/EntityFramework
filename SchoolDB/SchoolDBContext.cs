using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDB
{
    public class SchoolDBContext : DbContext
    {
        IConfiguration appConfig;

        public SchoolDBContext(IConfiguration config)
        {
            appConfig = config;
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(appConfig.GetConnectionString("SchoolDBLocalConnection"));
        }
    }
}
