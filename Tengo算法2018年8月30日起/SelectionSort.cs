using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tengo算法2018年8月30日起 {
    public class SelectionSort : AbsSort {

        /// <summary>
        /// 排序思想：
        /// 它的工作原理是每一次从待排序的数据元素中选出最小（或最大）的一个元素，存放在序列的起始位置，直到全部待排序的数据元素排完。
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public void Sort() {
            for(int j = 0; j < arr.Length; j++) {
                /*
                 * 这里为什么让i=j，这是因为每次遍历完之后，
                 * 就确定了第j小的元素，那么无序的序列就从j+1开始了 
                 */
                for(int i = j; i < arr.Length; i++) {
                    //取无序列表里面的第一个元素做基数
                    int index = j;

                    //如果有比基数小的数
                    if(arr[index] > arr[i]) {
                        //把指针指向更小的这个值，注意，这里并不替换位置
                        index = i;
                    }

                    //把无序列表中开头的元素和index位置（最小）的元素换位
                    var temp = arr[j];
                    arr[j] = arr[index];
                    arr[index] = temp;
                }
            }
        }

        /// <summary>
        /// 通过递归进行选择排序排序
        /// </summary>
        /// <param name="arr">要排序的数组</param>
        /// <param name="start">开始的位置</param>
        public void SortByRecusive(int[] arr, int start) {
            if(start == arr.Length - 1) {
                //如果start已经是最后一个条件的话，退出咯
                return;
            }
            //先指向第一个元素
            var index = start;

            //从start开始，找一个最小的值
            for(int i = start; i < arr.Length; i++) {
                if(arr[i] < arr[index]) {
                    //指向新的最小数
                    index = i;
                }
            }
            //然后把第一个元素和最小的元素换位
            var temp = arr[start];
            arr[start] = arr[index];
            arr[index] = temp;
            //然后对start后面的数组继续排序
            SortByRecusive(arr, start + 1);

        }

    }
}
