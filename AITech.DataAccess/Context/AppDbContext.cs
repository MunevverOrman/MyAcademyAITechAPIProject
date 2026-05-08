using AITech.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace AITech.DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //singularize,pluralize
        public DbSet<About> Abouts { get; set; }

        public DbSet<AboutItem> AboutItems { get; set; }

        public DbSet<Banner> Banners { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Choose> Chooses { get; set; }

        public DbSet<FAQ> FAQs { get; set; }

        public DbSet<Feature> Features { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<SocialMedia> SocialMedias { get; set; }

        public DbSet<Testimonial> Testimonials { get; set; }

        public DbSet<ContactInfo> ContactInfos{ get; set; }

        public DbSet<ContactMessage> ContactMessages{ get; set; }

        public DbSet<Newsletter> Newsletters{ get; set; }

        public DbSet<TeamHeader> TeamHeaders{ get; set; }

        public DbSet<TeamMember> TeamMembers{ get; set; }



    }
}
