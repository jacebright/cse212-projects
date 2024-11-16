using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Given the values in the order of priority, ensure they are dequeued in that order
    // This is testing the enqueue and dequeue functionalities.
    // Expected Result: "John", "Jacob", "Jingle", "Heimer", "Schmidt"
    // Defect(s) Found: The index was starting at 1 in the dequeue method, and was not removing the item
    public void TestPriorityQueue_PrioritiesInOrder()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("John", 5);
        priorityQueue.Enqueue("Jacob", 4);
        priorityQueue.Enqueue("Jingle", 3);
        priorityQueue.Enqueue("Heimer", 2);
        priorityQueue.Enqueue("Schmidt", 1);

        List<string> expected = ["John", "Jacob", "Jingle", "Heimer", "Schmidt"];


        for (int i = 0; i < 5; i++) {
            string result = priorityQueue.Dequeue();
            Assert.AreEqual(expected[i], result);
        }

    }

    [TestMethod]
    // Scenario: Enqueue the values in the incorrect order to confirm the highest priority is being used.
    // Expected Result: "John", "Jacob", "Jingle", "Heimer", "Schmidt"
    // Defect(s) Found: none
    public void TestPriorityQueue_PrioritiesOutOfOrder()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Schmidt", 1);
        priorityQueue.Enqueue("Jingle", 3);
        priorityQueue.Enqueue("John", 5);
        priorityQueue.Enqueue("Jacob", 4);
        priorityQueue.Enqueue("Heimer", 2);
        

        List<string> expected = ["John", "Jacob", "Jingle", "Heimer", "Schmidt"];


        for (int i = 0; i < 5; i++) {
            string result = priorityQueue.Dequeue();
            Assert.AreEqual(expected[i], result);
        }
    }

    [TestMethod]
    // Scenario: Enqueue the values with matching priorities to ensure the one with the lowest
    // index is being used.
    // Expected Result: "John", "Jacob", "Jingle", "Heimer", "Schmidt"
    // Defect(s) Found: The highest priority index was checking for greater than or equal to
    // instead of just greater than.
    public void TestPriorityQueue_EqualValuePriorities()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Schmidt", 1);
        priorityQueue.Enqueue("Jingle", 4);
        priorityQueue.Enqueue("John", 5);
        priorityQueue.Enqueue("Jacob", 5);
        priorityQueue.Enqueue("Heimer", 4);
        

        List<string> expected = ["John", "Jacob", "Jingle", "Heimer", "Schmidt"];


        for (int i = 0; i < 5; i++) {
            string result = priorityQueue.Dequeue();
            Assert.AreEqual(expected[i], result);
        }
    }

    [TestMethod]
    // Scenario: attempt to dequeue a value from an empty queue
    // Expected Result: invalid operation exception
    // Defect(s) Found: none
    public void TestPriorityQueue_ErrorCatching()
    {
        var priorityQueue = new PriorityQueue();
        
        Assert.ThrowsException<InvalidOperationException>( () => priorityQueue.Dequeue()); 
    }
}