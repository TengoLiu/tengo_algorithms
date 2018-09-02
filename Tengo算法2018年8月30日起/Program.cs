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

            //int index = 二分查找.SearchByRecusive(arr, 55, 0, arr.Length - 1);
            //Console.WriteLine("查到元素所在位置为：" + index);
            #endregion

            //选择排序
            Console.WriteLine("\n\n\n\n--------选择排序--------");
            选择排序 selectSort = new 选择排序();

            Console.WriteLine("\n排序前：");
            Utils.PrintArr(selectSort.arr);

            selectSort.Sort();

            Console.WriteLine("\n排序后：");
            Utils.PrintArr(selectSort.arr);

            Console.WriteLine("\n\n重置数组：");
            selectSort.Reset();
            Utils.PrintArr(selectSort.arr);

            Console.WriteLine("\n使用递归方式排序后：");
            selectSort.SortByRecusive(selectSort.arr, 0);
            Utils.PrintArr(selectSort.arr);

            Console.WriteLine("\n\n--------选择排序--------\n\n\n\n");


            链表LinkList.Run();

            Console.ReadKey();
        }



    }
}
