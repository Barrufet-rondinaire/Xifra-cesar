namespace Cesar;

class Program
{
    static void Main(string[] args)
    {
        using (var reader = new StreamReader("fitxer.txt"))
        {
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            };
        }
        
    }
}