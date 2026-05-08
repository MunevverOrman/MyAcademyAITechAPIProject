using AITech.DataAccess.Repositories.AboutItemRepositories;
using AITech.DataAccess.Repositories.AboutRepositories;
using AITech.DataAccess.Repositories.BannerRepositories;
using AITech.DataAccess.Repositories.CategoryRepositories;
using AITech.DataAccess.Repositories.ChooseRepositories;
using AITech.DataAccess.Repositories.ContactInfoRepositories;
using AITech.DataAccess.Repositories.ContactMessageRepositories;
using AITech.DataAccess.Repositories.FAQRepositories;
using AITech.DataAccess.Repositories.FeatureRepositories;
using AITech.DataAccess.Repositories.NewletterRepositories;
using AITech.DataAccess.Repositories.ProjectRepositories;
using AITech.DataAccess.Repositories.SocialMediaRepositories;
using AITech.DataAccess.Repositories.TeamHeaderRepositories;
using AITech.DataAccess.Repositories.TeamMemberRepositories;
using AITech.DataAccess.Repositories.TestimonialRepositories;
using AITech.DataAccess.UnitOfWorks;
using Microsoft.Extensions.DependencyInjection;

namespace AITech.DataAccess.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddDataAccessServices(this IServiceCollection services)
        {
            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<IAboutItemRepository, AboutItemRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<IBannerRepository, BannerRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IChooseRepository, ChooseRepository>();
            services.AddScoped<IContactInfoRepository, ContactInfoRepository>();
            services.AddScoped<IFAQRepository, FAQRepository>();
            services.AddScoped<IFeatureRepository, FeatureRepository>();
            services.AddScoped<INewletterRepository, NewletterRepository>();
            services.AddScoped<ISocialMediaRepository, SocialMediaRepository>();
            services.AddScoped<ITestimonialRepository, TestimonialRepository>();
            services.AddScoped<IContactMessageRepository, ContactMessageRepository>();
            services.AddScoped<ITeamHeaderRepository, TeamHeaderRepository>();
            services.AddScoped<ITeamMemberRepository, TeamMemberRepository>();



            services.AddScoped<IUnitOfWork, UnitOfWork>();

           
        }
    }
}
