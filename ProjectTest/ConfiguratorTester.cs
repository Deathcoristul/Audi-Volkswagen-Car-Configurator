/**************************************************************************
 *                                                                        *
 *  File:        CarFactory.cs                                            *
 *  Copyright:   (c) 2022, Adrian Cristea                                 *
 *  Description: Clasa pentru testari                                     *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
using Auto_Configurator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectTest
{
    [TestClass]
    public class ConfiguratorTester
    {

        /// <summary>
        /// Metoda de testare a initierii optiunilor
        /// </summary>
        [TestMethod]
        public void CarOptionsTest()
        {
            CollectionAssert.AreEqual(new List<string> { "blue", "17" }, new Car(new List<string> { "blue", "17" }).GetOptions());
        }

        /// <summary>
        /// Metoda de testare pentru a verifica daca numarul de comanda este format doar din cifre
        /// </summary>
        [TestMethod]
        public void OnlyNumbersTest()
        {
            Assert.AreEqual(true, MainForm.OnlyNumbers("123"));
        }

        /// <summary>
        /// Metoda a doua de testare pentru a verifica daca numarul de comanda este format doar din cifre
        /// </summary>
        [TestMethod]
        public void onlyNumbersTest2()
        {
            Assert.AreEqual(false, MainForm.OnlyNumbers("1a3"));
        }

        /// <summary>
        /// Metoda de testare pentru crearea unui obiect de tip Car
        /// </summary>
        [TestMethod]
        public void MakeCarTest()
        {
            List<string> options = new List<string> { "blue", "17" };
            CarFactory cf = new CarFactory();
            Car c = new Audi(options);
            Assert.AreEqual(true, Compare(cf.MakeCar("Audi", options),c)); 
        }

        /// <summary>
        /// Metoda de testare pentru crearea unui obiect de tip Car
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void MakeCarTest2()
        {
            List<string> options = new List<string> { "blue", "17" };
            CarFactory cf = new CarFactory();
            _ = cf.MakeCar("Fiat", options);
        }

        /// <summary>
        /// Metoda de testare pentru generarea numerelor de comanda
        /// </summary>
        [TestMethod]
        public void RangeOrderNumber()
        {
            Car car = new Car(new List<string> { "blue", "17" });
            car.SetOrderNumber();
            Assert.AreEqual(true, Enumerable.Range(100,900).Contains(car.GetOrderNumber()));
        }

        /// <summary>
        /// Metoda de testare care compara crearea a doua obiecte
        /// </summary>
        /// <param name="car1">Obiect 1 tip Car</param>
        /// <param name="car2">Obiect 2 tip Car</param>
        /// <returns>Valoarea de adevar a operatiei de comparare</returns>
        public bool Compare(Car car1,Car car2)
        {
            return car1.Brand.Equals(car2.Brand) && car1.GetOptions().SequenceEqual(car2.GetOptions());
        }
    }
}
