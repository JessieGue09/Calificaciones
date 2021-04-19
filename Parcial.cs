using System;
using System.Collections.Generic;
using System.Linq;

namespace Calificaciones
{
    class Parcial
    {
        public List<Criterio> criterios = new List<Criterio>();

        public void AgregarCriterio(Criterio criterio)
        {
            this.criterios.Add(criterio);
        }

        // Suma de criterios de 100%
        public bool ValidarSumaCriterios(float porcentaje)
        {
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

            }

        }
      
        public bool ValidarCriteriosDistintos()
        {
    
            var hashset = new HashSet<string>(); // para determinar si ya habíamos visto este criterio
            var duplicates = new HashSet<string>(); // contendrá los criterios que están duplicados
            var count = 0;
            foreach (var criterio in criterios)
            {
                if (!hashset.Add(criterio.nombre))
                {
                    count++;

                    if (duplicates.Add(criterio.nombre))
                    {

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

            // var esDiferente = new bool();
            // esDiferente = true;
            // for(int i = 0; i < criterios.Count; i++){
            //     for(int j = 0; j < criterios.Count; j++){
            //         if(criterios[i].nombre.Equals(criterios[j].nombre) && i != j){
            //             esDiferente = false;
            //         }else if(!criterios[i].nombre.Equals(criterios[j].nombre) && i != j && esDiferente == true){
            //             esDiferente = true;
            //         }
            //     }
            // }
            //return esDiferente;
        }


        public bool ValidarCriteriosDefinidos()
        {

            int total = 0;
            foreach (Criterio criterio in criterios)
            {
                total = criterios.Count;
            }

            if (total != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
       
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

        }
    }
}