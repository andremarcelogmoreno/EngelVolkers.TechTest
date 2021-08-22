using EngelVolkers.Api.TechTest.Models;
namespace EngelVolkers.Api.TechTest.BusinessLogicLayer.Interfaces
{
    public interface IDeviceInfoLogicLayer
    {
        DeviceInfoModel Get(string userAgent);
    }
}
