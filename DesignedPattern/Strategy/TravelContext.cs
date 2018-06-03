using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignedPattern.Strategy
{
    public class TravelContext
    {
        private TravelWay _way;
        public TravelContext(TravelWay way)
        {
            this._way = way;
        }

        public TravelContext(Way w)
        {
            switch (w)
            {
                case Way.自行车:
                    _way = new Bicycle();
                    break;
                case Way.火车:
                    _way = new Train();
                    break;
                default: break;
            }
        }

        public void Travel()
        {
            this._way.Travel();
        }
    }
}
