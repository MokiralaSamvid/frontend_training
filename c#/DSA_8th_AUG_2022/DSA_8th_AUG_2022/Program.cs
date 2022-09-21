using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_8th_AUG_2022
{
    internal class Program
    {
        public Node root = null;
        public Node temp = null;

        static void Main(string[] args)
        {
            Program p1 = new Program();p1.root = null;
            Program p2 = new Program();p2.root= null;
            Console.WriteLine("Enter no of elements to be inserted in Your list");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Enter element to insert");
                int data = int.Parse(Console.ReadLine());
                p1.Pushele(data);
            }
            p1.Printele(p1.root);
            Console.ReadLine();
            p1.Pushele(100); 

            //Console.WriteLine("Enter no of elements to be inserted in Your list");
            //n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Enter element to insert");
            //    int data = int.Parse(Console.ReadLine());
            //    p2.Pushele(data);
            //}
            //p2.Printele(p2.root);
            //Console.ReadLine();

            Console.WriteLine("Deletion");
            Console.WriteLine("Enter element to delete");
            int ele = int.Parse(Console.ReadLine());
            p1.Delete(ele,p1.root);
        }   
        public void Pushele(int data)
        {
             
             Node newnode = new Node(data);

            if (root == null)
            {
                root = newnode; /*Console.WriteLine("1 st ele  " + data);*/
                temp = newnode;
            }

            else
            {
                
                temp.right = newnode;
                temp = newnode;
            }

        }
        public void Printele(Node root)
        {
            if (root == null) Console.WriteLine("Noting to print");
            while (root != null)
            {
                Console.Write(root.data + "  ");
                root = root.right;
            }
        }
        public void Delete(int data,Node root)
        {
            
           
            if (root == null)
                Console.WriteLine("Noting to delete here");
            else
            {
                while (root.data != data || root.right!=null)
                {
                    temp = root;
                    root = root.right;
                }
                if (root.data == data)
                {
                    Console.WriteLine("The data deleted is {0}", root.data);
                    temp.right = root.right;
                }
                else
                {
                    Console.WriteLine("List doesnot have the data that you want to delete");
                }
              
            }

        }
    }
    }

    class Node
    {
        public int data;
        public Node right;
        public Node(int data)
        {
            this.data = data;
            right = null;
        }   
    }

