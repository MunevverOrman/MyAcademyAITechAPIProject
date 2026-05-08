using AITech.DataAccess.Repositories.ContactInfoRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.AboutDtos;
using AITech.DTO.ContactInfoDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.ContactInfoServices
{
    public class ContactInfoService(IContactInfoRepository _contactInfoRepository,IUnitOfWork _unitOfWork) : IContactInfoService
    {
        public async Task TCreateAsync(CreateContactInfoDto createDto)
        {
            var contactInfo = createDto.Adapt<ContactInfo>();
            await _contactInfoRepository.CreateAsync(contactInfo);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var contactInfo = await _contactInfoRepository.GetByIdAsync(id);
            if (contactInfo is null)
            {
                throw new Exception("contact Info is not found");
            }

            _contactInfoRepository.Delete(contactInfo);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultContactInfoDto>> TGetAllAsync()
        {
            var contactInfos = await _contactInfoRepository.GetAllAsync();
            return contactInfos.Adapt<List<ResultContactInfoDto>>();
        }

        public async Task<ResultContactInfoDto> TGetByIdAsync(int id)
        {
            var contactInfo = await _contactInfoRepository.GetByIdAsync(id);
            if (contactInfo is null)
            {
                throw new Exception("contact Info is not found");
            }
            return contactInfo.Adapt<ResultContactInfoDto>();
        }

        public async Task TUpdateAsync(UpdateContactInfoDto updateDto)
        {
            var contactInfo = updateDto.Adapt<ContactInfo>();
            _contactInfoRepository.Update(contactInfo);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
