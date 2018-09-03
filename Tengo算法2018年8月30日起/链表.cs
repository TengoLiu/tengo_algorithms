using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tengo算法2018年8月30日起 {
    /// <summary>
    /// 链表LinkedList
    /// 2018年9月2日22:48:13
    /// </summary>
    public class 链表 {

        /// <summary>
        /// 定义一个双向链表
        /// </summary>
        static LinkedList<Person> persons = new LinkedList<Person>();

        public static void Run() {
            var person0 = new Person {
                ID = 1,
                Name = "小明"
            };
            //添加一个节点到头部
            persons.AddFirst(person0);

            //在某个节点的后面添加一个元素
            persons.AddLast(new Person {
                ID = 2,
                Name = "小刘"
            });
            persons.AddLast(new Person {
                ID = 3,
                Name = "小张"
            });
            persons.AddLast(new Person {
                ID = 4,
                Name = "小李"
            });

            //遍历链表,但是，这并不是链表本身的遍历方法，而是继承了枚举接口实现的方法！非正宗链表的遍历！
            //foreach (var person in persons) {
            //    Console.WriteLine("person" + "{id:" + person.ID + ",\"name\":\"" + person.Name + "\"}");
            //}

            var head = persons.First;
            Console.WriteLine("开始循环打印链表......");
            Print(head, head);

            Console.WriteLine("\n反转链表......");
            Reverse(persons);
            head = persons.First;
            Print(head, head);

        }

        /// <summary>
        /// 遍历打印链表
        /// 由于是双向链表，因此会导致无限循环！
        /// 2018年9月2日22:48:05
        /// </summary>
        /// <param name="currentNode">当前节点</param>
        public static void Print(LinkedListNode<Person> currentNode) {
            if(currentNode != null) {
                Console.WriteLine("person" + "{id:" + currentNode.Value.ID + ",\"name\":\"" + currentNode.Value.Name + "\"}");
                if(currentNode.Next != null) {
                    //注意，这样打印是会出问题的，因为我们定义的是双向链表，因此到最后一个节点的时候，它又会指向第一个节点，导致重新遍历！
                    //然后就是无限循环！！！！！
                    Print(currentNode.Next);
                }
            }
        }

        /// <summary>
        /// 遍历打印链表改进版
        /// 这里要求传入一个head对象，如果结尾的对象指向head，那么说明遍历完了，退出，避免无限循环！
        /// </summary>
        /// <param name="currentNode">当前节点</param>
        /// <param name="head">头结点</param>
        public static void Print(LinkedListNode<Person> currentNode, LinkedListNode<Person> head) {
            if(currentNode != null) {
                Console.WriteLine("person" + "{id:" + currentNode.Value.ID + ",\"name\":\"" + currentNode.Value.Name + "\"}");
                if(currentNode.Next != null && currentNode.Next != head) {
                    Print(currentNode.Next);
                }
            }
        }

        /// <summary>
        /// 链表的反转
        /// 思路：
        ///     先找到初始的最后的元素
        ///     然后不断地把头结点移到初始尾结点后面去
        ///     1 2 3 4
        ///     2 3 4 1 把1放到了4的后面
        ///     3 4 2 1 那2放到了4的后面
        ///     4 3 2 1 把3放到了4的后面
        ///     直到头结点为初始的尾结点即结束循环！
        ///     
        /// 时间复杂度为 O(n)
        /// </summary>
        /// <param name="links">要反转的链表</param>
        public static void Reverse(LinkedList<Person> links) {
            var last = links.Last;

            //循环取n-1次，把头结点插入到末尾结点中
            while(links.First != last) {
                //获取当前头结点
                var currentFirst = links.First;

                //移除掉当前的头节点
                links.RemoveFirst();

                //然后把头结点移动到初始的尾结点后面
                links.AddAfter(last, currentFirst);
            }
        }
    }



    public class Person {
        public int ID { get; set; }

        public string Name { get; set; }
    }
}
