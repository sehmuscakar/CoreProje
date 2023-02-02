using EntityLayer.conrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
  public  class Context: IdentityDbContext<WriterUser,WriterRole,int> // miras alacak burda ,DbContext bunu aktifleştirmek için using Microsoft.EntityFrameworkCore; eklenmesi lazım 
    {
       // veritabanını çağıracaz dbset olarak properti gibi çağıracaz 

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // bu syntax yapısı sabit gibi düşün core de veritabanı bağlantısı böyle oluyor sql de vartabı olarak yansıtılacak 
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-O9RRR03;database=CoreProjeDB;integrated security=true");
        }

        public DbSet<About> Abouts { get; set; }//bunlar entity layer deki veritabanında oluşacak şeyler Abouts buda tablonun ismi olacak önemli About buda c# tarafından kulanılacak sınıfın ismi 

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }

        public DbSet<Message> Messages2 { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }

        public DbSet<SocialMedia> SocialMedias { get; set; }

        public DbSet<Testimonial> Testimonials { get; set; }

        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<Test1> Test1s { get; set; }

        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<WriterMessage> WriterMessages { get; set; }










    }
}
