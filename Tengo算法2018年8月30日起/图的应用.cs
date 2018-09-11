using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tengo算法2018年8月30日起 {
    public class 图的应用 {

        //定义一个哈希表，用来存放图中各个节点的关系
        Hashtable friendship = new Hashtable();

        //定义一个队列，用来存放要遍历的
        Queue queue = new Queue();

        ///定义一个哈希表，存放已经搜索过的节点
        Hashtable friendshipSearched = new Hashtable();

        public void BFS() {
            //先把图的关系用哈希表表示出来（建议私下用笔和纸画一下这个关系图）
            friendship["tengo"] = new string[] { "bob", "alice", "claire" };
            friendship["bob"] = new string[] { "anju", "peggy" };
            friendship["alice"] = new string[] { "peggy" };
            friendship["claire"] = new string[] { "jonny", "thom" };
        }

        /// <summary>
        /// 搜索朋友
        /// </summary>
        public void AddFriends(string name) {
            var friends = friendship[name] as string[];
            if(friends != null && friends.Length > 0) {
                foreach(var item in friends) {
                    //把这个节点的所有子结点加进去
                    queue.Enqueue(item);
                }
            }
        }

    }
}
