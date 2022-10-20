namespace KursASP.NET_CoreREST_WebAPI
{
    public interface IWeatherForcastService
    {
        IEnumerable<WeatherForecast> Get();
    }
}