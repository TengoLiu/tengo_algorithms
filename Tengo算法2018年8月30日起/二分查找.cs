using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tengo算法2018年8月30日起 {
    public class 二分查找 {

        /// <summary>
        /// 使用二分查找查找数组中某个值所在的位置
        /// </summary>
        /// <param name="arr">要查找的数组，必须有序！</param>
        /// <param name="value">要查找的值</param>
        /// <returns>要查找的值在数组中的位置</returns>
        public static int Search(int[] arr, int value) {
            //要查找的元素所在的位置
            int index = -1;

            int start = 0;
            int end = arr.Length - 1;
            int mid = (end + start) / 2;

            while(true) {
                //在区间的上限和下限不等的的时候
                if(start != end) {
                    if(arr[mid] > value) {
                        Console.WriteLine("在区间[" + start + "，" + end + "]内找到第" + mid + "个元素的值为" + arr[mid] + ",大了..");
                        end = --mid;//把上界设置为中值-1
                        mid = (start + end) / 2;//然后再取中值
                    }
                    else if(arr[mid] < value) {
                        Console.WriteLine("在区间[" + start + "，" + end + "]内找到第" + mid + "个元素的值为" + arr[mid] + ",小了..");
                        start = ++mid;//把上界设置为中值+1
                        mid = (start + end) / 2;//然后再取中值
                    }
                    else {
                        Console.WriteLine("在区间[" + start + "，" + end + "]内找到第" + mid + "个元素的值为" + arr[mid] + ",对了！.");
                        index = mid;
                        break;//找到了就退出
                    }
                }
                else {//如果区间的上限和下限相等了，那就找一下看看这个值是否相等，不等的话，就说明没这个值，等就直接取
                    if(arr[mid] == value) {
                        Console.WriteLine("在区间[" + start + "，" + end + "]内找到第" + mid + "个元素的值为" + arr[mid] + ",对了！.");
                        index = mid;
                    }
                    break;
                }
            }
            return index;
        }
    }
}
