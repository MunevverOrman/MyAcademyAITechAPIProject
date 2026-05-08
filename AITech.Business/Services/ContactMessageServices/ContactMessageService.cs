using AITech.DataAccess.Repositories.ContactMessageRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.AboutDtos;
using AITech.DTO.ContactMessageDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.ContactMessageServices
{
    public class ContactMessageService(IContactMessageRepository _contactMessageRepository, IUnitOfWork _unitOfWork) : IContactMessageService
    {
        public async Task TCreateAsync(CreateContactMessageDto createDto)
        {
            var contactMessage= createDto.Adapt<ContactMessage>();
            await _contactMessageRepository.CreateAsync(contactMessage);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var contactMessage=await _contactMessageRepository.GetByIdAsync(id);
            if (contactMessage is null)
            {
                throw new Exception("contact message is not found");
            }
            _contactMessageRepository.Delete(contactMessage);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultContactMessageDto>> TGetAllAsync()
        {
            var contactMessages = await _contactMessageRepository.GetAllAsync();
            return contactMessages.Adapt<List<ResultContactMessageDto>>();
        }

        public async Task<ResultContactMessageDto> TGetByIdAsync(int id)
        {
            var contactMessage = await _contactMessageRepository.GetByIdAsync(id);
            if (contactMessage is null)
            {
                throw new Exception("about is not found");
            }
            return contactMessage.Adapt<ResultContactMessageDto>();
        }

        public async Task TUpdateAsync(UpdateContactMessageDto updateDto)
        {
            var contactMessage = updateDto.Adapt<ContactMessage>();
            _contactMessageRepository.Update(contactMessage);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
