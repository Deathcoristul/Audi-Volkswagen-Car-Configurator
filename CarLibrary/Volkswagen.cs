/**************************************************************************
 *                                                                        *
 *  File:        Volkswagen.cs                                            *
 *  Copyright:   (c) 2022, Iliescu Ștefan-Adrian                          *
 *  Description: Clasa derivată din Car,Volkswagen ce își generează       *
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
    /// Clasa pentru masinile Volkswagen
    /// </summary>
    public class Volkswagen : Car
    {
        /// <summary>
        /// Contructorul pentru obiectele Volksvagen
        /// </summary>
        /// <param name="options"></param>
        public Volkswagen(List<string> options) : base(options)
        {
            SetBrand("Volkswagen");
            SetOrderNumber();
        }
    }
}
