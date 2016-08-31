using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorvSimpleConsole
{
    class funkcje 

    {
  
         public static int dod ( int x , int y )
         {
             return x + y ;
         }

        public static int ode (int x , int y )
         {
             return x - y;

         }

        public static int mno (int x , int y )
        {
            return x * y;

        }

        public static int dziel (int x , int y )
        {
            return x / y;

        }
        static void Main(string[] args)
        {
            int x = 0;
            int z, q = 0;
            int rez = 0;
          do
          {
              Console.WriteLine("Wybierz operacje którą chcesz wykonać ? ");
              Console.WriteLine("\n1)Dodawanie");
              Console.WriteLine("\n2)Odejmowanie");
              Console.WriteLine("\n3)Mnożenie");
              Console.WriteLine("\n4)Dzielenie");
              Console.WriteLine("\n5)Exit");
              Console.Write("\nOpcja = >   ");
             x = Convert.ToInt32(Console.ReadLine());

             switch(x){

           case 1:
                    Console.Clear();
                    Console.WriteLine("Proszę podać pierwszą liczbę => ");
                    z = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Proszę podać drugą liczbę => ");
                    q = Convert.ToInt32(Console.ReadLine());
                    rez = funkcje.dod(z, q);
                    Console.WriteLine("Wynik twojego działania to : " + rez);
                    Console.ReadLine();
                    Console.Clear();
                    break; 

             case 2:
                    Console.Clear();
                    Console.WriteLine("Proszę podać pierwszą liczbę => ");
                    z = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Proszę podać drugą liczbę => ");
                    q = Convert.ToInt32(Console.ReadLine());
                    rez = funkcje.ode(z, q);
                    Console.WriteLine("Wynik twojego działania to : " + rez);
                    Console.ReadLine();
                    Console.Clear();
                    break; 

                 case 3:
                    Console.Clear();
                    Console.WriteLine("Proszę podać pierwszą liczbę => ");
                    z = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Proszę podać drugą liczbę => ");
                    q = Convert.ToInt32(Console.ReadLine());
                    rez = funkcje.mno(z, q);
                    Console.WriteLine("Wynik twojego działania to : " + rez);
                    Console.ReadLine();
                    Console.Clear();
                    break; 
                 case 4:
                    Console.Clear();
                    Console.WriteLine("Proszę podać pierwszą liczbę => ");
                    z = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Proszę podać drugą liczbę => ");
                    q = Convert.ToInt32(Console.ReadLine());
                    rez = funkcje.dziel(z, q);
                    Console.WriteLine("Wynik twojego działania to : " + rez);
                    Console.ReadLine();
                    Console.Clear();
                    break; 

                 case 5:
                      Console.ForegroundColor = ConsoleColor.Red;
                      Console.WriteLine("\nZakończyłeś działanie programu ! Aby wyłączyć program naciśnij dowolny klawisz ! ");
                      Console.ReadKey();
                    x = 7;
                    break; 

                 default:
                      Console.ForegroundColor = ConsoleColor.Yellow;
                      Console.WriteLine("\nWybrano złą opcję ! Aby wrócić do menu naciśnij dowolny klawisz ! ");
                      Console.ReadKey();
                    break;
                   
          }
          } while (x != 7);
          Console.ForegroundColor = ConsoleColor.Green ;
          Console.WriteLine("\nWybrano złą opcję ! Aby wrócić do menu naciśnij dowolny klawisz ! ");
          Console.ReadKey();
          
        }
    }
}
