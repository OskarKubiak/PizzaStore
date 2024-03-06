using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PizzaStore
{
    public class Kvittering
    {
        #region Instance fields
        private static int _id = 0;
        private double _pris;
        DateTime _dato;
        #endregion

        #region Constructor
        public Kvittering()
        {

            _id = _id + 1;
            _pris = 0;

        }

        #endregion 

        #region Properties

        public int ID
        {
            get { return _id; }

        }

        public double Pris
        {
            get { return _pris; } 
        }
        public DateTime Date { get => _dato; private set => _dato = value; }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"ID nummer: {ID}\nPris: {Pris}\nDato: {DateTime.Now.ToString("dd-MM-yy : kl: HH:mm:ss:fff")}";
        }
        public void CalculateTotalPrice(double pris)
        {

            _pris = pris * 1.25 + 40;
        }
        #endregion
    }
}
