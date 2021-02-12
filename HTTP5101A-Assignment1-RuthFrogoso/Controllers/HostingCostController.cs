using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101A_Assignment1_RuthFrogoso.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Inputs an integer that represents the number of days and returns three strings that describe the total hosting cost per fortnight
        /// </summary>
        /// <param name="id">Number of days</param>
        /// <returns>Three strings that describe the total hosting cost per fortnight</returns>
        /// <example>
        /// GET api/HostingCost/0 -> "1 fortnights at $5.50/FN = $5.50 CAD", "HST 13% = $0.72 CAD", "Total = $6.22 CAD"
        /// </example>
        public IEnumerable<string> Get(int id)
        {
            int numberOfDays = id; //represents user input number of days, 1FN = 14 days
            int oneFortnight = 14; // represents 1FN
            int twoFortnights = 28; //represents 2FN
            int threeFortnights = 42; //represents 3FN

            // this code will run if user input is less than 14 days
            if (numberOfDays < oneFortnight)
            {
                return new string[] { "1 fortnights at $5.50/FN = $5.50 CAD", "HST 13% = $0.72 CAD", "Total = $6.22 CAD" };
            }
            // this code will run if user input is equal to 14 days or greater, but less than 28 days
            else if ((numberOfDays >= oneFortnight) && (numberOfDays < twoFortnights))
            {
                return new string[] { "2 fortnights at $5.50/FN = $11.00 CAD", "HST 13% = $1.43 CAD", "Total = $12.43 CAD" };
            }
            // this code will run if user input is equal to 28 days or greater, but less than 42 days
            else if ((numberOfDays >= twoFortnights) && (numberOfDays < threeFortnights))
            {
                return new string[] { "3 fortnights at $5.50/FN = $16.50 CAD", "HST 13% = $2.14 CAD", "Total = $18.64 CAD" };
            }
            // this code will run if user input is equal to 42 days or greater
            else
            {
                return new string[] { "No Value Found", "", "" };
            }
        }
    }
}
