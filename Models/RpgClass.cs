using System.Text.Json.Serialization;

namespace dotnet_game.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        king = 1,
        queen = 2,
        rook = 3,
        knight = 4,
        bishop = 5,
        pawn = 6
        
    }
}