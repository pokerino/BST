using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heap
{
    public class PriorityQueue<TKey, TValue> where TKey : IComparable<TKey>
    {
        MinHeap<PriorityQueueNode<TKey, TValue>> _queue = new MinHeap<PriorityQueueNode<TKey,TValue>>();

        public void Dequeue()
        {
            PriorityQueueNode<TKey, TValue> tmpQ = tmpQ = _queue.peek();
            _queue.Remove(tmpQ);
        }

        public void Enqueue(TValue item, TKey order)
        {
            PriorityQueueNode<TKey,TValue> _new = new PriorityQueueNode<TKey,TValue>(item, order);
            _queue.Add(_new);           
        }

        public TValue Peek()
        {
            PriorityQueueNode<TKey, TValue> tmpQ = tmpQ = _queue.peek();
            return tmpQ.Item;
            
        }

        public override string ToString()
        {
            return Convert.ToString(_queue);
        }
    }

    /// <summary>
    /// Typ som används för noderna i prioritetskön. En nod 
    /// innehåller både en prioritet samt ett generiskt värde.
    /// </summary>
    public class PriorityQueueNode<TKey, TValue> : IComparable<PriorityQueueNode<TKey, TValue>>
        where TKey : IComparable<TKey>
    {
        public TKey Priority { get; private set; }
        public TValue Item { get; private set; }

        public PriorityQueueNode(TValue item, TKey priority)
        {
            this.Priority = priority;
            this.Item = item;
        }

        public int CompareTo(PriorityQueueNode<TKey, TValue> other)
        {
            return Priority.CompareTo(other.Priority);
        }

        public override string ToString()
        {
            return Convert.ToString(Item);
        }
    }
}
