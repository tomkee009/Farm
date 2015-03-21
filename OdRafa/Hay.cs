using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Farm
{
    class Hay:IBarnValue //siano
    {
        public Hay() { }
        public Hay(EnumHayColor aColor, double aPrice)
        {
            _Color = aColor;
            _Price = aPrice;
        }

        private EnumHayColor _Color = EnumHayColor.yellow;

        public EnumHayColor Color
        {
            get { return _Color; }
            set { _Color = value; }
        }
        private double _Price=199.99;

        public double Price
        {
            get { return _Price; }
            set
            {
                if (value >= 0)
                {
                    _Price = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public double GetTotalPrice(double Volume)
        {
            return _Price * Volume;
        }
        public override string ToString()
        {
            return string.Format("Price = {0}, Color={1}", _Price, _Color);
        }

    }
}
