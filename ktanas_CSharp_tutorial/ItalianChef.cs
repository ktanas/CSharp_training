using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktanas_CSharp_tutorial
{
    class ItalianChef : Chef
    {
        public void MakePizza()
        {
            Console.WriteLine("The Chef makes pizza");
        }
        public void MakeSpaghetti()
        {
            Console.WriteLine("The Chef makes spaghetti");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes tortellini");
        }

    }
}
