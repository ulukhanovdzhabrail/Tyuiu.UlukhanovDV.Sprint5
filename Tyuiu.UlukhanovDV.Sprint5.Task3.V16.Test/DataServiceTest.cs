using Tyuiu.UlukhanovDV.Sprint5.Task3.V16.Lib;
namespace Tyuiu.UlukhanovDV.Sprint5.Task3.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = @"C:\Users\djabr\AppData\Local\Temp\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(s);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
