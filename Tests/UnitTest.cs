using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList;

namespace Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Main_TypeSomeText()
        {
            string tmp = "some text";
            
            string result = _List.TypeText(tmp);

            Assert.AreEqual(result, tmp);
        }
    }
}