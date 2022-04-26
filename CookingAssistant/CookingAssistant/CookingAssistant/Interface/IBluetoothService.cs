using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CookingAssistant.Interface
{
   public interface IBluetoothService
    {
        string DeviceName();
        Task Send(string deviceName, string data);
    }
}
