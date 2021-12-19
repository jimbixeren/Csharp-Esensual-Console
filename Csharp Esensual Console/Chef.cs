using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Esensual_Console
{
    internal class Chef
    {


        // metheths
       public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken");

        }

        public void MakeSalat()
        {
            Console.WriteLine("The Chef makes salad");

        }


        // public (virtual) 
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes bbq ribs");

        }

    }
}
