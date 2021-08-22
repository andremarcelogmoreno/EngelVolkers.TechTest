namespace EngelVolkers.Api.TechTest.Models
{
    public class DeviceInfoModel
    {
        public DeviceInfoModel(string type, string operatingSystem)
        {
            Type = type;
            OperatingSystem = operatingSystem;
        }

        public string Type { get; }
        public string OperatingSystem { get;  }
    }
}
