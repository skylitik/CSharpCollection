using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace QueueStackTest
{
    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void QueueUsePeek()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            //Arrange

            //Act

            //Assert
            Assert.AreEqual(1, queue.Peek());
        }
        [TestMethod]
        public void QueueUseContains()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            //Arrange

            //Act

            //Assert
            Assert.IsTrue(queue.Contains(3));
        }
        [TestMethod]
        public void QueueUseToArray()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            //Arrange
            var array = queue.ToArray();
            queue.Dequeue();
            //Act

            //Assert
            Assert.AreEqual(1, array[0]);
            Assert.AreEqual(6, array.Length);
            Assert.AreEqual(5, queue.Count);
        }
    }
}
