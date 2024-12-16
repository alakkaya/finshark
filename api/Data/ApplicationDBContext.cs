using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

//creating the tables
namespace api.Data
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {

        }
        public DbSet<Stock> Stocks { get; set; } // Manipulating the db
        public DbSet<Comment> Comments { get; set; }
    }
}