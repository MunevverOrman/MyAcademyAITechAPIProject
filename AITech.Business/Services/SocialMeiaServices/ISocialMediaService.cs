using AITech.Business.Services.GenericServices;
using AITech.DTO.AboutDtos;
using AITech.DTO.SocialMediaDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.SocialMeiaServices
{
    public interface ISocialMediaService : IGenericService<ResultSocialMediaDto, CreateSocialMediaDto, UpdateSocialMediaDto>
    {
    }
}
