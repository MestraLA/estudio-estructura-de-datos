using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Backend;

public class QueueUsingList <T>
{
    private List<T> _queue;

    public QueueUsingList()
    {
        _queue = new List<T>();
    }
    public bool IsEmpty { get =>  _queue.Count == 0; }

    public void Enqueue(T item)
    {
        _queue.Add(item);
    }

    public T Dequeue()
    {
        if (IsEmpty)
        {
            throw new Exception("Queue is empty");
        }
        T item = _queue[0];
        _queue.RemoveAt(0);
        return item;
    }

    public T Peek()
    {
        if (IsEmpty)
        {
            throw new Exception("Queue is empty");
        }
        return _queue[0];
    }

}
