using System;
using NUnit.Framework;

namespace Calificaciones
{
    class CriterioTest
    {
        [Test, Description("El Criterio solamente admite porcentajes válidos")]
        public void TestCriterioPercentValid()
        {
            // > 0
            Assert.DoesNotThrow(
                () => {
                    // 1% should not throw (should work correctly)
                    Criterio c1 = new Criterio("c1", 0.01f);
                    // 5%
                    Criterio c2 = new Criterio("c1", 0.05f);
                    // 50%
                    Criterio c3 = new Criterio("c1", 0.50f);
                }
            );
                // <= 100
            Assert.DoesNotThrow(
                () => {
                    // 100% should not throw (should work correctly)
                    Criterio c1 = new Criterio("c1", 1.0f);
                    // 99%
                    Criterio c2 = new Criterio("c1", 0.99f);
                    // 70%
                    Criterio c3 = new Criterio("c1", 0.70f);
                }
            );

            // <= 0
            Assert.Throws<ArgumentException>(
                () => {
                    // 0%
                    Criterio c1 = new Criterio("c1", 0.0f);
                }
            );
            Assert.Throws<ArgumentException>(
                () => {      

                    // -1%
                    Criterio c2 = new Criterio("c1", -0.01f);
                }
            );
            Assert.Throws<ArgumentException>(
                () => {
                  
                    // -45%
                    Criterio c3 = new Criterio("c1", -0.45f);
                }
            );

            // > 100
            Assert.Throws<ArgumentException>(
                () => {
                    // 100.001%
                    Criterio c1 = new Criterio("c1", 1.0001f);
                }
            );
            Assert.Throws<ArgumentException>(
                () => {      

                    // 101%
                    Criterio c2 = new Criterio("c1", 1.01f);
                }
            );
            Assert.Throws<ArgumentException>(
                () => {
                  
                    // 120%
                    Criterio c3 = new Criterio("c1", 1.2f);
                }
            );

        }

        [Test, Description("El criterio solamente admine nombres validos.")]
        public void TestCriterioNameValid()
        {
            // Nombre vacio
            Assert.Throws<ArgumentException>(
                () => {
                  
                    // 120%
                    Criterio c1 = new Criterio("", 1.2f);
                }
            );

            // Sin nombre
            Assert.Throws<ArgumentException>(
                () => {
                  
                    // 120%
                    Criterio c1 = new Criterio(null, 1.2f);
                }
            );

            Assert.DoesNotThrow(
                () => {
                    Criterio c1 = new Criterio("C1", 0.25f);
                }
            );
        }
    }
}