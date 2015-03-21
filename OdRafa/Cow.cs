using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Farm
{
    class Cow:Animal
    {
        public EnumType Type { get; set; }
        public double MilkPerDay { get; set; }


    }
    class Pig : Animal
    {
        private double productivity = 0.7;
        public double MeatFromPig
        {
            get
            {
                return productivity * _Weight;

            }
        }


    }

    abstract class Animal 
    {
        public string Name { get; set; }
        protected DateTime _BirthDate;
        public DateTime BirthDate {
            get { return _BirthDate; }
            set{
                if (value<=DateTime.Today){
                    _BirthDate = value;
                }
            }
        }
        public EnumSex Sex { get; set; }
        public EnumRace Race { get; set; }
        protected double _Weight;
        public double Weight 
        {
            get { return _Weight; }
            set
            {
                if (value>0) {_Weight=value;}
            } 
        }
        public string ToString() {
            return Name;
        }
    }
}
