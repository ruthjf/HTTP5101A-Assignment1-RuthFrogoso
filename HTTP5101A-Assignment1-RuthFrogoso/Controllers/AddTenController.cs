using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101A_Assignment1_RuthFrogoso.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Inputs an integer and returns 10 more than the integer
        /// </summary>
        /// <param name="id">Input integer</param>
        /// <returns>Integer with 10 added</returns>
        /// <example>
        /// GET api/AddTen/5 -> 15
        /// </example>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
