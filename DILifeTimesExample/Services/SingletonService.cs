namespace DILifeTimesExample.Services
{
    public class SingletonService : ISingletonService
    {
        public string Time { get; set; }

        public SingletonService() { 
            Time = DateTime.Now.Ticks.ToString();
        }
    }
}
