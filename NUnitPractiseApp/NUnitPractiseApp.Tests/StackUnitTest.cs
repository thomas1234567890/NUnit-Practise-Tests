using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace NUnitPractiseApp.Tests
{
    [TestFixture]
    public class StackUnitTest
    {
        [Test]
        public void Push_WhenObjectPassedIsNull_ThrowArgumentNullException()
        {
            ///arange
            var stack = new Stack<string>();
            ///assert
            Assert.That(() => stack.Push(null), Throws.Exception.TypeOf<ArgumentNullException>());
        }


        [Test]
        public void Push_WhenObjectPassed_AddObjectToStack()
        {
            ///arange
            var stack = new Stack<string>();
            
            ///act
            stack.Push("TestA");
            
            ///assert
            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            ///arange
            var stack = new Stack<string>();
            ///assert
            Assert.That(stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop_WhenListCountIsZero_ThrowInvalidOperationException()
        {
            ///arange
            var stack = new Stack<string>();

            ///assert
            Assert.That(() => stack.Pop(), Throws.Exception.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Pop_WhenCalled_RemoveTheObjectOnTopOfTheStackAndReturnTheObjectRemoved()
        {
            ///arange
            var stack = new Stack<string>();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");

            ///act
            var result = stack.Pop();
            ///assert
            Assert.That(result, Is.EqualTo("C"));
        }

        [Test]
        public void Pop_WhenCalled_CountStackIsAccurate()
        {
            ///arange
            var stack = new Stack<string>();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");

            ///act
            stack.Pop();
            ///assert
            Assert.That(stack.Count, Is.EqualTo(2));
        }


        [Test]
        [Ignore("Not Implemented Yet")]
        public void Peek_WhenListCountIsZero_ThrowInvalidOperationException()
        {
            var stack = new Stack<string>();
        }

        [Test]
        public void Peek_WhenCalled_ReturnTheObjectOnTopOfTheStack ()
        {
        }



    }
}
