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
        public List<string> GetAllTasks()
        {
            return buff;
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
                tmp = buff[Count];
                buff.RemoveAt(Count);
                return tmp;
            }

            return string.Empty;
        }

        public void DoneTask(int i)
        {
            Count = Count == 0 ? Count : Count - 1;
            IsEmpty = Count == 0;

            if (Count != 0)
                buff.RemoveAt(i);
        }

        public int Duplicate(string text)
        {
            int counter = 0;
            foreach(var elem in buff)
                counter = elem == text ? counter + 1 : counter;

            return counter;
        }

        public int Dupe(int i)
        {
            buff.Add(buff[i]);
            Count++;
            return Count;
        }

        public string Get(int i) => buff[i];
    }
}
