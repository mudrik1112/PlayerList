namespace PlayerList.Api.Dtos;

public record class PlayerListDto(
    int Id, 
    string Name,
    int Age,
    string BirthPlace
    );

