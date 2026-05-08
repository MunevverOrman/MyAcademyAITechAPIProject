using AITech.Business.Services.GenericServices;
using AITech.DTO.NewsletterDtos;

namespace AITech.Business.Services.NewletterServices
{
    public interface INewletterService:IGenericService<ResultNewsletterDto,CreateNewsletterDto,UpdateNewsletterDto>
    {
    }
}
