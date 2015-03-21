using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Farm
{
    class Barn//Stodoła
    {
        List<IBarnValue> mContent = new List<IBarnValue>();
        public void AddContent(IBarnValue cos)
        {
            mContent.Add(cos);
        }
        public double GetTotalValue()
        {
            double TotalValue=0;
            foreach (var el in mContent)
            {
                TotalValue += el.Price;
            }
            return 0;
        }

    }
}
