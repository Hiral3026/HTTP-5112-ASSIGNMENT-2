using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5112_ASSIGNMENT_2.Controllers
{
    public class DiceGameController : ApiController
    {
        /// <summary>
        /// Calculates the number of ways to roll two dice to get sum of 10
        /// </summary>
        /// <param name="m">Positive integer representing the number of sides on the first die</param>
        /// <param name="n">Positive integer representing the number of sides on the second die</param>
        /// <returns>The total number of ways to roll two dices to get the value of 10</returns>
        
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceOutcomes(int m, int n)
        {
            int count = 0;
            for (int a = 1; a <= m; a++)
            {
                for (int b = 1; b <= n; b++)
                {
                    if (a + b == 10)
                    {
                        count++;
                    }
                }
            }
            return ($"There are {count} total ways to get the sum 10.");
        }
    }
}
