using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace budget.entity
{
    public class Context : DbContext
    {
        public DbSet<Inkomster> Inkomster { get; set; }
        public DbSet<Utgifter> Utgifter { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = Directory.GetCurrentDirectory();
            string connString = File.ReadAllText(path + "\\ConnString.txt");
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));

            optionsBuilder.UseMySql(connString, serverVersion);
        }
    }


}
