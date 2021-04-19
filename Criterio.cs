using System;

namespace Calificaciones
{
    class Criterio
    {
        public string nombre;

        public float porcentaje;

        public Criterio(string nombre, float porcentaje)
        {
            if (nombre == "" || nombre == null)
            {
                throw new ArgumentException("El nombre es requerido.");
            }
            this.nombre = nombre;

            if (!(porcentaje > 0f && porcentaje <= 1f))
            {
                throw new ArgumentException("El porcentaje debe ser mayor que 0 y menor o igual a 1");
            }
            this.porcentaje = porcentaje;
        }
    }
}

