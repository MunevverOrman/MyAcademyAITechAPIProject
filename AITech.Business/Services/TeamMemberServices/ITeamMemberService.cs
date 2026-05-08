using AITech.Business.Services.GenericServices;
using AITech.DTO.TeamMemberDtos;

namespace AITech.Business.Services.TeamMemberServices
{
    public interface ITeamMemberService:IGenericService<ResultTeamMemberDto,CreateTeamMemberDto,UpdateTeamMemberDto>
    {
    }
}
