using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListModel
{
    class Program
    {

        

        static void Main(string[] args)
        {
            //create a list with one node
            Console.WriteLine("List created with new node 'sarah'");
            LinkedList names = new LinkedList("sarah");

            Console.WriteLine("Number of nodes: " + names.Count);

            //add node "bob"
            Console.WriteLine("Add node: 'bob'");
            names.AddNode("bob");
            Console.WriteLine("Value of current node is: " + names.CurrentNode.Value);
            Console.WriteLine("Value of previous node is:" + names.CurrentNode.Previous.Value);

            Console.WriteLine("Number of nodes: " + names.Count);


            Console.ReadKey();
        }
    }


   
}

