using System.IO;
using System.Xml.Schema;

namespace ToDoList
{
    class Program
    {

        static void Main(string[] args)
        {
        }
    }

    public class TodoList
    {
        public bool IsEmpty { get; private set; } = true;
        public int Count { get; private set; } = 0;

        private string[] buff = new string[2];

        public TodoList() {}
        public string GetAllTasks()
        {
            return string.Empty;
        }
        public TodoList Push(string text)
        {
            buff[Count] = text;
            Count += 1;
            IsEmpty = Count == 0;
            return this;
        }

        public string Pop()
        {
            Count = Count == 0? Count : Count - 1;
            IsEmpty = Count == 0;
            return buff[Count];
        }

        public string Get(int i) => buff[i];
    }
}
