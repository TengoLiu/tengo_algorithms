using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tengo算法2018年8月30日起 {
    /// <summary>
    /// 冒泡排序
    /// </summary>
    public class BubbleSort : AbsSort {
        public void Sort() {

            //外层循环用于对每一个位置寻找合适的数字
            for(int i = 0; i < arr.Length; i++) {

                //设置最小值的位置，开始默认为当前要查询的第一个位置
                var index = i;

                //从第i个元素开始找出应该放到第i个位置的数字
                for(int j = i; j < arr.Length; j++) {
                    //如果找到一个比基础值还小的数，那么指针指向该值
                    if(arr[j] < arr[index]) {
                        index = j;
                    }
                }
                //最后把刚才找到的最小值和第i个元素换位，这样就实现了一个数的归位
                var temp = arr[i];
                arr[i] = arr[index];
                arr[index] = temp;
            }
        }

        //递归实现
        public void SortByRecusive(int start) {
            //如果已经排到最后一个元素了的话，说明前面都归位了，这一个元素自然也归位了
            if(start >= arr.Length - 1) {
                return;
            }
            else {
                //设置最小值的位置，开始默认为当前要查询的第一个位置
                var index = start;

                //从第i个元素开始找出应该放到第i个位置的数字
                for(int j = start; j < arr.Length; j++) {
                    //如果找到一个比基础值还小的数，那么指针指向该值
                    if(arr[j] < arr[index]) {
                        index = j;
                    }
                }
                //最后把刚才找到的最小值和第i个元素换位，这样就实现了一个数的归位
                var temp = arr[start];
                arr[start] = arr[index];
                arr[index] = temp;

                //然后对n+1个元素进行归位操作
                SortByRecusive(start + 1);
            }
        }
    }
}
