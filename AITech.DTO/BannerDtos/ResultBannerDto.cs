namespace AITech.DTO.BannerDtos
{
    public record ResultBannerDto(int id,
                                    string Title,
                                    string Description,
                                    string ImageUrl,
                                    bool IsActive,
                                    DateTime CreatedDate ,
                                    DateTime UpdatedDate);
    
}
