using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace ListardDemo
{
   public class 
        Run
    {
        public void Rn()
        {
            Console.WriteLine("Starte Tests");
            try
            {
                TestAdd();
              //  TestInsertAt();
                Console.WriteLine("Test erfolgreich");
            }
            catch(Exception exc)
            {
                Console.WriteLine("Fehler: " + exc.Message);
            }
        }
        public void TestAdd()
        {
            Listard l = new Listard();
            if (l.Count != 0) throw new Exception("Liste nicht leer");

            l.Add(13);
            if (l.Count != 1)
            {
                throw new Exception("Fehler: TestAdd Error 0001");
            }

            if (l[0] != 13)
            {
                throw new Exception("TestAdd Error 0002");
            }

            l.Add(5);
            if (l.Count == 2)
            {
                throw new Exception("Fehler: TestAdd Error 0003");
            }
            if (l[1] != 5)
            {
                throw new Exception("Fehler: TestAdd Error 0004");
            }
        }

    }
}
