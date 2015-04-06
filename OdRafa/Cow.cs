using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Farm
{
    [Serializable()] 
    public class Cow:Animal
    {
        public static double MeetPricePerKg;
        public static double MilkPricePerLiter;

        public EnumType Type { get; set; }
        public double MilkPerDay { get; set; }

        public double TotalMeetPrice
        { 
            get 
            {
                return productivity * _Weight * MeetPricePerKg;
            } 
        }
        public double MilkPricePerDay
        {
            get
            {
                return MilkPerDay*MilkPricePerLiter;
            }
        }
    }
    public class Pig : Animal
    {
        public double MeatFromPig
        {
            get
            {
                return productivity * _Weight;
            }
        }


    }

    public abstract class Animal 
    {
        protected static double productivity=0.8;
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
