using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_9th_August_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BST b = new BST();
            b.insert(50);
            b.insert(80);
            b.insert(40);
            b.insert(100);
            b.show();
            Console.ReadLine();
            b.insert(585);
            b.insert(20);
            //b.delete(40);
           // b.delete(50);
            b.show();
            Console.ReadKey();
        }

    }

    class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }

    class BST
    {
        Node root;
        public void insert(int data)
        {
            Node temp; Node current=null;
            Node node = new Node(data);

            if(root == null)
                root = node;
            else 
            {
                temp = root;
                while(temp!=null)
                {
                    current = temp;
                    if (node.data > temp.data)
                        temp = temp.right;
                    else
                        temp = temp.left;
                }

                if(node.data > current.data )
                    current.right = node;
                else
                    current.left = node;

            }

        }
        public void show()
        {
            show(root);
        }
        public void show(Node t)
        {
            if(t.left!=null)
                show(t.left);
            Console.Write(t.data+" ");
            if(t.right!=null) show(t.right);
        }

        //public void delete(int data)
        //{
        //    Node parent;
        //    parent=search(data, root);
        //    delete(data, parent);
        //}
        //public void delete(int data,Node parent)
        //{
        //    Node temp=parent.left;
        //    if (temp.data == data)
        //        temp = parent.left;
        //    else 
        //        temp = parent.right;


        //    //-----------------------------------------------------//
        //    if (temp == parent.left)
        //    {
        //        if (temp.left == null && temp.right == null)
        //            parent.left = null;
        //        else if (temp.left != null && temp.right == null)
        //            parent.left = temp.left;
        //        else if (temp.left == null && temp.right != null)
        //            parent.left = temp.right;
        //        //============= ONE MORE CONDITION LEFT============///
        //        else
        //        {
        //            Node Max = Maxval(temp);
        //            parent.left=Max;
        //        }
        //    }

        //    if (temp == parent.right)
        //    {
        //        if (temp.left == null && temp.right == null)
        //            parent.right = null;
        //        else if (temp.left != null && temp.right == null)
        //            parent.right = temp.left;
        //        else if (temp.left == null && temp.right != null)
        //            parent.right = temp.right;
        //        //============= ONE MORE CONDITION WILL COME ======///
        //        else
        //        {
        //          Node Min = Minval(temp);
        //          parent.right=Min;
        //        }
        //    }
        //}
        //public Node Maxval(Node rot)
        //{
        //    while(rot.right!=null) rot = rot.right;
        //    return rot;
        //}
        //public Node Minval(Node rot)
        //{
        //    while(rot.left!=null) rot = rot.left;
        //    return rot;
        //}
        //public Node search(int data,Node t)
        //{
        //    Node parent = t;
        //    while(t != null)
        //    {
        //        parent = t;
        //        if (data == t.data)
        //            break;
        //        else if (data > t.data)
        //        { t = t.right; Console.WriteLine("Data is at right side"); }
        //        else
        //        { t = t.left; Console.WriteLine("Data is at left side"); }
        //    }
        //    return parent;
        //}
    }

}
