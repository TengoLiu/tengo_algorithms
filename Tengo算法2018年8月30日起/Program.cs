using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tengo算法2018年8月30日起 {
    class Program {

        static void Main(string[] args) {
            int[] arr = new int[100];
            for(int i = 0; i < 100; i++) {
                arr[i] = i;
            }
            int index = 二分查找.Search(arr, 199);
            Console.WriteLine("查到元素所在位置为：" + index);
            Console.ReadKey();
        }
    }
}
