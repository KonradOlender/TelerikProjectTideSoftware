using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelerikProject.Models;

namespace TelerikProject.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {

        }

        public DbSet<Estate> estates { get; set; }
    }
}
