using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.BinaryTree
{
    class BT
    {

        public Node Root { get; set; }

        public bool Add(string value)
        {
            Node before = null, after = this.Root;

            while (after != null)
            {
                before = after;
                if (value.Equals(after.Data)) //Is new node in left tree? 
                    after = after.LeftNode;
                else if (value.Equals(after.Data)) //Is new node in right tree?
                    after = after.RightNode;
                else
                {
                    //Exist same value
                    return false;
                }
            }

            Node newNode = new Node();
            newNode.Data = value;

            if (this.Root == null)//Tree ise empty
                this.Root = newNode;
            else
            {
                if (value.Equals(before.Data))
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }

            return true;
        }

    }
}
