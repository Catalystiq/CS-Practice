using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Practice
{
    internal class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes Chicken Parm");
        }

        public void MakePasta()
        {
            Console.WriteLine("The Chef makes Pasta");
        }
    }
}
