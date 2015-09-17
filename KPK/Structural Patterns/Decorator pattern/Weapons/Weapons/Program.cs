using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    class Program
    {
        static void Main(string[] args)
        {
            var pistol = new Pistol();
            var silence = new Silencer(pistol);
            Console.WriteLine(silence.Describe());

            var rifle = new Rifle();
            var sight = new Sight(rifle);
            Console.WriteLine(sight.Describe());
        }
    }
}
