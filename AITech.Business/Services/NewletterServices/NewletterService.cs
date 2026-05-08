using AITech.DataAccess.Repositories.NewletterRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.NewsletterDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.NewletterServices
{
    public class NewletterService(INewletterRepository _newletterRepository,IUnitOfWork _unitOfWork) : INewletterService
    {
        public async Task TCreateAsync(CreateNewsletterDto createDto)
        {
            var newletter= createDto.Adapt<Newsletter>();
            await _newletterRepository.CreateAsync(newletter);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var newletter= await _newletterRepository.GetByIdAsync(id);
            if (newletter is null)
            {
                throw new Exception("newletter is not found");
            }
            _newletterRepository.Delete(newletter);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultNewsletterDto>> TGetAllAsync()
        {
            var newletter= await _newletterRepository.GetAllAsync();
            return newletter.Adapt<List<ResultNewsletterDto>>();
        }

        public async Task<ResultNewsletterDto> TGetByIdAsync(int id)
        {
            var newletter = await _newletterRepository.GetByIdAsync(id);
            return newletter.Adapt<ResultNewsletterDto>();
        }

        public async Task TUpdateAsync(UpdateNewsletterDto updateDto)
        {
           var newletter= updateDto.Adapt<Newsletter>();
             _newletterRepository.Update(newletter);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
