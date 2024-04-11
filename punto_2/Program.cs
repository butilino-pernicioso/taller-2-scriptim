namespace punto_2
{
    internal class Program
    {
        
        public delegate void Cocinar (string c);

        static void Main(string[] args)
        {
            string alimento;
            string mensaje;

            Cocinar delegado ;


            delegado = Marinar;
            delegado += Cortar;
            delegado += Hervir;
            delegado += Saltear;
            delegado += Servir;


            Console.WriteLine("ingrese el alimento de va cortar, hervir, saltear");
            alimento=Console.ReadLine();


            delegado(alimento);


        }

        public static void Hervir (string c) 
        {

            Console.WriteLine(  c + " hervir");

           
        }

        public static void Saltear(string c)
        {

            Console.WriteLine(c + " saltear");


        }

        public static void Cortar(string c)
        {

            Console.WriteLine(c + " Cortar");


        }

        public static void Servir(string c)
        {

            Console.WriteLine(c + " servir");


        }

        public static void Marinar(string c)
        {

            Console.WriteLine(c + " marinar");


        }
        //public static string Saltear (string c)
        //{
        //    string ret;
        //    ret = c + " saltear";

        //    return ret;
        //}

   
    }
}