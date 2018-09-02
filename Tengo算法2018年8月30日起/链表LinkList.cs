using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tengo算法2018年8月30日起 {
    /// <summary>
    /// 2018年9月2日22:48:13
    /// </summary>
    public class 链表LinkList {

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
            persons.AddAfter(persons.Find(person0), new Person {
                ID = 2,
                Name = "小刘"
            });
            persons.AddAfter(persons.Find(person0), new Person {
                ID = 3,
                Name = "小张"
            });

            //遍历链表,但是，这并不是链表本身的遍历方法，而是继承了枚举接口才拥有的方法！非正宗链表的遍历！
            //foreach (var person in persons) {
            //    Console.WriteLine("person" + "{id:" + person.ID + ",\"name\":\"" + person.Name + "\"}");
            //}

            var head = persons.First;
            Console.WriteLine("开始循环打印链表......");
            Print(head, head);
        }



        /// <summary>
        /// 遍历打印链表
        /// 由于是双向链表，因此会导致无限循环！
        /// 2018年9月2日22:48:05
        /// </summary>
        /// <param name="currentNode">当前节点</param>
        public static void Print(LinkedListNode<Person> currentNode) {
            if (currentNode != null) {
                Console.WriteLine("person" + "{id:" + currentNode.Value.ID + ",\"name\":\"" + currentNode.Value.Name + "\"}");
                if (currentNode.Next != null) {
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
            if (currentNode != null) {
                Console.WriteLine("person" + "{id:" + currentNode.Value.ID + ",\"name\":\"" + currentNode.Value.Name + "\"}");
                if (currentNode.Next != null && currentNode.Next != head) {
                    Print(currentNode.Next);
                }
            }
        }
    }



    public class Person {
        public int ID { get; set; }

        public string Name { get; set; }
    }
}
