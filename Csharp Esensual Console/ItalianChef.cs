using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Esensual_Console
{

    // Inheritamce med : Chef, den aver fra Chef class alle metoderne
    internal class ItalianChef : Chef
    {


        public void MakePasta()
        {

            Console.WriteLine("The Chef make pasta");
        }
    }
}
