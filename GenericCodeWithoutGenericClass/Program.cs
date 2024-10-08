namespace GenericCodeWithoutGenericClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.Log<int>(1);
            logger.Log<string>("string nih");
            logger.Log<bool>(false);
            logger.Log<object>(new {Name = "Alif", Age = 21});
        }
    }
}
