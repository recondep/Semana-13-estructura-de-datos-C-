class Program
{
    // Definición del nodo del árbol
    class Nodo
    {
        public string Titulo;
        public Nodo Izquierda;
        public Nodo Derecha;

        public Nodo(string titulo)
        {
            Titulo = titulo;
            Izquierda = null;
            Derecha = null;
        }
    }

    // Definición del árbol binario de búsqueda
    class ArbolBinarioBusqueda
    {
        private Nodo Raiz;

        public ArbolBinarioBusqueda()
        {
            Raiz = null;
        }

        // Método para insertar un título en el árbol
        public void Insertar(string titulo)
        {
            Raiz = InsertarRec(Raiz, titulo);
        }

        private Nodo InsertarRec(Nodo nodo, string titulo)
        {
            if (nodo == null)
            {
                return new Nodo(titulo);
            }

            // Comparar títulos (ignorando mayúsculas y minúsculas)
            int comparacion = string.Compare(titulo, nodo.Titulo, StringComparison.OrdinalIgnoreCase);

            if (comparacion < 0)
            {
                nodo.Izquierda = InsertarRec(nodo.Izquierda, titulo);
            }
            else if (comparacion > 0)
            {
                nodo.Derecha = InsertarRec(nodo.Derecha, titulo);
            }

            return nodo;
        }

        // Método para buscar un título en el árbol
        public bool Buscar(string titulo)
        {
            return BuscarRec(Raiz, titulo);
        }

        private bool BuscarRec(Nodo nodo, string titulo)
        {
            if (nodo == null)
            {
                return false;
            }

            int comparacion = string.Compare(titulo, nodo.Titulo, StringComparison.OrdinalIgnoreCase);

            if (comparacion == 0)
            {
                return true;
            }
            else if (comparacion < 0)
            {
                return BuscarRec(nodo.Izquierda, titulo);
            }
            else
            {
                return BuscarRec(nodo.Derecha, titulo);
            }
        }
    }

    static void Main(string[] args)
    {
        // Información del estudiante
        Console.WriteLine("Universidad Estatal Amazónica");
        Console.WriteLine("Carrera Tecnologías de la Información");
        Console.WriteLine("Alumna: Rosa Elena Conde Paucar");
        Console.WriteLine("Paralelo: B");
        Console.WriteLine("------------------------------------");

        // Crear un árbol binario de búsqueda
        ArbolBinarioBusqueda arbolRevistas = new ArbolBinarioBusqueda();

        // Insertar 10 títulos en el árbol
        arbolRevistas.Insertar("Revista Tiempo");
        arbolRevistas.Insertar("Tecnología Hoy");
        arbolRevistas.Insertar("Nacional Geografía");
        arbolRevistas.Insertar("El Economista");
        arbolRevistas.Insertar("Naturaleza");
        arbolRevistas.Insertar("Divulgación Científica");
        arbolRevistas.Insertar("Mirada");
        arbolRevistas.Insertar("Descubre");
        arbolRevistas.Insertar("Nuevo Científico");
        arbolRevistas.Insertar("Revista Tecnológica");

        bool continuar = true;

        while (continuar)
        {
            // Mostrar menú
            Console.WriteLine("\n=== Sistema de Búsqueda de Revistas ===");
            Console.WriteLine("1. Buscar un título");
            Console.WriteLine("2. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese el título a buscar: ");
                    string tituloBuscado = Console.ReadLine();

                    // Búsqueda en el árbol
                    bool encontrado = arbolRevistas.Buscar(tituloBuscado);

                    // Mostrar resultado
                    if (encontrado)
                        Console.WriteLine("Resultado: Encontrado");
                    else
                        Console.WriteLine("Resultado: No encontrado");
                    break;

                case "2":
                    continuar = false;
                    Console.WriteLine("¡Gracias por usar el sistema!");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }
}
