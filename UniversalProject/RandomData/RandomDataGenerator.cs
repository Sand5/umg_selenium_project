using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalProject.RandamDataGenerator
{
    public class RandomDataGenerator
    {
        
        public static string GetNumericRandomData(int count)
        {
            //Create a string varibale to store some data.
             String data = "12345679";
            
            //Create a string builder object passing in the count for the number of characters required
             StringBuilder sb = new StringBuilder(count);
           
            //Create a random object to use inside the for loop to get pull back random characters
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
             sb.Append(data.ElementAt(random.Next(data.Length)));
             }

            return sb.ToString();

        }

        public static string GetAlphaRandomData(int count)
        {
            //Create a string varibale to store some data.
            string data = "abcdfghijklmnopqrstuvwxyz";
            
            //Create a string builder object passing in the count for the number of characters required
            StringBuilder sb = new StringBuilder(count);
            
            //Create a random object to use inside the for loop to get pull back random characters
             Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                sb.Append(data.ElementAt(random.Next(data.Length)));

            }

            return sb.ToString();


        }
    }
}
