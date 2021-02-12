using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101A_Assignment1_RuthFrogoso.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Inputs an integer and returns the square of the integer
        /// </summary>
        /// <param name="id">Input integer</param>
        /// <returns>The square of the integer</returns>
        /// <example>
        /// GET api/Square/2 -> 4
        /// </example>
        public int Get(int id)
        {
            return id * id;
        }
    }
}
