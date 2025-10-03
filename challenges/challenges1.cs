namespace itm.csharp.basic
{
    public class challenge1
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un numero:");
            int num = int.Parse(Console.ReadLine());
            if (num > 0) Console.WriteLine("Positivo");
            else if (num < 0) Console.WriteLine("Negativo");
            else Console.WriteLine("Es cero");
        }
    }

    
}