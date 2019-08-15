using Infrastructure.Interface.Models;
using System;
using System.Collections.Generic;

namespace Infrastructure.Interface.Interfaces
{
    public interface IUserRepository//<T> : IDisposable where T : class
    {
        List<User> GetUsers();
        List<Device> GetDevices(int userId);
        void AddNewDevice(Device device, int userId);
        void DeleteDevice(int userId, int deviceId);
    }
}
