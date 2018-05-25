using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignedPattern.Singleton
{
    /// <summary>
    /// 懒汉模式-也称饱汉模式
    /// </summary>
    public class LazySingleton : IShowHashCode
    {
        private static LazySingleton _instance = null;
        private static object atom = new object();
        private LazySingleton()
        {
            Console.WriteLine("LazySingleton");
        }

        /// <summary>
        /// 使用双重锁
        /// </summary>
        public static LazySingleton Current
        {
            get
            {
                if (_instance == null)
                {
                    lock (atom)
                    {
                        if (_instance == null)
                        {
                            _instance = new LazySingleton();
                        }
                    }
                }
                return _instance;
            }
        }

        public void PrintHashCode()
        {
            Console.WriteLine(this.GetHashCode().ToString());
        }
    }
}
