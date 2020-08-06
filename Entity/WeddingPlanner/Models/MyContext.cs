using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Models
{
public class MyContext : DbContext
{
public MyContext(DbContextOptions options) : base(options) { }

  // this is the variable we will use to connect to the MySQL table, Lizards
    public DbSet<User> Users { get; set; }
    public DbSet<Plan> weddPlans { get; set; }

    public DbSet<RSVP> rsvps { get; set; }


}
}
