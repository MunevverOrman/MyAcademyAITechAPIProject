using AITech.DataAccess.Repositories.TeamHeaderRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.TeamHeaderDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.TeamHeaderServices
{
    public class TeamHeaderService(ITeamHeaderRepository _teamHeaderRepository, IUnitOfWork _unitOfWork) : ITeamHeaderService
    {
        public async Task TCreateAsync(CreateTeamHeaderDto createDto)
        {
            var teamHeader = createDto.Adapt<TeamHeader>();
            await _teamHeaderRepository.CreateAsync(teamHeader);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var teamHeader = await _teamHeaderRepository.GetByIdAsync(id);
            if (teamHeader is null)
            {
                throw new Exception("Team Header is not found");
            }

            _teamHeaderRepository.Delete(teamHeader);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultTeamHeaderDto>> TGetAllAsync()
        {
            var teamHeaders = await _teamHeaderRepository.GetAllAsync();
            return teamHeaders.Adapt<List<ResultTeamHeaderDto>>();
        }

        public async Task<ResultTeamHeaderDto> TGetByIdAsync(int id)
        {
            var teamHeader = await _teamHeaderRepository.GetByIdAsync(id);
            if (teamHeader is null)
            {
                throw new Exception("Team header is not found");
            }
            return teamHeader.Adapt<ResultTeamHeaderDto>();
        }

        public async Task TUpdateAsync(UpdateTeamHeaderDto updateDto)
        {
            var teamHeader = updateDto.Adapt<TeamHeader>();
            _teamHeaderRepository.Update(teamHeader);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
