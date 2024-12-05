using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList;

namespace Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TodoList_IsEmptyThenAllocated()
        {
            bool tmp = true;
            bool result;

            TodoList td = new TodoList();
            result = td.IsEmpty;

            Assert.AreEqual(result, tmp);
        }
    }
}