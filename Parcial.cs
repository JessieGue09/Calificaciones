using System;
using System.Collections.Generic;
using System.Linq;

namespace Calificaciones
{
    class Parcial
    {

        // int NumeroTotalCriterios = 4;
        // Public Criterio criterio;
        public List<Criterio> criterios = new List<Criterio>();

        // TODO: calcularlo

        public void AgregarCriterio(Criterio criterio)
        {
            this.criterios.Add(criterio);
        }

        // Suma de criterios de 100%
        public bool ValidarSumaCriterios(float porcentaje)
        {
            // TODO: Validad que la suma de criterios nos de 100%
            //float SumaCriterios = porcentaje * NumeroTotalCriterios;

            float SumaCriterios = 0f;

            for (int i = 0; i < this.criterios.Count; i++)
            {
                SumaCriterios = SumaCriterios + this.criterios[i].porcentaje;

            }
            if (SumaCriterios == 1.0f)
            {
                return true;
            }
            else
            {
                return false;
                //throw new ArgumentException("La suma de los criterios debe dar el 100%.");
            }

        }

        // Criterios distintos
        public bool ValidarCriteriosDistintos(string nombre)
        {
            // TODO: Validar que todos los criterios tienen nombre distinto

            var hashset = new HashSet<string>(); // to determine if we already have seen this color
            var duplicates = new HashSet<string>(); // will contain the colors that are duplicates
            var count = 0;
            foreach (var criterio in criterios)
            {
                if (!hashset.Add(criterio.nombre))
                {
                    count++;

                    if (duplicates.Add(criterio.nombre))
                    {
                        //count++;
                    }

                }
            }
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            //var cDistinto = new bool();
            //List<string> nombreDupe = new List<string>();
            //for (int i = 0; i < criterios.Count; i++)
            //{
            //    nombreDupe.Add(criterios[i].nombre);
            //}
            //for (int i = 0; i < criterios.Count; i++)
            //{
            //    Console.WriteLine("nombreDupe["+i+"]: " + nombreDupe[i]);
            //    Console.WriteLine("criterios["+i+"]: " + criterios[i].nombre);
            //    for (int j = 0; j < criterios.Count; j++)
            //    {
            //        if (nombreDupe[i] == criterios[j].nombre)
            //        {
            //            if (i != j)
            //            {
            //                cDistinto = false;
            //            }
            //        }
            //        else
            //        {
            //            if (i != j)
            //            {
            //                cDistinto = true;
            //            }
            //        }
            //    }
            //}
            //
            //
            //if (cDistinto == true)
            //{
            //    return true;
            //}else return false;
        }

        // Debe haber por lo menos un criterio
        public bool ValidarCriteriosDefinidos()
        {
            // TODO: Validar que por lo menos hay un criterio
            int total = 0;
            foreach (Criterio criterio in criterios)
            {
                total = criterios.Count;
            }

            if(total != 0)
            {
                return true;
            } 
            else 
            {
                return false;
            }        
          
        }

        // Devuelve la calificacion de parcial
        public int CalcularCalificacion(List<float> calificacionesDeCadaCriterio)
        {
            float valorCalificacion = 0f;
            for (int i = 0; i < this.criterios.Count; i++)
            {
                // 0 + valor asignado al criterio * porcentaje del criterio
                valorCalificacion = valorCalificacion + (float)calificacionesDeCadaCriterio[i] * (float)criterios[i].porcentaje;
            }

            decimal result;
            result = Convert.ToDecimal(valorCalificacion);

            return (int)Decimal.Round(result);


            // return (int)valorCalificacion;
        }
    }
}