using ClientRestSharp.Engine;

namespace ClientRestSharp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new Client("http://localhost:8050");
            System.Console.WriteLine(engine.Send());

            while (true) if (System.Console.ReadLine() == "q") return;

        }
    }
}
