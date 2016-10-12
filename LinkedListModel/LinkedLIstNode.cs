using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListModel
{
    //This is a node class. We create this so we can instantiate node objects
    public class LinkedListNode<T>
    {
        //This is a constructor that takes a value of <some> type as a parameter   
        public LinkedListNode (T value)
        {
            Value = value;
        }

        //this is a Property of the LinkedListNode object. Allows access to the value field of node
        public T Value { get; set; }

        //this is a Next property (or attribute) of the node object. Here is where we store the location of the next linked node (or 'null' if none).
        public LinkedListNode<T> Next { get; set; }
    }
}
