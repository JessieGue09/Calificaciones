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

            if (!(primerParcial == 0 || primerParcial >= 5 && primerParcial <= 10))
            {
                throw new ArgumentException("La calificacion del primer parcial debe ser 0 o mayor o igual a 5 y menor o igual a 10");
            }

            if (!(segundoParcial == 0 || segundoParcial >= 5 && segundoParcial <= 10))
            {
                throw new ArgumentException("La calificacion del segundo parcial debe ser 0 o mayor o igual a 5 y menor o igual a 10");
            }

            if (!(tercerParcial == 0 || tercerParcial >= 5 && tercerParcial <= 10))
            {
                throw new ArgumentException("La calificacion del tercer parcial debe ser 0 o mayor o igual a 5 y menor o igual a 10");
            }

        }

        public float CalcularPromedioParciales()
        {

            float PromediParciales = ((float)primerParcial + (float)segundoParcial) / 2;
            return PromediParciales;
        }

        public float CalcularPromedioFinal()
        {

            float valorPromedioFinal = 0f;
            valorPromedioFinal = (CalcularPromedioParciales() + tercerParcial) / 2;

            decimal result;
            result = Convert.ToDecimal(valorPromedioFinal);

            return (int)Decimal.Round(result);

        }

        public bool RevisarRequiereAplicarEvaluacionExtraordinaria()
        {


            if (tercerParcial == 0 || primerParcial == 0 || segundoParcial == 0 || tercerParcial == 5)
            {
                return true;
            }
            else if (CalcularPromedioParciales() < 12)
            {
                return true;
            }
            else if (CalcularPromedioFinal() < 7)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
