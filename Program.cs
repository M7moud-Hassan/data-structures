using System.Runtime.InteropServices;

namespace DataStructureImp
{

    class Program
    {

        static void Main(String[] args)
        {
            #region  stack
            //Stack stack = new Stack(3);

            //stack.push(10);
            //stack.push(20);
            //stack.push(30);
            //stack.push(40);

            //Console.WriteLine(stack.pop() ?? 0);
            //Console.WriteLine(stack.pop() ?? 0);
            //Console.WriteLine(stack.pop() ?? 0);
            //Console.WriteLine(stack.pop() ?? 0);
            #endregion

            #region Queue


            //Queue queue = new Queue();

            //queue.enQueue(1);
            //queue.enQueue(2);
            //queue.enQueue(3);

            //Console.WriteLine(queue.deQueue() ?? -1);
            //Console.WriteLine(queue.deQueue() ?? -1);
            //Console.WriteLine(queue.deQueue() ?? -1);
            //queue.enQueue(4);

            #endregion

            #region CircularQueue
            //CircularQueue circularQueue = new CircularQueue();

            //circularQueue.enQueue(1);
            //circularQueue.enQueue(2);
            //circularQueue.enQueue(3);
            //circularQueue.enQueue(4);
            //circularQueue.enQueue(5);

            //circularQueue.deQueue();
            //circularQueue.deQueue();
            //circularQueue.deQueue();
            //circularQueue.enQueue(7);
            //circularQueue.enQueue(7);
            //circularQueue.enQueue(7);


            //circularQueue.display();
            #endregion

            #region SingleLinkList
            SingleLinkedList singleLinkedList = new SingleLinkedList(5);
            //singleLinkedList.insert(1);
            //singleLinkedList.insert(2);
            //singleLinkedList.insert(11);
            //singleLinkedList.insertBeginning(0);
            //Console.WriteLine(singleLinkedList.ToString());
            //singleLinkedList.insertAtIndex(10,2);
            //Console.WriteLine(singleLinkedList.ToString());
            //singleLinkedList.deleteAtIndex(2);
            //Console.WriteLine(singleLinkedList.ToString());
            //Console.WriteLine(singleLinkedList.search(11));
            //singleLinkedList.sort();
            //Console.WriteLine(singleLinkedList.ToString());
            //singleLinkedList.insert(3);
            //singleLinkedList.insert(4);
            //singleLinkedList.insert(5);
            //Console.WriteLine(singleLinkedList.ToString());
            //singleLinkedList[5] = 20;
            //Console.WriteLine(singleLinkedList.ToString());
            //Console.WriteLine(singleLinkedList[5]);
            //singleLinkedList.insert(4);
            //singleLinkedList.insert(10);
            //singleLinkedList.insert(3);
            //singleLinkedList.insert(8);
            //Console.WriteLine(singleLinkedList);
            //singleLinkedList.sort();
            // Console.WriteLine(singleLinkedList);
            #endregion

            #region DoublyLinkedList
            //DoublyLinkedList doublyLinkedList = new DoublyLinkedList(5);
            //doublyLinkedList.insertLast(6);
            //doublyLinkedList.insertLast(9);
            //doublyLinkedList.insertLast(10);
            //doublyLinkedList.insertLast(11);
            //doublyLinkedList.insertFront(12);
            //doublyLinkedList.insertFront(13);
            //Console.WriteLine(doublyLinkedList.ToString());
            //doublyLinkedList.insertAtIndex(2, 100);
            //Console.WriteLine(doublyLinkedList.ToString());
            //doublyLinkedList.deleteAtIndex(3);
            //doublyLinkedList[5] = 29929;
            //Console.WriteLine(doublyLinkedList.ToString());
            //doublyLinkedList.sort();
            //Console.WriteLine(doublyLinkedList.ToString());
            #endregion


            #region BinarySearchTree
            BinarySearchTree binarySearchTree = new BinarySearchTree(44);
            binarySearchTree.insert(17);
            binarySearchTree.insert(28);
            binarySearchTree.insert(29);
            binarySearchTree.insert(88);
            binarySearchTree.insert(65);
            binarySearchTree.insert(97);
            binarySearchTree.insert(54);
            binarySearchTree.insert(82);
            binarySearchTree.insert(76);
            binarySearchTree.insert(80);
            binarySearchTree.insert(78);
            binarySearchTree.travelLDR();
            binarySearchTree.Remove(44);
            binarySearchTree.travelLDR();
            // binarySearchTree.travelRDL();
            //Console.WriteLine(binarySearchTree.Contain(8));
            #endregion


        }


    }
}