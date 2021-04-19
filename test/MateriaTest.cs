using System;
using NUnit.Framework;

namespace Calificaciones
{
    [TestFixture]
    class MateriaTest
    {
        [Test, Description("Se validan correctamente las calificaciones de los parciales para crear una materia")]
        public void TestCalificacionesParciales()
        {
            // Numeros validos
            Assert.DoesNotThrow(
                () =>
                {

                    Materia TeoriaDelaComputacion = new Materia(8, 9, 10);

                    Materia SistemasOperativos = new Materia(0, 7, 6);

                    Materia Matematicas = new Materia(7, 7, 10);
                }
            );

            // Negativos, de 1 a 4 y mayor a 10
            Assert.Throws<ArgumentException>(
                () =>
                {
                    Materia TeoriaDelaComputacion = new Materia(-7, 7, 9);
                    Materia SistemasOperativos = new Materia(-7, 50, 9);
                    Materia Matematicas = new Materia(0, 7, 11);
                    Materia Quimica = new Materia(0, 2, 9);
                }
            );
        }

        [Test, Description("Se calculan correctamente el promedio de los primeros dos parciales")]
        public void TestPromedioParciales()
        {
            Materia TeoriaDelaComputacion = new Materia(8, 9, 10);
            Assert.That(TeoriaDelaComputacion.CalcularPromedioParciales(), Is.EqualTo(8.5f));

            Materia SistemasOperativos = new Materia(5, 6, 10);
            Assert.That(SistemasOperativos.CalcularPromedioParciales(), Is.EqualTo(5.5f));
        }

        [Test, Description("Se calcula correctamente el promedio final")]
        public void TestPromedioFinal()
        {
            Materia TeoriaDelaComputacion = new Materia(8, 9, 10);
            Assert.That(TeoriaDelaComputacion.CalcularPromedioFinal(), Is.EqualTo(9));

            Materia SistemasOperativos = new Materia(5, 6, 10);
            Assert.That(SistemasOperativos.CalcularPromedioFinal(), Is.EqualTo(8));
        }

        [Test, Description("Se indica correctamente cuado se requiere aplicar evaluación extraordinaria")]
        public void TestEvaluacionExtraordinaria()
        {
            //Reprueba el ultimo parcial, no pasa
            Materia TeoriaDelaComputacion = new Materia(8, 7, 5);
            Assert.That(TeoriaDelaComputacion.RevisarRequiereAplicarEvaluacionExtraordinaria(), Is.EqualTo(true));

            //La suma del promedio de los dos parciales no es >= a 12, no pasa
            Materia SistemasOperativos = new Materia(5, 6, 10);
            Assert.That(SistemasOperativos.RevisarRequiereAplicarEvaluacionExtraordinaria(), Is.EqualTo(true));

            //Tine un 0 en un parcial, no pasa
            Materia Matematicas = new Materia(10, 0, 10);
            Assert.That(Matematicas.RevisarRequiereAplicarEvaluacionExtraordinaria(), Is.EqualTo(true));
        }

    }
}