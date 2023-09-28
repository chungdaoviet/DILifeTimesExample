namespace DILifeTimesExample.Services
{
    public class ScopedService : IScopedService
    {
        public string Time { get; set; }

        public ScopedService()
        {
            Time = DateTime.Now.Ticks.ToString();
        }
    }
}
