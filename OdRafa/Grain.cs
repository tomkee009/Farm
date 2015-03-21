using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Farm
{
    class Grain:Plant,IBarnValue//zboże
    {
        public Grain() { }
        public Grain(EnumGrainType aType, double aPrice)
        {
            _Type = aType;
            _Price = aPrice;
        }

        private EnumGrainType _Type = EnumGrainType.millet;

        public EnumGrainType Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
        private double _Price=99.99;


        public double GetTotalPrice(double Volume)
        {
            return _Price * Volume;
        }

        public override string ToString()
        {
            return string.Format("Price = {0}, Type={1}", _Price, _Type);
        }

    }
}
