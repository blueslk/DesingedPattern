using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignedPattern.Factory
{
    /// <summary>
    /// 简单的汽车工厂
    /// </summary>
    public class CarFactory
    {
        /// <summary>
        /// 创建汽车的静态方法接口
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static AbstractCar CreateCar(string name)
        {
            switch (name.ToUpper())
            {
                case "BMW":
                    return new BMW();
                case "AUDI":
                    return new Audi();
                default:
                    return null;
            }
        }
    }
}
