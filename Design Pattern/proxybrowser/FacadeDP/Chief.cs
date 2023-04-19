using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FacadeDP
{
    public class Chief
    {
        AzerbaijaniMeal azerbaijaniMeal = new();
        IndianMeal indianMeal = new(); 
        ChineseMeal chineseMeal = new();
        public void Make()
        {
            azerbaijaniMeal.Cook();
            indianMeal.Cook();
            chineseMeal.Cook();
        }
    }
}
