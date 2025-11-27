using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.UlukhanovDV.Sprint5.Task7.V4.Lib
{
    public class DataService : ISprint5Task7V4
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V4.txt" });
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileInfo.Exists)
            {
                File.Delete(pathSaveFile);
            }
            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string str = "";
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] >= 'а' && line[i] <= 'я') || line[i] == 'ё' || (line[i] >= 'А' && line[i] <= 'Я') || line[i] == 'Ё')
                        {
                            str = str + "#";
                        }
                        else
                        {
                            str = str + line[i];
                        }                       
                    }
                    strLine += str;
                    File.AppendAllText(pathSaveFile, strLine);                   
                }
            }
            return strLine;
        }
    }
}
