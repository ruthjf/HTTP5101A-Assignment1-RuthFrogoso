using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101A_Assignment1_RuthFrogoso.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Returns a string
        /// </summary>
        /// <returns>"Hello World!"</returns>
        /// <example>
        /// POST api/Greeting -> "Hello World!"
        /// </example>
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// Inputs an integer and returns a string including that integer
        /// </summary>
        /// <param name="id">Input integer</param>
        /// <returns>A string with the integer id</returns>
        /// <example>
        /// GET api/Greeting/5 -> "Greetings to 5 people!"
        /// </example>
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}



