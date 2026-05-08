using AITech.DataAccess.Repositories.TeamMemberRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.TeamMemberDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.TeamMemberServices
{
    public class TeamMemberService(ITeamMemberRepository _teamMemberRepository, IUnitOfWork _unitOfWork) : ITeamMemberService
    {
        public async Task TCreateAsync(CreateTeamMemberDto createDto)
        {
            var teamMember= createDto.Adapt<TeamMember>();
            await _teamMemberRepository.CreateAsync(teamMember);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
           var teamMember= await _teamMemberRepository.GetByIdAsync(id);
            if (teamMember is null)
            {
                throw new Exception("Team member is not found");
            }
            _teamMemberRepository.Delete(teamMember);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultTeamMemberDto>> TGetAllAsync()
        {
            var teamMembers= await _teamMemberRepository.GetAllAsync();
            return teamMembers.Adapt<List<ResultTeamMemberDto>>();  
        }

        public async Task<ResultTeamMemberDto> TGetByIdAsync(int id)
        {
            var teamMember = await _teamMemberRepository.GetByIdAsync(id);
            if (teamMember is null)
            {
                throw new Exception("team member is not found");
            }
            return teamMember.Adapt<ResultTeamMemberDto>();
        }

        public async Task TUpdateAsync(UpdateTeamMemberDto updateDto)
        {
           var teamMember= updateDto.Adapt<TeamMember>();           
           _teamMemberRepository.Update(teamMember);
           await _unitOfWork.SaveChangesAsync();
        }
    }
}
