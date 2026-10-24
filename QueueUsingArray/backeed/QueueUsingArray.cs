namespace Backeed;

public class QueueUsingArray<T>
{
    private T[] _queue;
    private int _front;
    private int _rear;
    private int _count;
    private int _capacity;

    public QueueUsingArray(int capacity)
    {
        _capacity = capacity;
        _queue = new T[capacity];
        _rear = -1;
        _front = 0;
        _count = 0;
    }

    public bool IsFull {  get => _count == _capacity; }

    public bool IsEmpty { get => _count==0; }

    //encolar 
    public void Enqueue(T item)
    {
        if (IsFull)
        {
            throw new Exception("Queue is full");
        }
        // _rear=(_rear+1) % _capacity; incremento circular 
        _rear = (_rear+1) % _capacity;
        _queue[_rear] = item;
        _count++;
    } 

    //desencolar
    public T Dequeue()
    {
        if (IsEmpty)
        {
            throw new Exception("Queue is empty.");
        }
        T item = _queue [_front];
        _front = (_front + 1) % _capacity;
        _count--;
        return item;
    }

    public T peek()
    {
        if (IsEmpty)
        {
            throw new Exception("Queue is empty.");
        }
        return _queue[_front];
    }


}
