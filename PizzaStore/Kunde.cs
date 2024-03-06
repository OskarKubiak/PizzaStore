using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    public class Kunde
    {
        #region Instance fields
        private string _navn;
        private string _adresse;
        private string _telefon;
        #endregion

        #region Constructor
        public Kunde (string name, string adresse, string telefon) {
            _navn = name;
            _adresse = adresse;
            _telefon = telefon;

            }
        #endregion


        #region Properties
        public string Name
        {
            get { return _navn; }
            
        }
        public string Adresse
        {
            get { return _adresse;}
        }

        public string Telefon
        {
            get { return _telefon; }
        }
        #endregion

        #region Methods


        public override string ToString()
        {
            return $"Navn: {Name} Adresse: {Adresse} Telefon nummer: {Telefon}  ";
        }
        #endregion
    }
}
