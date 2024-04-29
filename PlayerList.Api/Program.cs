using PlayerList.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

const string GetPlayerEndPointName = "GetPlayer";

List<PlayerListDto> players = [
    new(
        1,
        "Cristiano Ronaldo",
        38,
        "Europe"
    ),
    new(
        2,
        "Lionel Messi",
        36,
        "South America"
    ),
    new(
        3,
        "Karim Benzema",
        35,
        "Europe"
    ),
    new(
        4,
        "Erling Haaland",
        23,
        "Europe"
    ),
    new(
        5,
        "Kylian Mbappe",
        24,
        "Europe"
    ),
];

// GET /players
app.MapGet("players",()=> players );

//GET /players/1
app.MapGet("players/{id}",(int id) => players.Find(players =>players.Id == id))
    .WithName(GetPlayerEndPointName);

//GET /players/europe
app.MapGet("players/birthplace/{birthPlace}",(string birthPlace) => players.FindAll(players =>players.BirthPlace == birthPlace));

//POST /players
app.MapPost("players",(CreatePlayerDto newPlayer)=>
{
    PlayerListDto player = new(
        players.Count + 1,
        newPlayer.Name,
        newPlayer.Age,
        newPlayer.BirthPlace
    );
    players.Add(player);

    return Results.CreatedAtRoute(GetPlayerEndPointName, new {id = player.Id},player);

}
);

app.Run();
