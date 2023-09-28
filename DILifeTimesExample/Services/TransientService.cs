namespace DILifeTimesExample.Services
{
    public class TransientService : ITransientService
    {
        public string Time { get; set; }

        public TransientService()
        {
            Time = DateTime.Now.Ticks.ToString();
        }
    }
}
