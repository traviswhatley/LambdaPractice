using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<string>() {"Basketball", "Baseball", "Tennis Raquet", "Running Shoes", "Wrestling Shoes", "Soccer Ball", "Football", "Shoulder Pads", 
                "Trail Running Shoes", "Cycling Shoes", "Kayak", "Kayak Paddles"};

            //declare a variable kayakProducts and set it equal to all products that contain the word "Kayak"
            var kayakProducts = products.Where(x => x.Contains("Kayak"));
            //print the kayakProducts to the console using a foreach loop.
            foreach (string a in kayakProducts)
            {
                Console.WriteLine(a);
            }
            //declare a variable shoeProducts and set it equal to all products that contain the word "Shoes"
            var shoeProducts = products.Where(x => x.Contains("Shoes"));
            //print the shoeProducts to the console using a foreach loop.
            foreach (var b in shoeProducts)
            {
                Console.WriteLine(b);
            }
            //declare a variable ballProducts and set it equal to all the products that have ball in the name.
            var ballProducts = products.Where(x => x.Contains("ball")).ToString();
            //print the ballProducts to the console using a foreach loop.
            foreach (var c in ballProducts)
            {
                Console.WriteLine(c);
            }
            //sort ballProducts alphabetically and print them to the console.
            ballProducts = ballProducts.OrderBy(x => x).ToList();
            //add six more items to the products list using .add().
            products.Add("Hockey Mask");
            products.Add("Hockey Stick");
            products.Add("Hockey Puck");
            products.Add("Hockey Net");
            products.Add("Hockey Gloves");
            porducts.Add("Hockey Pads");
            //print the product with the longest name to the console using the .First() extension.
            Console.WriteLine(products.OrderByDescending(x => x.Length).First());
            //print the product with the shortest name to the console using the .First() extension.
            Console.WriteLine(products.OrderBy(x => x.Length).First());
            //print the product with the 4th shortest name to the console using an index (you must convert the results to a list using .ToList()).
            products.OrderBy(x => x.Length).ToString();
            Console.WriteLine(products[3]);
            //print the ballProduct with the 2nd longest name to the console using an index(you must convert the results to a list using .ToList()).
            ballProducts.OrderByDescending(x => x.Length).ToString();
            Console.WriteLine(ballProducts[1]);
            //declare a variable reversedProducts and set it equal to all products ordered by the longest word first. (use the OrderByDecending() extension).
            var reversedProducts = products.OrderByDescending(x => x.Length);
            //print out the reversedProducts to the console using a foreach loop.
            foreach (var d in reversedProducts)
            {
                Console.WriteLine(reversedProducts);
            }
            //print out all the products ordered by the longest word first using the OrderByDecending() extension and a foreach loop.  
            //You will not use a variable to store your list
            foreach (var d in products)
            {
                Console.WriteLine(products.OrderByDescending(x => x.Length).First());
            }

            Console.ReadKey();
        }
    }
}
