using System;

namespace Calificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Parcial primerParcial = new Parcial();
            primerParcial.AgregarCriterio(new Criterio("Trabajo en clase", 0.25f));
            primerParcial.AgregarCriterio(new Criterio("Prácticas", 0.25f));
            primerParcial.AgregarCriterio(new Criterio("Participación/Esfuerzo", 0.1f));
            primerParcial.AgregarCriterio(new Criterio("Proyecto", 0.4f));
            primerParcial.AgregarCriterio(new Criterio("", -0.5f));
            // % permitidos? 0 al 100
            // 1 al 100
            // > 0, <= 100
        }
    }
}
