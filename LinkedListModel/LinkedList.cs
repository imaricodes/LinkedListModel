using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListModel
{
    public class LinkedList
    {
        #region fields

        //number of nodes in list
        int iCount = 1;
        
        //current Node 'index'. When list is first constructed, the value is 0
        int iCurrent = 0;

        //this holds the current Node
        Node nCurrent;

        #endregion

        //it seems that all of these properties are for reporting information about the node?
        #region properties


        //number of nodes in list
        public int Count
        {
            get { return iCount; }
            
        }

        //Contains current node. This is of type 'Node'. Has acess to properties of Node object (see Node class)
        public Node CurrentNode
        {
            
            get { return nCurrent; }
        }
        /// <summary>
        /// index of current node
        /// </summary>
        
        public int CurrentNodeIndex
        {
            get { return iCurrent; }
        }



        #endregion

        #region constructors

        /// <summary>
        /// Constructor to create LinkedList
        /// </summary>
        /// <param name="obj">Value of the first Node</param>
        public LinkedList (object obj)
        {
            //create list with one new node. Next and Previous properties are null because there are no nodes before or after this first node. obj is the value of the new node
            nCurrent = new Node(null, null, obj);
            nCurrent.Next = null;
            nCurrent.Previous = null;
        }



        public void AddNode (object obj)
        {
            
            if(nCurrent.Next == null)
            {
                //1. new node's prev becomes current node
                //2. new node's next is null (it is last node in list)
                //3. value set for new node
                //4. current node becomes new node
                nCurrent = nCurrent.Next = new Node(nCurrent, null, obj);
            }
            else
            {
                //1. new Node's prev becomes current node
                //2. new Nodes' next becomes whatever current node's next is
                //3. value set for new node
                //4. current node's next becomes new node
                //5. current node becomes new node
                nCurrent = nCurrent.Next = new Node(nCurrent, nCurrent.Next, obj);
            }
            //increment iCount because new node has been added
            iCount++;

            //not sure what iCurrent is tracking... 
            iCurrent++;
        }

        public void ToNext()
        {
            if (nCurrent.Next == null)
            {
                throw new Exception("There is no next node!");
            }
            else
            {
                nCurrent = nCurrent.Next;
                iCurrent++;
            }
        }

        public void ToPrevious()
        {
            if (nCurrent.Previous == null)
            {
                throw new Exception("There is no previous node!");
            }
            else
            {
                nCurrent = nCurrent.Previous;
                iCurrent--;
            }
        }

        public void GoToIndex(int index)
        {
            if (iCurrent < index)        
            {
                ToNext();
            }
            else if(iCurrent > index)
            {
                ToPrevious();
            }
        }


        #endregion

    }

}
