using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLi;
namespace u2_p2_topicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu usuario" );
            String user = Console.ReadLine();
            Console.WriteLine("Ingresa tu contraseña");
            String pas = Console.ReadLine();
            if (Class1.use(user).Equals(""))
            {
                if (Class1.pasw(pas).Equals(""))
                {
                    Console.WriteLine("Ingresando...");
                }
            }
            else
            {
                Console.WriteLine("Error \n");
            }
            Console.ReadKey();
        }
        
    }
}
