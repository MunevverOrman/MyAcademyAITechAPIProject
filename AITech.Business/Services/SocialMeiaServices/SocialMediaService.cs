using AITech.DataAccess.Repositories.SocialMediaRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.AboutDtos;
using AITech.DTO.SocialMediaDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.SocialMeiaServices
{
    public class SocialMediaService(ISocialMediaRepository _socialMediaRepository,IUnitOfWork _unitOfWork) : ISocialMediaService
    {
        public async Task TCreateAsync(CreateSocialMediaDto createDto)
        {
            var socialMedia = createDto.Adapt<SocialMedia>();
            await _socialMediaRepository.CreateAsync(socialMedia);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var socialMedia = await _socialMediaRepository.GetByIdAsync(id);
            if (socialMedia is null)
            {
                throw new Exception("social Media is not found");
            }

            _socialMediaRepository.Delete(socialMedia);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultSocialMediaDto>> TGetAllAsync()
        {
            var socialMedias = await _socialMediaRepository.GetAllAsync();
            return socialMedias.Adapt<List<ResultSocialMediaDto>>();
        }

        public async Task<ResultSocialMediaDto> TGetByIdAsync(int id)
        {
            var socialMedia = await _socialMediaRepository.GetByIdAsync(id);
            if (socialMedia is null)
            {
                throw new Exception("about is not found");
            }
            return socialMedia.Adapt<ResultSocialMediaDto>();
        }

        public async Task TUpdateAsync(UpdateSocialMediaDto updateDto)
        {
            var socialMedia = updateDto.Adapt<SocialMedia>();
            _socialMediaRepository.Update(socialMedia);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
