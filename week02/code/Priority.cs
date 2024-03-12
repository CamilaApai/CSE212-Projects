public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Items should be added to the queue. Then, the item with the highest priority should be removed and its value should be returned. The new queue should be displayed.
        // Expected Result: Queue: [Item 1 (Pri:22), Item 2 (Pri:6), Item 3 (Pri:31), Item 4 (Pri:31)] || Dequeued: Item 3 || New Queue: [Item 1 (Pri:22), Item 2 (Pri:6), Item 4 (Pri:31)]
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Item 1", 22);
        priorityQueue.Enqueue("Item 2", 6);
        priorityQueue.Enqueue("Item 3", 31);
        priorityQueue.Enqueue("Item 4", 31);
        Console.WriteLine($"Queue: {priorityQueue}");

        // Displays the item that was removed.
        Console.WriteLine($"Dequeued: {priorityQueue.Dequeue()}");
        Console.WriteLine($"New Queue: {priorityQueue}");

        // Defect(s) Found: The dequeue is not removing the item.

        Console.WriteLine("---------");


        // Test 2
        // Scenario: If the queue is empty, then an error message will be displayed.
        // Expected Result: Error message should be displayed.
        Console.WriteLine("Test 2");
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();

        // Defect(s) Found: The error message is not being displayed.

        Console.WriteLine("---------");
    }
}