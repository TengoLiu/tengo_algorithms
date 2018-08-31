using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tengo算法2018年8月30日起 {
    class Program {

        static int[] arr = new int[] { 7, 6, 1, 3, 5, 4, 2, 8, 9, 10 };

        static void Main(string[] args) {

            #region 二分查找
            //int[] arr = new int[100];
            //for (int i = 0; i < 100; i++) {
            //    arr[i] = i;
            //}
            //int index = 二分查找.Search(arr, 199);
            //Console.WriteLine("查到元素所在位置为：" + index);

            //int index = 二分查找.SearchByRecusive(arr, 55,0,arr.Length-1);
            //Console.WriteLine("查到元素所在位置为：" + index);
            #endregion

            #region 选择排序
            //选择排序.Sort(arr);
            选择排序.SortByRecusive(arr, 0);
            PrintArr(arr);


            #endregion

            Console.ReadKey();
        }

        public static void PrintArr(int[] array) {
            foreach (var item in array) {
                Console.Write(item + "，");
            }
        }

    }
}
