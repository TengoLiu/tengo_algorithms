using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tengo算法2018年8月30日起 {
    class Program {

        static void Main(string[] args) {

            #region 二分查找
            int[] arr = new int[100];
            for(int i = 0; i < 100; i++) {
                arr[i] = i;
            }
            int index = 二分查找.Search(arr, 199);
            Console.WriteLine("查到元素" + 199 + "所在位置为：" + index);

            index = 二分查找.SearchByRecusive(arr, 55, 0, arr.Length - 1);
            Console.WriteLine("查到元素" + 55 + "所在位置为：" + index);
            #endregion

            #region  选择排序
            Console.WriteLine("\n\n\n--------选择排序--------");
            选择排序 selectSort = new 选择排序();

            Console.WriteLine("排序前：");
            Utils.PrintArr(selectSort.arr);

            //执行选择排序
            selectSort.Sort();

            Console.WriteLine("\n排序后：");
            Utils.PrintArr(selectSort.arr);

            Console.WriteLine("\n\n重置数组：");
            selectSort.Reset();
            Utils.PrintArr(selectSort.arr);

            Console.WriteLine("\n使用递归方式排序后：");
            //执行基于递归实现的选择排序
            selectSort.SortByRecusive(selectSort.arr, 0);
            Utils.PrintArr(selectSort.arr);

            Console.WriteLine("\n--------选择排序--------");
            #endregion

            #region 快速排序
            Console.WriteLine("\n\n\n--------快速排序--------");
            快速排序 quickSort = new 快速排序();

            Console.WriteLine("排序前：");
            Utils.PrintArr(quickSort.arr);
            //执行快速排序
            quickSort.Sort(quickSort.arr, 0, quickSort.arr.Length - 1);
            Console.WriteLine("\n排序后：");
            Utils.PrintArr(quickSort.arr);
            Console.WriteLine("\n--------快速排序--------");
            #endregion

            #region 链表LinkList
            Console.WriteLine("\n\n\n--------链表LinkList--------");
            链表LinkList.Run();
            Console.WriteLine("--------链表LinkList--------");
            #endregion

            Console.ReadKey();
        }



    }
}
