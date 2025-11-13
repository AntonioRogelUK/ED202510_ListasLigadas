namespace SimplementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            lista.Agregar("A");
            lista.Agregar("B");
            lista.Agregar("C");

            string datos = lista.ObtenerDatos();
            Console.WriteLine(datos);
            Console.WriteLine();

            lista.Eliminar("B");
            Console.WriteLine("Eliminando nodo B");
            datos = lista.ObtenerDatos();
            Console.WriteLine(datos);
        }
    }
}
