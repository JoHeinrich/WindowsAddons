using Microsoft.VisualStudio.TestTools.UnitTesting;
using VoiceControl;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AdvancedTextController controller = new AdvancedTextController();
            var querry = controller.SearchOnYoutubeQuerry("test");
            Assert.AreEqual("https://www.youtube.com/results?search_query=test", querry);
        }
    }
}
