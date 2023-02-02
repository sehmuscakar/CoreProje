using CoreProjeApi.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjeApi.DAL.ApiContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // bu syntax yapısı sabit gibi düşün core de veritabanı bağlantısı böyle oluyor sql de vartabı olarak yansıtılacak 
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-O9RRR03;database=CoreProjeDB2;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
    }
}
