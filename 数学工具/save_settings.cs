using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数学工具
{
    class save_settings
    {
        public static void do_save_settings(bool _1,bool _2,bool _3)
        {

            File.Delete(@"C:\Users\public\settings.txt");
            if (_1)
                File.AppendAllText(@"C:\Users\public\settings.txt", "true\n");
            else
                File.AppendAllText(@"C:\Users\public\settings.txt", "false\n");
            if (_2)
                File.AppendAllText(@"C:\Users\public\settings.txt", "true\n");
            else
                File.AppendAllText(@"C:\Users\public\settings.txt", "false\n");
            if (_3)
                File.AppendAllText(@"C:\Users\public\settings.txt", "true\n");
            else
                File.AppendAllText(@"C:\Users\public\settings.txt", "false\n");
        }
    }
}
