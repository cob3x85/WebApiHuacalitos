using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace HuacalitosApi.Models
{
  public class HuacalitosContext : DbContext
  {
    public HuacalitosContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Client> Clients { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Note> Notes { get; set; }

  }
}
