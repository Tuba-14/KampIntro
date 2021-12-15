using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> İsimler = new MyList<string>();
            İsimler.Add("Tuba");
            Console.WriteLine("Hello World!");
        }
    }
}
