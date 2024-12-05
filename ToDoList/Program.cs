using System.Diagnostics;
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

        private List<string> buff = new List<string>();

        public TodoList() {}
        public string GetAllTasks()
        {
            return string.Empty;
        }
        public TodoList Push(string text)
        {
            buff.Add(text);
            Count += 1;
            IsEmpty = Count == 0;
            return this;
        }

        public string Pop()
        {
            Count = Count == 0 ? Count : Count - 1;
            IsEmpty = Count == 0;

            string tmp;

            if (Count != 0)
            {
                tmp = buff[Count - 1];
                buff.RemoveAt(Count - 1);
                return tmp;
            }

            return string.Empty;
        }

        public string Get(int i) => buff[i];
    }
}
