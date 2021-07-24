using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReadAndWriteIni
{
    class Program
    {
        static void Main(string[] args)
        {
            string Current;
            Current = Directory.GetCurrentDirectory();//获取当前根目录
            Console.WriteLine("Current directory {0}", Current);
            // 写入ini
            Ini ini = new Ini(Current + "/config.ini");
            ini.Write("Setting", "key1", "hello word!");
            ini.Write("Setting", "key2", "hello ini!");
            ini.Write("SettingImg", "Path", "IMG.Path");
            // 读取ini
            string stemp = ini.ReadValue("Setting", "key2");
            Console.WriteLine(stemp);

            Console.ReadKey();
        }
    }
}
