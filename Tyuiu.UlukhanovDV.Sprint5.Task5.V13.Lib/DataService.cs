using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.UlukhanovDV.Sprint5.Task5.V13.Lib
{
    public class DataService : ISprint5Task5V13
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;           
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace(".", ",");
                    double[] a = line.Split(" ").Select(double.Parse).ToArray();
                    var f = a.Where(n => n >= -1.5 && n <= 1.5).ToArray();
                    res = f.Sum()/f.Length;
                    
                }
            }
            return Math.Round(res, 3);
        }

    }
}
