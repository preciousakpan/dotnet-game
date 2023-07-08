namespace dotnet_game;

public class WeatherForecast
{
        public WeatherForecast(DateOnly date, int temperatureC) 
        {
            this.Date = date;
                this.TemperatureC = temperatureC;
               
        }
            public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}
