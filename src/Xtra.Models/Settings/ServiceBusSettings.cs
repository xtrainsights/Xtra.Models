namespace Xtra.Models.Settings
{

    public class ServiceBusSettings
    {
        public ServiceBusPlatform Platform { get; set; }
        public string ConnectionString { get; set; }
        public string InputQueueName { get; set; }
        //public bool Disabled { get; set; }
    }

}
