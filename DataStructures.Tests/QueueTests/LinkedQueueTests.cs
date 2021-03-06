/*
Author: Jacob Chandler
File: LinkedQueueTests.cs
Version: 1.0.1
Description: This file contains NUnit test functionality for the LinkedQueue Data Structure class.
Date of Comment: 06:03:2018
 */

using System;
using DataStructures.Queues;
using NUnit.Framework;

namespace Tests.QueueTests {
    public class LinkedQueueTests {

        private LinkedQueue<string> LinkedQueue2;

        [SetUp]
        public void Setup() {
            LinkedQueue2 = new LinkedQueue<string>();
            LinkedQueue2.Enqueue("Phil");
            LinkedQueue2.Enqueue("Bob");
            LinkedQueue2.Enqueue("Marry");
            LinkedQueue2.Enqueue("Bobby");
        }

        [Test]
        public void GetFrontTest() {
            Assert.AreEqual("Phil", LinkedQueue2.GetFront());
        }

        [Test]
        public void DequeueTest() {
            Assert.AreEqual("Phil", LinkedQueue2.Dequeue());
        }

        [Test]
        public void DequeueTest2() {
            LinkedQueue2.Dequeue();
            Assert.AreEqual("Bob", LinkedQueue2.Dequeue());
        }

        [Test]
        public void EmptyTest() {
            LinkedQueue2.Empty();
            Assert.True(LinkedQueue2.IsEmpty());
        }

        [Test]
        public void EmptyQueuePopTestExc() {
            Assert.Throws<InvalidOperationException>(new TestDelegate(EmptyStackPopDel));
        }

        [Test]
        public void EmptyQueueEmptyTestExc() {
            Assert.Throws<InvalidOperationException>(new TestDelegate(EmptyStackEmptyDel));
        }

        private void EmptyStackEmptyDel() {
            LinkedQueue2.Empty();
            LinkedQueue2.Empty();
        }

        private void EmptyStackPopDel() {
            LinkedQueue2.Empty();
            LinkedQueue2.Dequeue();
        }
    }
}