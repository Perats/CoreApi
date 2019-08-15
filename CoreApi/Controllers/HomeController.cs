using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CoreApi.Models;
using System;
using Infrastructure.Interface.Interfaces;
using Infrastructure.Interface.Models;
using CoreApi.Filters;

namespace CoreApi.Controllers
{
    public class HomeController : ControllerBase
    {
       
        public readonly IUserRepository _userService;

        public HomeController(IUserRepository userService)
        {
            _userService = userService;
        }

        [HttpGet, Route("")]
        public List<UserModel> GetUsers()
        {
            var users = _userService.GetUsers();
            var res = new List<UserModel>();
            foreach (var item in users)
            {
                res.Add(new UserModel
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    //Device = new DeviceModel
                    //{
                    //    Name = item.Device.Name,
                    //    Number = item.Device.Number,
                    //    Type = item.Device.Type,
                    //}
                });
            }
            return res;
        }

        [HttpGet, Route("devices/{id:int}")]
        public List<DeviceModel> GetDevices(int deviceid)
        {
            var device = _userService.GetDevices(deviceid);
            //if (device.Count == 0)
            //{
            //    throw new HttpException(404, "Not found");
            //}
            var result = new List<DeviceModel>();
            foreach (var item in device)
            {
                // result.Add(AutoMapper.Mapper.Map<DeviceDomain, DeviceViewModel>(item));
                //result.Add(new DeviceViewModel
                //{
                //    Name = item.Name,
                //    Number = item.Number,
                //    UserId = item.UserId,
                //    Type= item.Type
                //});
            }
            return result;
        }

        [HttpPost, Route("devices/")]
        //[ResponseType(typeof(DeviceModel))]
        public IActionResult AddDevice(DeviceModel data, int userId)
        {
            if (data != null)
            {
               // _userService.AddNewDevice(new DeviceModel { Name = data.Name, Number = data.Number, Type = data.Type, UserId = userId }, userId);
                return Ok();
            }
            return Ok();
        }

        [HttpDelete, Route("devices/")]
        //[ResponseType(typeof(DeviceModel))]
        [ActionName("Device")]
        public void Device_1(int deviceid, int userId)
        {
            _userService.DeleteDevice(deviceid, userId);
        }
    }

    //    public IActionResult Index()
    //    {
    //        return View();
    //    }

    //    public IActionResult Privacy()
    //    {
    //        return View();
    //    }

    //    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //    public IActionResult Error()
    //    {
    //        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    //    }
    //}
}
