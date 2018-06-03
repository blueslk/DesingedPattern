using DesignedPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignedPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TravelContext context = new TravelContext(Way.火车);
            context.Travel();
            Console.Read();
        }
    }
}
