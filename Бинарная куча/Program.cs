namespace Бинарная_куча
{
    //class BinaryHeap
    //{
    //    private int[] heap;
    //    private int size;
    //    private int capacity;

    //    public BinaryHeap(int capacity)
    //    {
    //        this.capacity = capacity;
    //        heap = new int[capacity];
    //        size = 0;
    //    }

    //    public void Insert(int value)
    //    {
    //        if (size == capacity)
    //        {
    //            Console.WriteLine("Heap is full. Cannot insert element.");
    //            return;
    //        }

    //        heap[size] = value;
    //        size++;
    //        HeapifyUp(size - 1);
    //    }

    //    public int Pop()
    //    {
    //        if (size == 0)
    //        {
    //            Console.WriteLine("Heap is empty. Cannot pop element.");
    //            return int.MinValue;
    //        }

    //        int root = heap[0];
    //        heap[0] = heap[size - 1];
    //        size--;
    //        HeapifyDown(0);

    //        return root;
    //    }

    //    public void PrintHeap()
    //    {
    //        for (int i = 0; i < size; i++)
    //        {
    //            Console.Write(heap[i] + " ");
    //        }
    //        Console.WriteLine();
    //    }

    //    private void HeapifyUp(int index)
    //    {
    //        int parent = (index - 1) / 2;

    //        if (index > 0 && heap[index] > heap[parent])
    //        {
    //            Swap(index, parent);
    //            HeapifyUp(parent);
    //        }
    //    }

    //    private void HeapifyDown(int index)
    //    {
    //        int leftChild = 2 * index + 1;
    //        int rightChild = 2 * index + 2;
    //        int largest = index;

    //        if (leftChild < size && heap[leftChild] > heap[largest])
    //        {
    //            largest = leftChild;
    //        }

    //        if (rightChild < size && heap[rightChild] > heap[largest])
    //        {
    //            largest = rightChild;
    //        }

    //        if (largest != index)
    //        {
    //            Swap(index, largest);
    //            HeapifyDown(largest);
    //        }
    //    }

    //    private void Swap(int index1, int index2)
    //    {
    //        int temp = heap[index1];
    //        heap[index1] = heap[index2];
    //        heap[index2] = temp;
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        BinaryHeap heap = new BinaryHeap(10);

    //        heap.Insert(5);
    //        heap.Insert(3);
    //        heap.Insert(8);
    //        heap.Insert(2);
    //        heap.Insert(10);

    //        Console.WriteLine("Heap:");
    //        heap.PrintHeap();

    //        int max = heap.Pop();
    //        Console.WriteLine($"Popped Max Element: {max}");

    //        Console.WriteLine("Heap after popping max element:");
    //        heap.PrintHeap();
    //    }
    //}

    //class PriorityQueue
    //{
    //    private int[] heap;
    //    private int size;
    //    private int capacity;
    //    public PriorityQueue(int capacity)
    //    {
    //        this.capacity = capacity;
    //        heap = new int[capacity];
    //        size = 0;
    //    }

    //    public void Enqueue(int value)
    //    {
    //        if (size == capacity)
    //        {
    //            Console.WriteLine("Priority Queue is full. Cannot enqueue element.");
    //            return;
    //        }

    //        heap[size] = value;
    //        size++;
    //        HeapifyUp(size - 1);
    //    }

    //    public int Dequeue()
    //    {
    //        if (size == 0)
    //        {
    //            Console.WriteLine("Priority Queue is empty. Cannot dequeue element.");
    //            return int.MinValue;
    //        }

    //        int highestPriority = heap[0];
    //        heap[0] = heap[size - 1];
    //        size--;
    //        HeapifyDown(0);

    //        return highestPriority;
    //    }

    //    public void PrintPriorityQueue()
    //    {
    //        for (int i = 0; i < size; i++)
    //        {
    //            Console.Write(heap[i] + " ");
    //        }
    //        Console.WriteLine();
    //    }

    //    private void HeapifyUp(int index)
    //    {
    //        int parent = (index - 1) / 2;

    //        if (index > 0 && heap[index] < heap[parent])
    //        {
    //            Swap(index, parent);
    //            HeapifyUp(parent);
    //        }
    //    }

    //    private void HeapifyDown(int index)
    //    {
    //        int leftChild = 2 * index + 1;
    //        int rightChild = 2 * index + 2;
    //        int smallest = index;

    //        if (leftChild < size && heap[leftChild] < heap[smallest])
    //        {
    //            smallest = leftChild;
    //        }

    //        if (rightChild < size && heap[rightChild] < heap[smallest])
    //        {
    //            smallest = rightChild;
    //        }

    //        if (smallest != index)
    //        {
    //            Swap(index, smallest);
    //            HeapifyDown(smallest);
    //        }
    //    }

    //    private void Swap(int index1, int index2)
    //    {
    //        int temp = heap[index1];
    //        heap[index1] = heap[index2];
    //        heap[index2] = temp;
    //    }


    //    public void Print()
    //    {
    //        if (size == 0)
    //        {
    //            Console.WriteLine("PriorityQueue is empty.");
    //            return;
    //        }

    //        PrintNode(0, "");
    //    }
    //    /// <summary> 
    //    /// Отрисовка дерева 
    //    /// </summary> 
    //    /// <param name="currentNode"></param> 
    //    /// <param name="indent"></param> 
    //    private void PrintNode(int index, string indent)
    //    {
    //        if (index < size)
    //        {
    //            Console.WriteLine(indent + heap[index]);

    //            int leftChildIndex = 2 * index + 1;
    //            int rightChildIndex = 2 * index + 2;

    //            if (leftChildIndex < size)
    //            {
    //                Console.WriteLine(indent + "├── " + "Left Child:");
    //                PrintNode(leftChildIndex, indent + "│   ");
    //            }

    //            if (rightChildIndex < size)
    //            {
    //                Console.WriteLine(indent + "└── " + "Right Child:");
    //                PrintNode(rightChildIndex, indent + "    ");
    //            }
    //        }
    //    }




    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        PriorityQueue priorityQueue = new PriorityQueue(10);

    //        priorityQueue.Enqueue(5);
    //        priorityQueue.Enqueue(3);
    //        priorityQueue.Enqueue(8);
    //        priorityQueue.Enqueue(2);
    //        priorityQueue.Enqueue(10);

    //        Console.WriteLine("Priority Queue:");
    //        priorityQueue.PrintPriorityQueue();



    //        priorityQueue.Print();
    //        int highestPriority = priorityQueue.Dequeue();
    //        Console.WriteLine($"Dequeued Highest Priority Element: {highestPriority}");

    //        Console.WriteLine("Priority Queue after dequeuing highest priority element:");
    //        priorityQueue.PrintPriorityQueue();
    //    }
    //}



    class BinaryHeap
    {
        private int[] heap;
        private int size;

        public BinaryHeap()
        {
            heap = new int[120];
            size = 0;
        }

        public void Insert(int item)
        {
            if (size == heap.Length)
            {
                ResizeHeap();
            }

            heap[size] = item;
            size++;
            ShiftUp(size - 1);
        }

        public int Delete()
        {
            if (size == 0)
            {
                throw new Exception("Heap is empty");
            }

            int root = heap[0];
            heap[0] = heap[size - 1];
            size--;
            ShiftDown(0);
            return root;
        }

        private void ShiftUp(int index)
        {
            int parentIndex = (index - 1) / 2;
            while (parentIndex >= 0 && heap[parentIndex] < heap[index])
            {
                Swap(parentIndex, index);
                index = parentIndex;
                parentIndex = (index - 1) / 2;
            }
        }

        private void ShiftDown(int index)
        {
            while (true)
            {
                int leftChildIndex = 2 * index + 1;
                int rightChildIndex = 2 * index + 2;
                int largest = index;

                if (leftChildIndex < size && heap[leftChildIndex] > heap[largest])
                {
                    largest = leftChildIndex;
                }

                if (rightChildIndex < size && heap[rightChildIndex] > heap[largest])
                {
                    largest = rightChildIndex;
                }

                if (largest != index)
                {
                    Swap(largest, index);
                    index = largest;
                }
                else
                {
                    break;
                }
            }
        }

        private void Swap(int i, int j)
        {
            int temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }

        private void ResizeHeap()
        {
            int[] newHeap = new int[heap.Length * 2];
            Array.Copy(heap, newHeap, heap.Length);
            heap = newHeap;
        }



        public void Print()
        {
            if (size == 0)
            {
                Console.WriteLine("PriorityQueue is empty.");
                return;
            }

            PrintNode(0, "");
        }
        /// <summary> 
        /// Отрисовка дерева 
        /// </summary> 
        /// <param name="currentNode"></param> 
        /// <param name="indent"></param> 
        private void PrintNode(int index, string indent)
        {
            if (index < size)
            {
                Console.WriteLine(indent + heap[index]);

                int leftChildIndex = 2 * index + 1;
                int rightChildIndex = 2 * index + 2;

                if (leftChildIndex < size)
                {
                    Console.WriteLine(indent + "├── " + "Left Child:");
                    PrintNode(leftChildIndex, indent + "│   ");
                }

                if (rightChildIndex < size)
                {
                    Console.WriteLine(indent + "└── " + "Right Child:");
                    PrintNode(rightChildIndex, indent + "    ");
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            BinaryHeap binaryHeap = new BinaryHeap();
            int[] d = new int[] { 4, 8, 10, 20, 5, 6, 13, 12, 25, 15, 14, 0, 26, 9, 3, 1, 19, 2, 24, 28, 17, 23, 27, 7, 11, 29, 21, 30, 22, 18, 16 };


            foreach (int i in d)
            {
                binaryHeap.Insert(i);

            }
            //binaryHeap.Insert(2);
            //binaryHeap.Insert(3);
            //binaryHeap.Insert(5);
            //binaryHeap.Insert(7);
         
            Console.WriteLine("Root");
            binaryHeap.Print();
            binaryHeap.Delete();

            Console.ReadLine();
        }
    }
}