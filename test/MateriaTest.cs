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
            // Materia TeoriaDeLaComputacion = new Materia(0, 1, 8);
            Assert.DoesNotThrow(
                () => {
                    
                    Materia TeoriaDelaComputacion = new Materia(8,9,10);
                    
                    Materia SistemasOperativos = new Materia(0,7,6);
                    
                    Materia Matematicas = new Materia(7,7,10);
                }
            );

            // Negativos, de 1 a 4 y mayor a 10
            Assert.Throws<ArgumentException>(
                () => {
                    Materia TeoriaDelaComputacion = new Materia(-7,7,9);
                    Materia SistemasOperativos = new Materia(-7,50,9);
                    Materia Matematicas = new Materia(0,7,11);
                    Materia Quimica = new Materia(0,2,9);
                }
            );
        }

        [Test, Description("Se calculan correctamente el promedio de los primeros dos parciales")]
        public void TestPromedioParciales()
        {         
            Materia TeoriaDelaComputacion = new Materia(8,9,10);
            Assert.That(TeoriaDelaComputacion.CalcularPromedioParciales(), Is.EqualTo(8.5f)); 

            Materia SistemasOperativos = new Materia(5,6,10);
            Assert.That(SistemasOperativos.CalcularPromedioParciales(), Is.EqualTo(5.5f));           
        }

        [Test, Description("Se calcula correctamente el promedio final")]
        public void TestPromedioFinal()
        {
            Materia TeoriaDelaComputacion = new Materia(8,9,10);
            Assert.That(TeoriaDelaComputacion.CalcularPromedioFinal(), Is.EqualTo(9)); 

            Materia SistemasOperativos = new Materia(5,6,10);
            Assert.That(SistemasOperativos.CalcularPromedioFinal(), Is.EqualTo(8));   
        }

        [Test, Description("Se indica correctamente cuado se requiere aplicar evaluación extraordinaria")]
        public void TestEvaluacionExtraordinaria()
        {
            Materia TeoriaDelaComputacion = new Materia(8,7,5);//Reprueba el ultimo parcial, no pasa
            Assert.That(TeoriaDelaComputacion.RevisarRequiereAplicarEvaluacionExtraordinaria(), Is.EqualTo(true)); 

            Materia SistemasOperativos = new Materia(5,6,10);//La suma del promedio de los dos parciales no es >= a 12, no pasa
            Assert.That(SistemasOperativos.RevisarRequiereAplicarEvaluacionExtraordinaria(), Is.EqualTo(true));

            Materia Matematicas = new Materia(10,0,10);//Tine un 0 en un parcial, no pasa
            Assert.That(Matematicas.RevisarRequiereAplicarEvaluacionExtraordinaria(), Is.EqualTo(true));
        }

    }
}