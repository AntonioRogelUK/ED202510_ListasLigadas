namespace SimplementeLigadas
{
    internal class Lista
    {
        private Nodo _nodoInicial;

        public Lista()
        {
            _nodoInicial = new Nodo();
        }

        public void Agregar(string valor)
        {
            //Llegar al final de la lista
            Nodo nodoActual = _nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
            }

            Nodo nuevoNodo = new Nodo(valor);
            nodoActual.Siguiente = nuevoNodo;
        }

        public string ObtenerDatos()
        {
            string datos = string.Empty;

            Nodo nodoActual = _nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                datos = datos + nodoActual.Valor + Environment.NewLine;
            }

            return datos;
        }

        public Nodo? Buscar(string dato)
        {
            Nodo nodoActual = _nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                if(nodoActual.Valor == dato)
                {
                    return nodoActual;
                }
            }
            return null;
        }
        private Nodo? BuscarAnterior(string dato)
        {
            Nodo nodoActual = _nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                if (nodoActual.Siguiente.Valor == dato)
                {
                    return nodoActual;
                }
                nodoActual = nodoActual.Siguiente;
            }
            return null;
        }

        public void Eliminar(string dato)
        {
            Nodo? nodoEncontrado = Buscar(dato);

            if (nodoEncontrado != null)
            {
                Nodo? nodoAnterior = BuscarAnterior(dato);
                
                nodoAnterior!.Siguiente = nodoEncontrado.Siguiente;
                nodoEncontrado.Siguiente = null;
            }
        }

    }
}

