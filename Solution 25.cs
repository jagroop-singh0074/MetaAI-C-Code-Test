public class MyCircularDeque {
    
    private int[] deque;
    private int head;
    private int tail;
    private int size;
    private int capacity;

    public MyCircularDeque(int k) {
        capacity = k;
        deque = new int[k];
        head = 0;
        tail = 0;
        size = 0;
    }
    
    public bool InsertFront(int value) {
        if (IsFull()) {
            return false;
        }
        head = (head - 1 + capacity) % capacity;
        deque[head] = value;
        size++;
        return true;
    }
    
    public bool InsertLast(int value) {
        if (IsFull()) {
            return false;
        }
        deque[tail] = value;
        tail = (tail + 1) % capacity;
        size++;
        return true;
    }
    
    public bool DeleteFront() {
        if (IsEmpty()) {
            return false;
        }
        head = (head + 1) % capacity;
        size--;
        return true;
    }
    
    public bool DeleteLast() {
        if (IsEmpty()) {
            return false;
        }
        tail = (tail - 1 + capacity) % capacity;
        size--;
        return true;
    }
    
    public int GetFront() {
        if (IsEmpty()) {
            return -1;
        }
        return deque[head];
    }
    
    public int GetRear() {
        if (IsEmpty()) {
            return -1;
        }
        return deque[(tail - 1 + capacity) % capacity];
    }
    
    public bool IsEmpty() {
        return size == 0;
    }
    
    public bool IsFull() {
        return size == capacity;
    }
}
