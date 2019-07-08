using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresRunning
{
    static public class LogHelper
    {

        public static void WriteLog(string message)
        {
            string path = Directory.GetCurrentDirectory() + "\\log.txt";

            using (StreamWriter streamWriter = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                streamWriter.WriteLine(message);
                streamWriter.Close();
            }
        }
    }
}
