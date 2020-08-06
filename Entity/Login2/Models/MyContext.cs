using Login2.Models;
using Microsoft.EntityFrameworkCore;

namespace Login2.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        
        // this is the variable we will use to connect to the MySQL table, Lizards
        public DbSet<User> UsersInfo { get; set; }
    }
}