namespace punto_2
{
    internal class Program
    {
        
        public delegate string Cocinar (string c);

        static void Main(string[] args)
        {
            string alimento;

            Cocinar delegado ;


            delegado = Cortar;
            delegado += Hervir;
            delegado += Saltear;
            

            Console.WriteLine("ingrese el alimento de va cortar, hervir, saltear");
            alimento=Console.ReadLine();

            delegado.Invoke(alimento);
            

        }

        public static string Hervir (string c) 
        {
            string ret;
            ret = c + " hervir";

            return  ret ;
        }

        public static string Saltear (string c)
        {
            string ret;
            ret = c + " saltear";

            return ret;
        }

        public static string Cortar (string c) 
        {
            string ret;
            ret = c + " cortar";

            return ret;
        }
    }
}