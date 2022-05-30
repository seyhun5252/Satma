using EntityLayer;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = (localdb)\\ProjectsV13 ; database = SataışYeriDb ;integrated security=true;");
        }

        DbSet<Blog> Blogs { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Comment> Comments { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<Home> Homes { get; set; }
        DbSet<OurTeam> ourTeams { get; set; }
        DbSet<PricingTables> pricingTables { get; set; }
        DbSet<Service> Services { get; set; }
        DbSet<Work> Works { get; set; }
        DbSet<User> Users { get; set; }
    }
}
