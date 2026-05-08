using AITech.Business.Services.GenericServices;
using AITech.DTO.SocialMediaDtos;

namespace AITech.Business.Services.SocialMeiaServices
{
    public interface ISocialMediaService : IGenericService<ResultSocialMediaDto, CreateSocialMediaDto, UpdateSocialMediaDto>
    {
    }
}
