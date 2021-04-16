using System;

namespace Calificaciones
{
    class Materia
    {
       // Atributos - Caracteristicas, informacion
    
       public int primerParcial;
       public int segundoParcial;
       public int tercerParcial;

       public Materia(int primerParcial, int segundoParcial, int tercerParcial)
       {
           this.primerParcial = primerParcial;
           this.segundoParcial = segundoParcial;
           this.tercerParcial = tercerParcial;
       }

       // Metodos - acciones, para que sirve

       // Calcular:
       // - 2 parciales (Promedio parciales)
       // - semestral (Promedio final)

       public float CalcularPromedioParciales()
       {
           // TODO: Calcular el promedio entre los dos primeros parciales
           return 10f;
       }

       public float CalcularPromedioFinal()
       {
           // TODO: Calcular el promedio final
           return 10f;
       }

       public bool RevisarRequiereAplicarEvaluacionExtraudinaria()
       {
           // TODO: Revisar si se requiere aplicar una evaluacion extraudinaria
           return false;
       }
    }
}
