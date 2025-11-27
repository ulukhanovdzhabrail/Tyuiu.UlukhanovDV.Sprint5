using Tyuiu.UlukhanovDV.Sprint5.Task7.V4.Lib;
namespace Tyuiu.UlukhanovDV.Sprint5.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\djabr\AppData\Local\Temp\OutPutDataFileTask7V4.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
