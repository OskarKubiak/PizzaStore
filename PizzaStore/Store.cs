using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Store
    {


        public void Start()
        {
            //kunder
            Kunde kundeA = new Kunde("Oskar", "Taastrup Murskeen 23", "59203460");
            Kunde kundeB = new Kunde("Max", "København gade 3","12345678");
            Kunde kundeC = new Kunde("Gabriel", "Ballerup nordgade 5", "44325112");

            //pizza
            Pizza pizza1 = new Pizza("Pepperoni", "extra ost");
            Pizza pizza2 = new Pizza("Kebab Pizza", "Ingen");
            Pizza pizza3 = new Pizza("Salat Pizza", "Chili");
            
            //kommentar
            Kommentar kmt = new Kommentar("lever til dette adresse: Vallensbæk, Firkløverparken 19, og jeg vil gerne se indhold af min pizza");

            //drikkevarer til order 1 (vælg selv)
            pizza1.Drikkevarer();

            //order 1
            Kvittering kvit = new Kvittering();
            Console.WriteLine(kundeA.ToString());
            Console.WriteLine(pizza1.ToString());
            Console.WriteLine(kmt.ToString()); //kommentar
            kvit.CalculateTotalPrice(110);
            Console.WriteLine(kvit.ToString());
            pizza1.Indhold(); //pizzaenes indhold
            Console.ReadKey();
            Console.Clear();

            //order 2
            Kvittering kvit1 = new Kvittering();
            Console.WriteLine(kundeB.ToString());
            Console.WriteLine(pizza2.ToString());
            kvit1.CalculateTotalPrice(80);
            Console.WriteLine(kvit1.ToString());
            Console.ReadKey();
            Console.Clear();

            //order 3
            Kvittering kvit2 = new Kvittering();
            Console.WriteLine(kundeC.ToString());
            Console.WriteLine(pizza3.ToString());
            kvit2.CalculateTotalPrice(100);
            Console.WriteLine(kvit2.ToString());
            Console.ReadKey();
            Console.Clear();
        }

        
    }
}
