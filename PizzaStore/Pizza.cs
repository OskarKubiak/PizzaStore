using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    public class Pizza
    {
        #region Instance fields
        private string _pizzaNavn;
        private string _toppings;
        private string _drikkevarer;
        #endregion

        #region Constructor
        public Pizza(string pizzaNavn, string toppings)
        {
            _pizzaNavn = pizzaNavn;
            _toppings = toppings;
            
            
        }

        #endregion

        #region Properties


        public string PizzaNavn
        {
            get { return _pizzaNavn; }
        }

        public string Toppings
        {
            get { return _toppings; }
        }

        public string Drikkevar
        {
            get { return _drikkevarer; }
        }
        #endregion

        #region Methods
        /*
        public void MakePizza()
        {
            
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    _pizzaNavn = "Margherita";
                    
                    break;

                 case 2:
                    _pizzaNavn = "Kebab Pizza";
                    break;
                 
                 case 3:
                    _pizzaNavn = "Pepperoni pizza";
                        break;

                default:
                    Console.WriteLine("forkert nummer");
                    _pizzaNavn = "";
                    break;
            }
        }
        */

        public void Indhold()
        {
            if(PizzaNavn == "Pepperoni")
            {
                Console.WriteLine("indhold af " + PizzaNavn + " pizza: " + "Ost, Pepperoni");
            }

            if(Toppings == "ekstra ost")
            {
                Console.WriteLine("med extra ost");
            }

            //og så videre
        }
        public void Drikkevarer()
        {
            Console.WriteLine("Skriv en nummer for at vælge din drikkevar til din menu: (1 Pepsi), (2 fanta), (3 Sprite), (4 ingen)");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    _drikkevarer = "Pepsi";
                    break;
                case 2:
                    _drikkevarer = "Fanta";
                    break;
                case 3:
                    _drikkevarer = "Sprite";
                    break;
                default:
                    _drikkevarer = "ingen";
                    break;
            }
        }
        public override string ToString()
        {
            return $"Pizza: {PizzaNavn} \nToppings: {Toppings} \nDrikkevarer: {Drikkevar}";
        }
        #endregion
    }
}
