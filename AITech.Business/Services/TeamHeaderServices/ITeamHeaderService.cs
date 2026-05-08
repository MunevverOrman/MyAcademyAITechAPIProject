using AITech.Business.Services.GenericServices;
using AITech.DTO.TeamHeaderDtos;

namespace AITech.Business.Services.TeamHeaderServices
{
    public interface ITeamHeaderService:IGenericService<ResultTeamHeaderDto,CreateTeamHeaderDto,UpdateTeamHeaderDto>
    {
    }
}
