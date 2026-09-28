class Program
{




    static void Main(string[] args)
    {
        
        Console.WriteLine("Liczba wprowadzonych argumentów: {0}", args.Length);
         for(int i = 0; i < args.Length; i++)
        {
            
            Console.WriteLine("Argument numer: {0}: {1}", i, args[i]);
            
        }

        Console.WriteLine("Dodawanie: {1}" + "{2}", args);
        Console.WriteLine(int.Parse(args[2]) + int.Parse(args[1]));








    }
}