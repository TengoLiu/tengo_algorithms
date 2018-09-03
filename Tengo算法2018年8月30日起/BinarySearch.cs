using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tengo算法2018年8月30日起 {

    /// <summary>
    /// 二分查找
    /// </summary>
    public class BinarySearch {

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

            while (true) {
                //在区间的上限和下限不等的的时候
                if (start != end) {
                    if (arr[mid] > value) {
                        Console.WriteLine("在区间[" + start + "，" + end + "]内找到第" + mid + "个元素的值为" + arr[mid] + ",大了..");

                        //把上界设置为中值-1
                        end = --mid;

                        //然后再取中值
                        mid = (start + end) / 2;
                    }
                    else if (arr[mid] < value) {
                        Console.WriteLine("在区间[" + start + "，" + end + "]内找到第" + mid + "个元素的值为" + arr[mid] + ",小了..");

                        //把上界设置为中值+1
                        start = ++mid;

                        //然后再取中值
                        mid = (start + end) / 2;
                    }
                    else {
                        Console.WriteLine("在区间[" + start + "，" + end + "]内找到第" + mid + "个元素的值为" + arr[mid] + ",对了！.");
                        index = mid;

                        //找到了就退出
                        break;
                    }
                }
                else {//如果区间的上限和下限相等了，那就找一下看看这个值是否相等，不等的话，就说明没这个值，等就直接取
                    if (arr[mid] == value) {
                        Console.WriteLine("在区间[" + start + "，" + end + "]内找到第" + mid + "个元素的值为" + arr[mid] + ",对了！.");
                        index = mid;
                    }
                    break;
                }
            }
            return index;
        }

        /// <summary>
        /// 通过递归的方法来二分查找值所在的位置
        /// </summary>
        /// <param name="arr">要查找的数组，必须有序！</param>
        /// <param name="value">要查找的值</param>
        /// <returns></returns>
        public static int SearchByRecusive(int[] arr, int value, int start, int end) {
            if (start == end) {
                if (arr[start] != value) {
                    return -1;
                }
                else {
                    return start;
                }
            }
            else {
                var mid = (start + end) / 2;
                if (arr[mid] > value) {//如果中值大于要查找的值的话，把前面的一段再执行当前的方法
                    return SearchByRecusive(arr, value, start, end - 1);
                }
                else if (arr[mid] < value) {
                    return SearchByRecusive(arr, value, start + 1, end);
                }
                else {
                    return mid;
                }
            }
        }
    }
}
