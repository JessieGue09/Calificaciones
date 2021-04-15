using System;
using System.Collections.Generic;

namespace Calificaciones
{
    class Parcial
    {
        // Public Criterio criterio;
        public List<Criterio> criterios = new List<Criterio>();

        // TODO: calcularlo

        public void AgregarCriterio(Criterio criterio)
        {
            this.criterios.Add(criterio);            
        }

        // Suma de criterios de 100%
        public bool ValidarSumaCriterios()
        {
            // TODO: Validad que la suma de criterios nos de 100%
            return true;
        }
        
        // Criterios distintos
        public bool ValidadCriteriosDistintos()
        {
            // TODO: Validar que todos los criterios tienen nombre distinto
            return true;
        }

        // Debe haber por lo menos un criterio
        public bool ValidarCriteriosDefinidos()
        {
            // TODO: Validar que por lo menos hay un criterio
            return true;
        }

        // Devuelve la calificacion de parcial
        public int CalcularCalificacion(List<float> calificacionesDeCadaCriterio)
        {
            return 10;
        }
    }
}