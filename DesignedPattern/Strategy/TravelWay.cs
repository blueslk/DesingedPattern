using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignedPattern.Strategy
{
    /// <summary>
    /// the way of traveling
    /// </summary>
   public abstract class TravelWay
    {
        protected string wayName;

        public abstract void Travel();
    }

    public enum Way
    {
        自行车 = 0,
        火车 = 2
    }

    public class Bicycle : TravelWay
    {
        public Bicycle()
        {
            this.wayName = Way.自行车.ToString();
        }

        public override void Travel()
        {
            Console.WriteLine(string.Format("骑{0}出行环游东湖一圈",this.wayName));
        }
    }

    public class Train : TravelWay
    {
        public Train()
        {
            this.wayName = Way.火车.ToString();
        }

        public override void Travel()
        {
            Console.WriteLine(string.Format("乘坐{0}出行前往丽江古城游玩!", this.wayName));
        }
    }
}
