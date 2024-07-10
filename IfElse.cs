


/*   
 *   an if-else statement is used to execute code conditionally based on whether a specified condition is true or false.  
 *   */
using System;

class RestaurantOrdering
{
    static void Main(string[] args)
    {
        bool isVegetarian = false;
        bool isVegan = false;
        bool isGlutenFree = true;

        if (isVegetarian)
        {
            if (isVegan)
            {
                Console.WriteLine("Serve a vegan meal.");
            }
            else
            {
                Console.WriteLine("Serve a vegetarian meal.");
            }
        }
        else if (isGlutenFree)
        {
            Console.WriteLine("Serve a gluten-free meal.");
        }
        else
        {
            Console.WriteLine("Serve a regular meal.");
        }
    }
}
