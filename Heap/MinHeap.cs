using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heap
{
    public class MinHeap<T> where T : IComparable<T>
    {
        int _heapSize = 14;
        int _pointer = 0;
        int _index;
        T[] _minHeap;

        public MinHeap()
        {
            _minHeap = new T[_heapSize];
        }

        public void Add(T item)
        {
            bool Added = false;
            if (_pointer < _heapSize)
            {
                _minHeap[_pointer] = item;
                _index = _pointer;
                _pointer++;
                Added = true;
            }
            if (Added)
            {
                int parentPosition = (_index - 1) / 2;
                if (Larger(_minHeap[parentPosition], _minHeap[_index]))
                    do
                    {
                        T tmp = _minHeap[parentPosition];
                        _minHeap[parentPosition] = _minHeap[_index];
                        _minHeap[_index] = tmp;
                        _index = parentPosition;
                        parentPosition = (_index - 1) / 2;
                    }
                    while (Larger(_minHeap[parentPosition], _minHeap[_index]));
            }
            else
                return;
        }

        public T[] Items
        {
            get { return _minHeap; }
        }

        public T peek()
        {
            return _minHeap[0];
        }


        public override string ToString()
        {
            string _return = "";
            for (int i = 0; i+1 <= _pointer;i++ )
            {
                _return = _return + " [" + _minHeap[i] + "]";
            }
                return _return; 
        }

        public bool Remove(T item)
        {
            bool removed = false;
            int i = 0;
            do
            {
                if (_minHeap[i].CompareTo(item) == 0)
                {
                    _minHeap[i] = _minHeap[_pointer - 1];
                    _pointer--;
                    _index = i;
                    removed = true;
                }
                i++;
            }
            while (removed == false && i+1 <= _pointer);
            if(removed&&_index+1<=_pointer)
            {
                int smallChild;
                int rChild = 2 * _index + 1;
                int lChild = 2 * _index + 2;
                if (lChild >= _pointer)
                    lChild = rChild;
                if (lChild > _heapSize)
                    return removed;
                if (rChild > _heapSize)
                    return removed;
                if (Larger(_minHeap[lChild], _minHeap[rChild]))
                    smallChild = rChild;
                else
                    smallChild = lChild;
                if (Larger(_minHeap[_index], _minHeap[smallChild]))
                    do
                    {
                        if (Larger(_minHeap[lChild], _minHeap[rChild]))
                            smallChild = rChild;
                        else
                            smallChild = lChild;
                        if(Larger(_minHeap[_index], _minHeap[smallChild]))
                        {
                            T tmp = _minHeap[smallChild];
                            _minHeap[smallChild] = _minHeap[_index];
                            _minHeap[_index] = tmp;
                        }
                        _index = smallChild;
                        rChild = 2 * _index + 1;
                        lChild = 2 * _index + 2;
                        if (lChild >= _pointer)
                            lChild = rChild;
                    }
                    while(lChild<_pointer&& rChild<_pointer);
            }
            return removed;
        }


        private bool Larger(IComparable<T> first, T second)
        {
            return first.CompareTo(second) > 0;
        }
    }
}
