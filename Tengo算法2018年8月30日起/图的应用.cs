using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tengo算法2018年8月30日起 {
    public class 图的应用 {

        //定义一个哈希表，用来存放图中各个节点的关系
        Dictionary<string, string[]> friendship = new Dictionary<string, string[]>();

        //定义一个队列，用来存放要遍历的朋友列表
        Queue<string> queue = new Queue<string>();

        ///定义一个哈希表，存放已经搜索过的节点
        public List<string> friendshipSearched = new List<string>();

        /// <summary>
        /// 创建队列并执行广度优先搜索
        /// </summary>
        public void BFS() {
            //先把图的关系用哈希表表示出来（建议私下用笔和纸画一下这个关系图）
            friendship["tengo"] = new string[] { "bob", "alice", "claire" };
            friendship["bob"] = new string[] { "anju", "peggy" };
            friendship["alice"] = new string[] { "peggy" };
            friendship["claire"] = new string[] { "jonny", "thom" };

            //先把自己加进去
            queue.Enqueue("tengo");

            //只要队列不为空，那就要一直搜索！
            while(queue.Count > 0) {
                //把头一个元素拿出来
                var topFriend = queue.Dequeue();

                //找出当前结点的所有朋友
                var friends = friendship.ContainsKey(topFriend) ? friendship[topFriend] : null;

                //如果说这个朋友没有朋友的话（该结点没有子结点）
                if(friends == null || friends.Length == 0) {
                    continue;
                }

                //对当前朋友的朋友列表进行遍历
                foreach(var item in friends)
                    if(!friendshipSearched.Contains(item)) {
                        //把他的朋友加入到队列最后的位置中去
                        queue.Enqueue(item);

                        //在已搜索列表中加入已经这个朋友
                        friendshipSearched.Add(item);
                    }

            }

            //打印遍历的结果
            foreach(var item in friendshipSearched)
                Console.Write(item + "，");
        }


    }
}
