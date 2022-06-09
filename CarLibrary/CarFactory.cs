/**************************************************************************
 *                                                                        *
 *  File:        CarFactory.cs                                            *
 *  Copyright:   (c) 2022, Iliescu Ștefan-Adrian                          *
 *  Description: Clasa ce construiește mașini pe baza unor informații     *
 *               date ca parametri.                                       *
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

namespace Auto_Configurator
{
    /// <summary>
    /// 
    /// </summary>
    public class CarFactory//clasa pentru sablonul Fabrica Simpla
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Car MakeCar(string brand, List<string> options)
        {
            if (brand.Equals("Audi"))
                return new Audi(options);
            else if (brand.Equals("Vw"))
                return new Volkswagen(options);
            else
            {
                throw new Exception("Brand non-existent!");//pentru messagebox
            }
        }
    }
}
