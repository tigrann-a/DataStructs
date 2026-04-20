using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBinaryTreeLib
{
    internal class MyBinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        private MyBinaryTreeNode<T> _root;
        private int _count;

        //public bool Contains(T item)
        //{
        //    if (_root == null)
        //    {
        //        return false;
        //    }
        //    if (_root.Value.CompareTo(item) == 0)
        //    {
        //        return true;
        //    }
        //    if (_root.Value.CompareTo(item) > 0)
        //    {
        //        return Contains(_root.Right.Value);
        //    }
        //    else
        //    {
        //        return Contains(_root.Left.Value);
        //    }
        //}

        public bool Contains(T item)
        {
            return FindWithParent(item, out MyBinaryTreeNode<T> parent) != null;
        }

        private MyBinaryTreeNode<T> FindWithParent(T value, out MyBinaryTreeNode<T> parent)
        {
            MyBinaryTreeNode<T> current = _root;
            parent = null;

            while (current != null)
            {
                int result = current.CompareTo(value);
                if (result > 0)
                {
                    parent = current;
                    current = current.Left;
                }
                else if (result < 0)
                {
                    parent = current;
                    current = current.Right;
                }
                else
                    break;
            }

            return current;
        }

        #region PreOrderTraversal

        //public delegate void Action<T>(T item);
        public void PreOrderTraversal(Action<T> action)
        {
            PreOrderTraversal(action, _root);
        }

        private void PreOrderTraversal(Action<T> action, MyBinaryTreeNode<T> root)
        {
            if (root == null)
            {
                return;
            }
            action(root.Value);
            PreOrderTraversal(action, root.Left);
            PreOrderTraversal(action, root.Right);
        }
        #endregion

        #region In-Order Traversal

        public void InOrderTraversal(Action<T> action)
        {
            InOrderTraversal(action, _root);
        }

        private void InOrderTraversal(Action<T> action, MyBinaryTreeNode<T> root)
        {
            if (root == null)
            {
                return;
            }
            
            InOrderTraversal(action, root.Left);
            action(root.Value);
            InOrderTraversal(action, root.Right);
        }

        #endregion

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
