﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Practice
{
    internal class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes Chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes Salad");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes BBQ Ribs");
        }
    }
}
