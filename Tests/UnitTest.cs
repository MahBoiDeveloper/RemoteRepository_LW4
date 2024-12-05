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
            td.Push("Сделать лабу");
            result = td.IsEmpty;

            Assert.AreEqual(result, tmp);
        }

        [TestMethod]
        public void TodoList_IsEmptyThen1PushAnd1Pop()
        {
            bool tmp = true;
            bool result;

            TodoList td = new TodoList();
            td.Push("Сделать лабу").Pop();
            result = td.IsEmpty;

            Assert.AreEqual(result, tmp);
        }

        [TestMethod]
        public void TodoList_CountThenAllocated()
        {
            int tmp = 0;
            int result;

            TodoList td = new TodoList();
            result = td.Count;

            Assert.AreEqual(result, tmp);
        }

        [TestMethod]
        public void TodoList_CountThenElementHasAdded()
        {
            int tmp = 1;
            int result;

            TodoList td = new TodoList();
            result = td.Push("Сроки горят, надо делать лабу").Count;

            Assert.AreEqual(result, tmp);
        }

    }
}