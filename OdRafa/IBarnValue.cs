using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Farm
{
    interface IBarnValue
    {
        double GetTotalPrice(double Volume);
        double Price { get; set; }
    }
}
