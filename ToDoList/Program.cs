using System.IO;

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
        public bool IsEmpty { get; private set; }

        public TodoList() {}
        public string GetAllTasks()
        {
            return string.Empty;
        }
    }
}
