using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignedPattern.Factory
{
    /// <summary>
    /// 汽车抽象类
    /// </summary>
    public abstract class AbstractCar
    {
        /// <summary>
        /// 汽车名称
        /// </summary>
        protected string Name;

        /// <summary>
        /// 老司机开车
        /// </summary>
        public abstract void Drive();
    }
}
