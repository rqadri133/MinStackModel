using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinStackModel;
namespace MinStackUnitTest
{
    [TestClass]
    public class MinStackUnitTest
    {
        [TestMethod]
        public void CheckMin()
        {

            MinStack minStack = new MinStack();
            minStack.push(-2);
            minStack.push(0);
            minStack.push(-3);
            minStack.getMin(); // return -3
            minStack.pop();
            minStack.top();    // return 0
            Assert.AreEqual( -2, minStack.getMin()); // return -2


        }

        [TestMethod]
        public void CheckPush()
        {
            MinStack minStack = new MinStack();
            minStack.push(-2);
            minStack.push(0);
            minStack.push(-3);
               // return 0
            Assert.AreEqual(-3, minStack.top()); // return -2



        }


        [TestMethod]
        public void CheckPop()
        {
            MinStack minStack = new MinStack();
            minStack.push(-2);
            minStack.push(0);
            minStack.push(-3);
            minStack.pop();
            // return 0
            Assert.AreEqual(0, minStack.top()); // return -2



        }
        [TestMethod]
        public void CheckEmpty()
        {
            MinStack minStack = new MinStack();
            minStack.push(-2);
            minStack.push(0);
            minStack.pop();

            minStack.pop();
            // return 0
            Assert.AreEqual(0, minStack.top()); // return -2



        }

    }
}
