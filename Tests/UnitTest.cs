using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList;

namespace Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TodoList_IsEmptyWhenAllocated()
        {
            bool expected = true;
            bool result;

            TodoList td = new TodoList();
            result = td.IsEmpty;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TodoList_IsEmptyWhenElementHasAdded()
        {
            bool expected = false;
            bool result;

            TodoList td = new TodoList();
            td.Push("������� ����");
            result = td.IsEmpty;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TodoList_IsEmptyWhen1PushAnd1Pop()
        {
            bool expected = true;
            bool result;

            TodoList td = new TodoList();
            td.Push("������� ����");
            td.Pop();
            result = td.IsEmpty;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TodoList_CountWhenAllocated()
        {
            int expected = 0;
            int result;

            TodoList td = new TodoList();
            result = td.Count;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TodoList_CountWhenElementHasAdded()
        {
            int expected = 1;
            int result;

            TodoList td = new TodoList();
            result = td.Push("����� �����, ���� ������ ����").Count;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TodoList_CountWhen1PushAnd1Pop()
        {
            int expected = 0;
            int result;

            TodoList td = new TodoList();
            td.Push("������� ����").Pop();
            result = td.Count;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TodoList_CountWhen2Push()
        {
            int expected = 2;
            int result;

            TodoList td = new TodoList();
            result = td.Push("������� ����").Push("������� � ���").Count;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TodoList_IsEmptyWhen2Push()
        {
            bool expected = false;
            bool result;

            TodoList td = new TodoList();
            result = td.Push("������� ����").Push("������� � ���").IsEmpty;

            Assert.AreEqual(expected, result);
        }
        
        [TestMethod]
        public void TodoList_IsEmptyWhen2Push1Pop()
        {
            bool expected = false;
            bool result;

            TodoList td = new TodoList();
            td.Push("������� ����").Push("������� � ���").Pop();
            result = td.IsEmpty;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TodoList_CountWhen2Push1Pop()
        {
            int expected = 1;
            int result;

            TodoList td = new TodoList();
            td.Push("������� ����").Push("������� � ���").Pop();
            result = td.Count;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TodoList_CountWhen2Pop()
        {
            int expected = 0;
            int result;

            TodoList td = new TodoList();
            td.Pop();
            td.Pop();
            result = td.Count;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TodoList_IsEmptyWhen2Pop()
        {
            bool expected = true;
            bool result;

            TodoList td = new TodoList();
            td.Pop();
            td.Pop();
            result = td.IsEmpty;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TodoList_Get1st()
        {
            string expected = "������� ���� ����� 4";
            string result;

            TodoList td = new TodoList();
            result = td.Push(expected).Get(0);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TodoList_Get2nd()
        {
            string expected = "������� ���� ����� 5";
            string result;

            TodoList td = new TodoList();
            result = td.Push("������� ���������� ����")
                       .Push(expected)
                       .Get(1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TodoList_2PushGet1st()
        {
            string expected = "������� ���� ����� 5";
            string result;

            TodoList td = new TodoList();
            td.Push(expected);
            td.Push("������� ���������� ����");
            result = td.Get(0);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TodoList_3PushGet3rd()
        {
            string expected = "������� ���� ����� 5";
            string result;

            TodoList td = new TodoList();
            td.Push("���������� ������ 12:00");
            td.Push("������� ���������� ����");
            td.Push(expected);
            result = td.Get(2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TodoList_3PushGet2nd()
        {
            string expected = "������� ���� ����� 5";
            string result;

            TodoList td = new TodoList();
            td.Push("���������� ������ 12:00");
            td.Push(expected);
            td.Push("������� ���������� ����");
            result = td.Get(1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TodoList_3PushGet1st()
        {
            string expected = "������� ���� ����� 5";
            string result;

            TodoList td = new TodoList();
            td.Push(expected);
            td.Push("���������� ������ 12:00");
            td.Push("������� ���������� ����");
            result = td.Get(0);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TodoList_GetAllTasks()
        {
            int expected = 3;
            int result;

            TodoList td = new TodoList();
            td.Push("������� ���� ����� 5");
            td.Push("���������� ������ 12:00");
            td.Push("������� ���������� ����");

            result = td.GetAllTasks().Count;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TodoList_MarkTaskAreDone()
        {
            string expected = "������� ���������� ����";
            string result;

            TodoList td = new TodoList();
            td.Push(expected);
            td.Push("���������� ������ 12:00");
            td.Push(expected);
            td.DoneTask(1);

            result = td.Get(1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TodoList_CountDuplicate()
        {
            int expected = 2;
            int result;

            string tmp = "������� ���������� ����";

            TodoList td = new TodoList();
            td.Push(tmp);
            td.Push("���������� ������ 12:00");
            td.Push(tmp);
            td.DoneTask(1);

            result = td.Duplicate(tmp);

            Assert.AreEqual(expected, result);
        }
    }
}