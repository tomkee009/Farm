using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Farm
{
    abstract class Plant
    {

        private double _Volume=0;
        public double Volume
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
        private double _Price = 1;
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
        //private enumPlantType _PlantType = enumPlantType.perennial;
        public enumPlantType PlantType{get;set;}
    }
}
