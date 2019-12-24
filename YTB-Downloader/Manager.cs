using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace YTB_Downloader
{
    [Serializable]
    public class Manager
    {
        public string Directory;
    }
    public static class Methods
    {
        static string path = Path.GetPathRoot(Environment.SystemDirectory) + "YTB-Downloader";
        public static void Save()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(path + "\\data.bin", FileMode.Create))
            {
                bf.Serialize(fs, MainForm.Manager);
                fs.Flush();
            }
        }
        public static void Load()
        {
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                using (FileStream fsRead = new FileStream(path + "\\data.bin", FileMode.Open))
                {
                    MainForm.Manager = (Manager)bf.Deserialize(fsRead);
                }
            }
            catch
            {
                MainForm.Manager = new Manager();
            }
        }
    }
}
