using ConsoleApp34.Models;
using ConsoleApp34.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34.Data
{
    internal class DataContext:DbContext
    {
        public DbSet<Direction> Entities {  get; set; }

        public DataContext(DbContextOptions options) : base(options)
        { 
        }
    }
}
