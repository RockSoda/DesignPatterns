namespace TemplateMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var method = new ConcreteMethod();
            method.TemplateMethod();
        }
    }
}