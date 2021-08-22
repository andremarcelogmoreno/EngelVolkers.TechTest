using DeviceDetectorNET.Parser;
using EngelVolkers.Api.TechTest.BusinessLogicLayer.Interfaces;
using EngelVolkers.Api.TechTest.Models;

namespace EngelVolkers.Api.TechTest.BusinessLogicLayer
{
    public class DeviceInfoLogicLayer : IDeviceInfoLogicLayer
    {
        public DeviceInfoModel Get(string userAgent)
        {
            DeviceDetectorNET.DeviceDetector.SetVersionTruncation(VersionTruncation.VERSION_TRUNCATION_NONE);
            var deviceDetectorResult = DeviceDetectorNET.DeviceDetector.GetInfoFromUserAgent(userAgent);

            return new Models.DeviceInfoModel(deviceDetectorResult.Match.DeviceType, $"{deviceDetectorResult.Match.Os.Name} {deviceDetectorResult.Match.Os.Version} {deviceDetectorResult.Match.Os.Platform}");
        }
    }
}
