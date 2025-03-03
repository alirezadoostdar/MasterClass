using System.Reflection;

public class Program
{
    public static void Main(string[] args)
    {
        string path = Assembly.GetExecutingAssembly().Location;
    }
}
