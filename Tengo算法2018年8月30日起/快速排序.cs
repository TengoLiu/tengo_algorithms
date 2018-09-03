using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tengo算法2018年8月30日起 {
    public class 快速排序 :AbsSort{

        /// <summary>
        /// 快速排序
        /// 把数组第一个元素归位，然后再对这个元素的左边和右边部分执行同样的操作
        /// 采取分而治之的方式，直到所有子数组和子数组的子数组....的元素都归位
        /// 难点在于每次如何找到中轴的位置！
        /// 
        /// PS：如果选择最左边的数作为基数，那么就是右指针先出发，反之亦然。为什么呢？
        /// 因为啊，如果右指针先出发，那么最后一步必定会找到比基数小的数（右指针就是为了找比基数小的数的），然后只需要替换重合位置和基数即可
        /// 如果是左指针先出发，那么可以想一想，万一找到比基数小的数的时候重合了咋办？
        /// 难道把前面比如： 5 1 3 4 6 8 9 ，如果是左指针先出发，那么左指针会停在6的位置，右指针也会停在6的位置，重合了！
        /// 这个时候，你怎么把基数放到中间来呢？难道把前面比基数小的部分全部前移？然后把基数放到中间？那岂不是多消耗了很多无用功？
        /// 而如果右指针先出发的话，最后找到的数一定是比基数小或者等于基数（即右边的数都大于基数）的，就不会有前段数据需要前移这样的操作！
        /// </summary>
        /// <param name="arr">要排序的数组</param>
        /// <param name="start">子数组的开始位置</param>
        /// <param name="end">子数组的结束位置</param>
        public void Sort(int[] arr, int start, int end) {
            //先找出退出条件
            if (end <= start) {
                //如果end==start或者end-start==1，表示只剩一个或者0个元素，那么就不用排了，大功告成~
                return;
            }
            else {
                //如果数组不是只有一个元素或者0个元素，那么，需要把第一个元素归位
                //关键就是如何找到这个元素对应的中间的位置！以前学不懂快速排序，就卡在这个地方，结果这根本不是这个算法思想的重点！
                //重点在于分而治之！
                //但是难点却在如何找出这个中轴位置！
                int left = start;
                int right = end;

                //如果两个指针还没有重合的话
                while (left < right) {

                    //判断右指针指向的元素是否大于基数
                    if (arr[right] < arr[start]) { //如果说右指针指向的数小于基数
                        //那么就判断左指针的数是否大于基数
                        if (arr[left] > arr[start]) {//如果左指针的数大于基数，那么左右指针的数互换
                            var temp = arr[left];
                            arr[left] = arr[right];
                            arr[right] = temp;
                            //值换完之后，继续跳到外层的while循环，那么下一次会发现右指针的数大于基数，然后就会走下面的right--
                            //继续向左边探测，重复这一过程，直到两个指针重合，得到中轴的位置
                        }
                        else {
                            left++;
                        }
                    }
                    else {//如果右指针指向的数大于基数，那么右指针继续往左推进
                        right--;
                    }
                }

                //这个时候ledf跟right重合了，交换值即可
                var temp2 = arr[start];
                arr[start] = arr[left];
                arr[left] = temp2;

                //再对数组的左边和右边递归进行快速排序，完成这一步过程
                Sort(arr, start, left - 1);
                Sort(arr, left + 1, end);
            }
        }

        public override void Sort() {
            throw new NotImplementedException();
        }
    }
}
