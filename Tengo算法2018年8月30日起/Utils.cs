using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tengo算法2018年8月30日起 {

    /// <summary>
    /// 小小的工具类
    /// </summary>
    public class Utils {

        /// <summary>
        /// 遍历打印数组
        /// </summary>
        /// <param name="array"></param>
        public static void PrintArr(int[] array) {
            foreach (var item in array) {
                Console.Write(item + "，");
            }
        }
    }
}
