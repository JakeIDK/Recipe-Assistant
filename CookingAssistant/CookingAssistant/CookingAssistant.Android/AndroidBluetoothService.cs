using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Bluetooth;
using CookingAssistant.Droid;
using CookingAssistant.Interface;
using Java.Util;
[assembly: Xamarin.Forms.Dependency(typeof(AndroidBluetoothService))]

namespace CookingAssistant.Droid
{
   public class AndroidBluetoothService : IBluetoothService
    {
        BluetoothAdapter bluetoothAdapter = BluetoothAdapter.DefaultAdapter;
       
        public string DeviceName()
        {
            BluetoothAdapter myDevice =
                BluetoothAdapter.DefaultAdapter;
            return myDevice.Name;
        }
        public async Task Send(string deviceName, string data)
            {
            BluetoothDevice device = (from bd in bluetoothAdapter?.BondedDevices
                                     where bd?.Name == deviceName 
                                     select bd).FirstOrDefault();
            try
                {
                await Task.Delay(1000);
                BluetoothSocket bluetoothSocket = device?.
                        CreateRfcommSocketToServiceRecord(
                        UUID.FromString("00001101-0000-1000--0000-00805f9b34fb"));

                bluetoothSocket?.Connect();
                byte[] buffer = Encoding.UTF8.GetBytes(data);
                bluetoothSocket?.OutputStream.Write(buffer, 0, buffer.Length);
                bluetoothSocket?.Close();
                }
            catch(Exception exp)
                {
                System.Diagnostics.Debug.WriteLine(exp.Message);
                throw exp;
                }
            }
    }   
}