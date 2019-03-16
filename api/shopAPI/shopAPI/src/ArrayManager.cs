using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shopAPI.src
{
    public class ArrayManager
    {
        public string[,] fillArray(string[,] products)
        {
            products[0, 0] = "AMD - Ryzen";
            products[0, 1] = "1199.00";
            products[1, 0] = "CORSAIR - Power Supply";
            products[1, 1] = "400";
            products[2, 0] = "CORSAIR - 16GB 2.4GHz DDR4 Desktop Memory";
            products[2, 1] = "400";
            products[3, 0] = "Intel - Core i7-8700K";
            products[3, 1] = "1000";
            products[4, 0] = "ASUS - ROG Motherboard with LED Lighting";
            products[4, 1] = "800";

            return products; 
        }

        public string[] sliceDimension(string[,] arrayToSlice, int dimension)
        {
            string[] result = new string[2];

            try
            {
                result[0] = arrayToSlice[dimension, 0];
                result[1] = arrayToSlice[dimension, 1];
            }
            catch(Exception e)
            {
                result[0] = e.ToString();
                result[1] = "note: id may be out of range";
            }


            return result;
        }
    }
}