using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5112_ASSIGNMENT_2.Controllers
{
    public class MenuController : ApiController
    {
        /// <summary>
        /// Calculates the total calories of meal
        /// </summary>
        /// <param name="burger"> Integer representing the index burger choice</param>
        /// <param name="drink"> Integer representing the index drink choice</param>
        /// <param name="side">Integer representing the index side choice</param>
        /// <param name="dessert">Integer representing the index dessert choice</param>
        /// <returns>The sum of calories of all food items</returns>
        
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string MealCalories(int burger, int drink, int side, int dessert)
        {
            int burgerCal = 0;
            int drinkCal = 0;
            int sideCal = 0;
            int dessertCal = 0;

            switch (burger)
            {
                case 1:
                    burgerCal = 461;
                    break;
                case 2:
                    burgerCal = 431;
                    break;
                case 3:
                    burgerCal = 420;
                    break;
                default:
                    break;
            }

            switch (drink)
            {
                case 1:
                    drinkCal = 130;
                    break;
                case 2:
                    drinkCal = 160;
                    break;
                case 3:
                    drinkCal = 118;
                    break;
                default:
                    break;
            }

            switch (side)
            {
                case 1:
                    sideCal = 100;
                    break;
                case 2:
                    sideCal = 57;
                    break;
                case 3:
                    sideCal = 70;
                    break;
                default:
                    break;
            }

            switch (dessert)
            {
                case 1:
                    dessertCal = 167;
                    break;
                case 2:
                    dessertCal = 266;
                    break;
                case 3:
                    dessertCal = 118;
                    break;
                default:
                    break;
            }

            int totalCalories = burgerCal + drinkCal + sideCal + dessertCal;

            return ($"Your total calorie count is {totalCalories}");
        }
    }
}

