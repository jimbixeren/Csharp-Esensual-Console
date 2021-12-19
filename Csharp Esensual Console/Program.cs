// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Csharp_Esensual_Console /*MyApp*/ // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // laver en instens af bog med parameter
            Book book1 = new Book("Harry Potter", "JK Rowling", 400 );
            
            Book book2 = new Book("Lord Of the Rings", "Lord Of the Rings", 700);


            // her modifire jeg book2 title
            book2.title = "Hobbit";

            Player player1 = new Player("bent", 1, 44, 60);


            Student student1 = new Student("jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            // rating G, PG, PG-13, R, NR




            // objecks
            Chef chef = new Chef();
            chef.MakeChicken();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakePasta();






            Console.WriteLine(avengers.Rating);



            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());



            Console.WriteLine(book2.title);
            Console.WriteLine("Playres Name:" + " " + player1.name + "\nid:" + " " + player1.id + "\npoints:" + " " + player1.points + "\nstartpoints:" + " " + player1.startpoints);
            
            Console.ReadLine();
        }
    }
}


