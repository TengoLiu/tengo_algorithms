﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tengo算法2018年8月30日起 {
    public class 选择排序 {

        /// <summary>
        /// 排序思想：
        /// 它的工作原理是每一次从待排序的数据元素中选出最小（或最大）的一个元素，存放在序列的起始位置，直到全部待排序的数据元素排完。
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static void Sort(int[] arr) {
            for (int j = 0; j < arr.Length; j++) {
                /*
                 * 这里为什么让i=j，这是因为每次遍历完之后，
                 * 就确定了第j小的元素，那么无序的序列就从j+1开始了 
                 */
                for (int i = j; i < arr.Length; i++) {
                    //取无需列表里面的第一个元素做基数
                    int index = j;

                    //如果有比基数小的数
                    if (arr[index] > arr[i]) {
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
    }
}
