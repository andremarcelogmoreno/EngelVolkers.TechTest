using EngelVolkers.Api.TechTest.BusinessLogicLayer.Interfaces;
using EngelVolkers.Api.TechTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace EngelVolkers.Api.TechTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeviceInfoController : ControllerBase
    {
        IDeviceInfoLogicLayer _deviceInfoLogicLayer;
        public DeviceInfoController(IDeviceInfoLogicLayer deviceInfoLogicLayer)
        {
            _deviceInfoLogicLayer = deviceInfoLogicLayer;
        }

        [HttpGet]
        public  DeviceInfoModel Get()
        {
            var userAgent = Request.Headers["User-Agent"];
            return _deviceInfoLogicLayer.Get(userAgent);
         }
    }
}
