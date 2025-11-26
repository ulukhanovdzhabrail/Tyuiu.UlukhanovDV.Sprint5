using System.IO;
using Tyuiu.UlukhanovDV.Sprint5.Task0.V24.Lib;
namespace Tyuiu.UlukhanovDV.Sprint5.Task0.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = @"C:\Users\djabr\AppData\Local\Temp\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(s);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
