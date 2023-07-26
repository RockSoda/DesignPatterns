namespace CompositePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var toDoList = new Project("hello", new List<IToDoList> { new Project("world", new List<IToDoList> { new ToDo("!") }), new ToDo("HA")});
            Console.WriteLine(toDoList.GetHTML());
        }
    }
}