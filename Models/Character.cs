namespace dotnet_game.Models
{
    public class Character
    {
        public int Id { get; set;}
        public string? Name { get; set;}
        public int Hitpoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.king;
    }
}