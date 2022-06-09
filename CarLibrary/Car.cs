/**************************************************************************
 *                                                                        *
 *  File:        Car.cs                                                   *
 *  Copyright:   (c) 2022, Iliescu Ștefan-Adrian                          *
 *  Description: Clasa de bază, cu un brand oarecare ce își poate genera  *
 *               un număr de ordin utilizând o listă de numere generate   *
 *               distincte.                                               *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Auto_Configurator
{
    /// <summary>
    /// Clasa de baza a masinilor
    /// </summary>
    public class Car
    {
        private static List<int> usedNumbers;//numere utilizate
        private List<string> _options;//proprietatile
        private string _brand; //marca masinii

        /// <summary>
        /// Getter pentru numele marcii
        /// </summary>
        /// <returns>Numele marcii</returns>
        public string Brand => _brand;
        private int orderNumber;//numar de ordin

        /// <summary>
        /// Constructorul pentru clasa de baza Car
        /// </summary>
        /// <param name="options"></param>
        public Car(List<string> options)
        {
            _options = options;
            usedNumbers = new List<int>(100);
        }

        /// <summary>
        /// Getterul pentru optiuni
        /// </summary>
        /// <returns>Optiunile masinii</returns>
        public List<string> GetOptions()
        {
            return _options;
        }

        /// <summary>
        /// Setterul pentru brandul masinii
        /// </summary>
        /// <param name="brand"></param>
        public void SetBrand(string brand)
        {
            _brand = brand;
        }


        /// <summary>
        /// Seteaza numarul de ordin
        /// </summary>
        public void SetOrderNumber()
        {
            int random = (int)(100 + new Random().NextDouble() * 900);//intre 100 si 999
            if (usedNumbers.Contains(random))//verificam daca se afla in lista de numere utilizate
            {
                if (usedNumbers.Count == 100)//maximul de comenzi
                    MessageBox.Show("S-a ajuns la un numar limitat de comenzi");
                SetOrderNumber();//apelam recursiv si poate primim numar care nu se afla in lista
            }
            else
            {
                orderNumber = random;
                usedNumbers.Add(random);//adaugam numarul nou in lista;
            }
        }


        /// <summary>
        /// Getterul pentru numarul de ordin
        /// </summary>
        /// <returns>Numarul de ordin</returns>
        public int GetOrderNumber()
        {
            return orderNumber;
        }
    }
}
