using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using moboer.Models;

namespace moboer.DAL
{
    public class moboerDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<UserConfig> UserConfig { get; set; }
        public moboerDbContext()
        :base("DefaultConnection")
        {

        }

    }
}
