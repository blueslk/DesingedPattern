using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignedPattern.Singleton
{
    /// <summary>
    /// 饿汉模式
    /// </summary>
    public class HungrySingleton : IShowHashCode
    {
        public static HungrySingleton Current = new HungrySingleton();
        private HungrySingleton()
        {
            Console.WriteLine("HungrySingleton");
        }

        public void PrintHashCode()
        {
            Console.WriteLine(this.GetHashCode().ToString());
        }
    }
}
