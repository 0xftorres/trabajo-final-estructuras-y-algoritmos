
using System;
using System.Collections.Generic;
using tp1;

namespace tpfinal
{

	public class Estrategia
	{
		private int CalcularDistancia(string str1, string str2)
		{
			// using the method
			String[] strlist1 = str1.ToLower().Split(' ');
			String[] strlist2 = str2.ToLower().Split(' ');
			int distance = 1000;
			foreach (String s1 in strlist1)
			{
				foreach (String s2 in strlist2)
				{
					distance = Math.Min(distance, Utils.calculateLevenshteinDistance(s1, s2));
				}
			}

			return distance;
		}

		public String Consulta1(ArbolGeneral<DatoDistancia> arbol)
		{
			List<String> hojas = new List<String>();

			// si es hoja añado a la lista
			if (arbol.esHoja())
			{
				hojas.Add(arbol.getDatoRaiz().ToString());
			}

			// si no es hoja recorro los hijos
			else
			{
				foreach (var hijo in arbol.getHijos())
				{
                    String subHojas = "";

					// sigo con los hijos (esto porque no es hoja)
                    subHojas = Consulta1(hijo);

                    // agrego a la lista todas los textos de las hojas
					// ["txt1", "txt2", ...] + ["txt3, txt4, txt5", ...]
                    hojas.Add(subHojas);
				}
            }
			return String.Join("\n", hojas);
        }


		public String Consulta2(ArbolGeneral<DatoDistancia> arbol)
		{
			string result = "Implementar";

            return result;
        }

		

		public String Consulta3(ArbolGeneral<DatoDistancia> arbol)
		{
			string result = "Implementar";
		
			return result;
		}

		public void AgregarDato(ArbolGeneral<DatoDistancia> arbol, DatoDistancia dato)
		{
			// calculo distancia entre el texto de la raíz y del dato
			int distancia = CalcularDistancia(arbol.getDatoRaiz().texto, dato.texto);
			dato.distancia = distancia; // problema 1

			// verificar si hay hijos con esa distancia
			ArbolGeneral<DatoDistancia> encontrado = null;
            foreach (var hijo in arbol.getHijos())
            {
                if (hijo.getDatoRaiz().distancia == distancia) // problema 2
				{
					encontrado = hijo;
					// salgo del for each
					break;
				}
            }

			// agrego hijo o sigo bajando el arbol
			if (encontrado != null)
			{
				AgregarDato(encontrado, dato);
			}
			else
			{
				ArbolGeneral<DatoDistancia> nuevoSubarbol = new ArbolGeneral<DatoDistancia>(dato);
				arbol.agregarHijo(nuevoSubarbol);

            }


        }

		public void Buscar(ArbolGeneral<DatoDistancia> arbol, string elementoABuscar, int umbral, List<DatoDistancia> collected)
		{
            // calculo distancia entre el texto de la raíz y del dato
            int distancia = CalcularDistancia(arbol.getDatoRaiz().texto, elementoABuscar);

			// si es menor al umbral la distancia entonces hay coincidencia
			if (distancia <= umbral)
			{
				collected.Add(arbol.getDatoRaiz());
			}

			// recorro los hijos para encontrar mas coincidencias
			int limiteInferior = distancia - umbral;
			int limiteSuperior = distancia + umbral;
            foreach (var hijo in arbol.getHijos())
            {
				int distanciaHijo = hijo.getDatoRaiz().distancia;

				// si está dentro del umbral seguir buscando (para no tener que buscar el arbol completo))
                if (distanciaHijo >= limiteInferior && distanciaHijo <= limiteSuperior)
				{
					Buscar(hijo, elementoABuscar, umbral, collected);
				}
            }
        }
    }
}