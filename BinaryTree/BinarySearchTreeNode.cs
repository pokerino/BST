using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace BinaryTree
{
    public partial class BinarySearchTreeNode<T> where T : IComparable<T>
    {
        private T _value;
        public T _exception;
        public T Value
        {
            get { return _value; }
        }

        private BinarySearchTreeNode<T> _leftChild, _parent, _rightChild;
        public BinarySearchTreeNode<T> LeftChild
        {
            get { return _leftChild; }
            set { _leftChild = value; }
        }

        public BinarySearchTreeNode<T> RightChild
        {
            get { return _rightChild; }
            set { _rightChild = value; }
        }

        public BinarySearchTreeNode<T> Parent
        {
            get { return _parent; }
            set { _parent = value;}
        }

        bool IsLeftChild
        {
            get
            {
                if (Parent == null)
                    return false;
                if (Value.CompareTo(Parent.Value) < 0)
                    return true;
                else
                    return false;
            }
        }

        bool IsRightChild
        {
            get
            {
                if (Parent == null)
                    return false;
                if (Value.CompareTo(Parent.Value) >= 0)
                    return true;
                else
                    return false;
            }
        }

        public BinarySearchTreeNode(T value)
        {
            _value = value;
            Parent = this;
        }

        public void Insert(T value)
        {
            if(value.CompareTo(Value) < 0) 
            {
                if(LeftChild != null)
                {
                    LeftChild.Insert(value);
                }
                else
                {
                    LeftChild = new BinarySearchTreeNode<T>(value);
                    LeftChild.Parent = this;
                }
            }

            if (value.CompareTo(Value) >= 0)
            {
                if (RightChild != null)
                {
                    RightChild.Insert(value);
                }
                else
                {
                    RightChild = new BinarySearchTreeNode<T>(value);
                    RightChild.Parent = this;
                }
            }
    
        }


        public void Remove(T value)
        {

            if (value.CompareTo(Value) == 0)
            {
                Parent.IsChanged = true;

                if (RightChild== null && LeftChild == null)
                {
                    Parent.ParentRemove(value);
                }
                if (RightChild == null && LeftChild != null)
                {
                    LeftChild.Parent = Parent;
                    if (value.CompareTo(Parent.Value) < 0)
                        Parent.LeftChild = LeftChild;
                    if (value.CompareTo(Parent.Value) > 0)
                        Parent.RightChild = LeftChild;
                }
                if (RightChild != null && LeftChild == null)
                {
                    RightChild.Parent = Parent;
                    if (value.CompareTo(Parent.Value) < 0)
                        Parent.LeftChild = RightChild;
                    if (value.CompareTo(Parent.Value) > 0)
                        Parent.RightChild = RightChild;
                }
                if(RightChild != null && LeftChild != null)
                {
                    if(RightChild.RightChild == null && RightChild.LeftChild == null)
                    {
                        RightChild.IsChanged = true;
                        RightChild.LeftChild = LeftChild;
                        RightChild.Parent = Parent;
                        if (value.CompareTo(Parent.Value) < 0)
                            Parent.LeftChild = RightChild;
                        
                        if (value.CompareTo(Parent.Value) > 0)
                            Parent.RightChild = RightChild;
                    }
                    else
                    {
                        BinarySearchTreeNode<T> tmpChild = RightChild.TraverstLeft();
                        this.Remove(tmpChild.Value);
                        _value = tmpChild.Value;
                    }
                }
            }

            else
            {
                if (value.CompareTo(Value) < 0)
                {
                    if (LeftChild != null)
                    {
                        LeftChild.Remove(value);
                    }
                }
                if (value.CompareTo(Value) >= 0)
                {
                    if (RightChild != null)
                    {
                        RightChild.Remove(value);
                    }

                }
            }

        }

        public void ParentRemove(T value)
        {
            if(LeftChild!=null)
                if(value.CompareTo(LeftChild.Value)== 0)
                {
                    LeftChild = null;
                    return;
                }
            if(RightChild!=null)
                if(value.CompareTo(RightChild.Value)==0)
                {
                    RightChild = null;
                    return;
                }
                
        }

        public BinarySearchTreeNode<T> TraverstLeft()
        {
            if(LeftChild != null)
                return LeftChild.TraverstLeft();
            else
            {
                BinarySearchTreeNode<T> tmpChild = this;
                return tmpChild;
            }
        }

        public bool Find(T value)
        {
            if (value.Equals(Value))
            {
                return true;
            }

            else
            {
                if (value.CompareTo(Value) < 0) 
                {
                    if(LeftChild != null)
                    {
                        return LeftChild.Find(value);
                    }
                }
                if (value.CompareTo(Value) >= 0)
                {
                    if(RightChild != null)
                    {
                        return RightChild.Find(value);
                    }

                }
            }
            return false;
        }


        public IEnumerable<T> Inorder()
        {
            List<T> InList = new List<T>();
            InList = TraversInorder();
            return InList;
        }

        public List<T> TraversInorder()
        {
            List<T> tmpRgtList = new List<T>();
            List<T> tmpLftList = new List<T>();
            if (LeftChild != null)
                tmpLftList = LeftChild.TraversInorder();
            if (RightChild != null)
                tmpRgtList = RightChild.TraversInorder();
            tmpLftList.Add(Value);
            tmpLftList.AddRange(tmpRgtList);
            return tmpLftList;
        }

        public IEnumerable<T> Postorder()
        {
            List<T> PostList = new List<T>();
            PostList = TraversPostorder();
            return PostList;
        }

        public List<T> TraversPostorder()
        {
            List<T> tmpRgtList = new List<T>();
            List<T> tmpLftList = new List<T>();
            if (LeftChild != null)
                tmpLftList = LeftChild.TraversPostorder();
            if (RightChild != null)
                tmpRgtList = RightChild.TraversPostorder();
            tmpLftList.AddRange(tmpRgtList);
            tmpLftList.Add(Value);
            return tmpLftList;
        }

        public IEnumerable<T> Preorder()
        {
            List<T> PreList = new List<T>();
            PreList = TraversPreorder();
            return PreList;
        }

        public List<T> TraversPreorder()
        {
            List<T> tmpRgtList = new List<T>();
            List<T> tmpLftList = new List<T>();
            tmpLftList.Add(Value);
            if (LeftChild != null)
                tmpLftList.AddRange(LeftChild.TraversPreorder());
            if (RightChild != null)
                tmpRgtList.AddRange(RightChild.TraversPreorder());
            tmpLftList.AddRange(tmpRgtList);
            return tmpLftList;
        }
    }
}
