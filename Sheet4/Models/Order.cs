using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sheet4.Models
{
    public class Order
    {
        public MealDeal mealDeal { get; set; } 
        public SubTypes SubTypes { get; set; }
        public SubSizes SubSizes { get; set; }
      
    }

    public enum SubTypes
    {
        TheMichaelJackson,
        ThePrince,
        TheBackstreetBoys,
        TheBeyonce
    }
    public enum SubSizes
    {
        TheOneHitWonder,
        AList,
        BList,
        Superstar
    }
    public enum MealDeal
    {
        None,
        DrinkAndCookie,
        DrinkAndChips
    }
}