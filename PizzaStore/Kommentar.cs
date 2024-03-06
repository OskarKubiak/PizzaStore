using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Kommentar
    {
        public string _kommentar;
        public Kommentar(string kommentar) { 
        
            _kommentar = kommentar;
        
        }



        public string Kommentarer
        {
            get { return _kommentar; }

        }

        public override string ToString()
        {
            return $"Kommentar: {_kommentar}";
        }
    }
}
