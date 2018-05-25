using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignedPattern.Factory
{
    /// <summary>
    /// BMW
    /// </summary>
    public class BMW : AbstractCar
    {
        public BMW()
        {
            this.Name = "宝马";
        }
        public override void Drive()
        {
            Console.WriteLine("老司机正在开{0}", this.Name);
        }
    }

    /// <summary>
    /// 奥迪
    /// </summary>
    public class Audi: AbstractCar
    {
        public Audi()
        {
            this.Name = "奥迪";
        }

        public override void Drive()
        {
            Console.WriteLine("老司机正在开{0}", this.Name);
        }
    }
}
