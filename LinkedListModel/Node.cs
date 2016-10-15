using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListModel
{
    public class Node
    {
        #region fields
        protected Node nPrevious;
        protected Node nNext;
        protected object Object;
        #endregion

        #region properties

        //this object is the value the node contains
        public object Value{
            get { return Object; }
            set { Object = value; }
        }
        public Node Previous
        {
            get { return nPrevious; }
            set { nPrevious = value; }
        }
 
        public Node Next
        {
            get { return nNext; }
            set { nNext = value; }
        }

        #endregion



        #region constructor

        public Node(Node PrevNode, Node NextNode, Object obj)
        {
            nPrevious = PrevNode;
            nNext = NextNode;
            Object = obj;

        }
        #endregion




    }

}
