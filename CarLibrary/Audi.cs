/**************************************************************************
 *                                                                        *
 *  File:        Audi.cs                                                  *
 *  Copyright:   (c) 2022, Iliescu Ștefan-Adrian                          *
 *  Description: Clasa derivată din Car,Audi ce își generează             *
 *               un număr de ordin la crearea obiectului.                 *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
using System.Collections.Generic;

namespace Auto_Configurator
{
    /// <summary>
    /// Clasa pentru brandul Audi
    /// </summary>
    public class Audi:Car
    {
        /// <summary>
        /// Contructorul pentru obiectele Audi
        /// </summary>
        /// <param name="options"></param>
        public Audi(List<string> options):base(options)
        {
            SetBrand("Audi");
            SetOrderNumber();
        }
    }
}
