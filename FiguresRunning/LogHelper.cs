using System.IO;

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
