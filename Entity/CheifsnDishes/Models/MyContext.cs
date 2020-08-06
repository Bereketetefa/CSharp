using CheifsnDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace CheifsnDishes.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Chef> chefs {get; set;}
        public DbSet<Dish> dishs {get; set;}
    }
}
