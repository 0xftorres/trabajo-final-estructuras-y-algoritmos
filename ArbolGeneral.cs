using System;
using System.Collections.Generic;

namespace tp1
{
    [Serializable]
    public class ArbolGeneral<T>
    {

        private T dato;
        private List<ArbolGeneral<T>> hijos = new List<ArbolGeneral<T>>();

        public ArbolGeneral(T dato)
        {
            this.dato = dato;
        }

        public T getDatoRaiz()
        {
            return this.dato;
        }

        public List<ArbolGeneral<T>> getHijos()
        {
            return hijos;
        }

        public void agregarHijo(ArbolGeneral<T> hijo)
        {
            this.getHijos().Add(hijo);
        }

        public void eliminarHijo(ArbolGeneral<T> hijo)
        {
            this.getHijos().Remove(hijo);
        }


        public bool esHoja()
        {
            return this.getHijos().Count == 0;
        }

        public String recorridoPorNiveles()
        {
            int nivel = 2;


            String txt = "Nivel 1: " + this.getDatoRaiz().ToString() + "\nNivel 2: ";

            Cola<ArbolGeneral<T>> cola = new Cola<ArbolGeneral<T>>();
            cola.encolar(this);
            cola.encolar(null); // marcador de fin de nivel

            // ejecuto mientras la cola no este vacia
            while (!cola.esVacia())
            {
                ArbolGeneral<T> aux = cola.desencolar();

                if (aux != null)
                {
                    // hay hijos por procesar
                    foreach (var hijo in aux.getHijos())
                    {
                        txt += hijo.getDatoRaiz().ToString() + ", ";

                        // agrego los hijos a la cola
                        cola.encolar(hijo);
                    }
                }
                else
                {
                    nivel = nivel + 1;
                    txt += string.Format("\nNivel {0}: ", nivel);
                    // fin de nivel (se encontró un null)
                    if (!cola.esVacia())
                    {
                        // si la cola no esta vacia, agrego otro null
                        // para marcar el fin del siguiente nivel.
                        // es importante porque sino se seguirían
                        // agregando nulls hasta el infinito.
                        cola.encolar(null);
                    }
                }

            }
            return txt;
        }

        public int altura()
        {
            return 0;
        }


        public int nivel(T dato)
        {
            return 0;
        }

    }
}
