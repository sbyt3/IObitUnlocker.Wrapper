using System;
using IObitUnlocker.Wrapper;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IObitControllerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IObitController.DriverStart();
            var file = Path.Combine(Directory.GetCurrentDirectory(), "Driver.sys");
            var ret = IObitController.UnlockFile(file, FileOperation.UnlockAndDelete);
            IObitController.DriverStop();
            Console.ReadKey();
        }
    }
   
}
