namespace AITech.DTO.BannerDtos
{
    public record UpdateBannerDto(int id, string Title, string? Description, string? ImageUrl, bool IsActive);
    
}
