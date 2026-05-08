using AITech.DTO.SocialMediaDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.SocialMeiaServices
{
    public class SocialMeiaService : ISocialMediaService
    {
        public Task TCreateAsync(CreateSocialMediaDto createDto)
        {
            throw new NotImplementedException();
        }

        public Task TDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultSocialMediaDto>> TGetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResultSocialMediaDto> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(UpdateSocialMediaDto updateDto)
        {
            throw new NotImplementedException();
        }
    }
}
