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

        [TestMethod]
        public void TodoList_IsEmptyThenElementHasAdded()
        {
            bool tmp = false;
            bool result;

            TodoList td = new TodoList();
            td.Push("������� ����");
            result = td.IsEmpty;

            Assert.AreEqual(result, tmp);
        }

        [TestMethod]
        public void TodoList_IsEmptyThen1PushAnd1Pop()
        {
            bool tmp = true;
            bool result;

            TodoList td = new TodoList();
            td.Push("������� ����").Pop();
            result = td.IsEmpty;

            Assert.AreEqual(result, tmp);
        }
    }
}