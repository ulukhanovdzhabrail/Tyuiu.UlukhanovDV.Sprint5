using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.UlukhanovDV.Sprint5.Task6.V6.Lib
{
    public class DataService : ISprint5Task6V6
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;          
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        char c = line[i];
                        if ((c >= 'а' && c <= 'я') || c == 'ё')
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
