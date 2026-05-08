using AITech.Business.Services.GenericServices;
using AITech.DTO.ContactMessageDtos;

namespace AITech.Business.Services.ContactMessageServices
{
    public interface IContactMessageService:IGenericService<ResultContactMessageDto,CreateContactMessageDto,UpdateContactMessageDto>
    {
    }
}
