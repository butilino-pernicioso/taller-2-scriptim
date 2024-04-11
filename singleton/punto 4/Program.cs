namespace punto_4
{
    public class Singleton
    {
        private static Singleton instance;

        // Constructor privado para evitar la creación de instancias fuera de la clase
        private Singleton() { }

        // Método estático para obtener la única instancia de la clase
        public static Singleton GetInstance()
        {
            // Si la instancia aún no ha sido creada, la crea
            if (instance == null)
            {
                instance = new Singleton();
            }
            // Retorna la instancia existente
            return instance;
        }

        public void SomeMethod()
        {
            Console.WriteLine("Método de la instancia Singleton llamado");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Obtener la instancia del Singleton
            Singleton singletonInstance = Singleton.GetInstance();

            // Llamar a un método de la instancia Singleton
            singletonInstance.SomeMethod();

            // Intentar crear otra instancia del Singleton
            // Esto debería devolver la misma instancia que se creó anteriormente
            Singleton anotherInstance = Singleton.GetInstance();

            // Verificar si las dos instancias son iguales
            Console.WriteLine("¿Las dos instancias son iguales?: " + (singletonInstance == anotherInstance));
        }
    }

}