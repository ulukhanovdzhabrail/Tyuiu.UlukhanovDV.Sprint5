using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.UlukhanovDV.Sprint5.Task3.V16.Lib
{
    public class DataService : ISprint5Task3V16
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutputFileTask3.bin" });
            double y = (2 * Math.Pow(x, 2) - 1)/ (Math.Sqrt(Math.Pow(x, 2)-2));
            y = Math.Round(y, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return path;
        }
    }
}
