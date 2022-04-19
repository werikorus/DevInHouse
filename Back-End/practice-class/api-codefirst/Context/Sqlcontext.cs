using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_codefirst.Models;

namespace api_codefirst.Context
{
    public class Sqlcontext : DbContext 
    {
        public Sqlcontext(DbContextOptions<Sqlcontext> options) : base(options) { }

        public DbSet<Imovel> Imoveis { get; set; }

    }
}
