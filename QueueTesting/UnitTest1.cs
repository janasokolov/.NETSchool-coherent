namespace QueueTesting;

using Queue;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void EnqueueDequeueTesting()
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        Assert.AreEqual(1, queue.Dequeue());
    }

    [TestMethod]
    public void isEmptyTesting()
    {
        Queue<int> queue = new Queue<int>();
        Assert.IsTrue(queue.IsEmpty());
    }

    [TestMethod]
    public void TailTesting()
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        IQueue<int> newQueue = queue.Tail();
        Assert.AreEqual(2, newQueue.Dequeue());
    }



}