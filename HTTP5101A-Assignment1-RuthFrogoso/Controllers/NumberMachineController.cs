using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101A_Assignment1_RuthFrogoso.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Inputs an integer and returns the integer with four mathematical operations applied to it
        /// </summary>
        /// <param name="id">Input integer</param>
        /// <returns>An integer with four mathematical operations applied</returns>
        /// <example>
        /// GET api/NumberMachine/2 -> 15
        /// </example>
        public int Get(int id)
        {
            return (id+1)*(id+5-2);
        }
    }
}
