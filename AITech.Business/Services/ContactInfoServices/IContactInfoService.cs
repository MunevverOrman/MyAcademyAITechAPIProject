using AITech.Business.Services.GenericServices;
using AITech.DTO.ContactInfoDtos;

namespace AITech.Business.Services.ContactInfoServices
{
    public interface IContactInfoService:IGenericService<ResultContactInfoDto,CreateContactInfoDto,UpdateContactInfoDto>
    {
    }
}
