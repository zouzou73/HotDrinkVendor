using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotDrinkVendor.Models
{

    public class Eau : Ingredient
    {
        public double Price
        {
            get
            {
                return 0.2;
            }

        }
    }
    public class Cafe : Ingredient
    {
        public double Price
        {
            get
            {
                return 1;
            }
        }
    }
    public class Sucre : Ingredient
    {
        public double Price
        {
            get
            {
                return 0.1;
            }
        }
    }
    public class Creme : Ingredient
    {
        public double Price
        {
               get
               {
                  return 0.5;
               }
        }
    }

     public class The : Ingredient
     {
         public double Price
         {
              get
              {
               return 2;
              }
         }
     }
       public class Chocolat : Ingredient
       {
           public double Price
           {
              get
              {
              return 1;
              }
           }
       }
        public class Milk : Ingredient
        {
           public double Price
           {
             get
             {
              return 0.4;
             }
           }
        }

}
 
