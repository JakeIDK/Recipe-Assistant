using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CookingAssistant.Droid;
using CookingAssistant.Interface;
using System.IO;
using Xamarin.Essentials;

[assembly: Xamarin.Forms.Dependency(typeof(FileService))]
namespace CookingAssistant.Droid
{
    public class FileService : IFileService
    {
        public string GetRootPath() {
            return Application.Context.GetExternalFilesDir(null).ToString();
                }
       public void CreateFile(string title,string data) {
            var filename =  title+".txt";
            var destination = Path.Combine(GetRootPath(), filename);
            File.WriteAllText(destination, data);
        }
    }
}