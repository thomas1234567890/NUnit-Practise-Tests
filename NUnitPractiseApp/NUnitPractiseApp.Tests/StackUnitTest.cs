using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace NUnitPractiseApp.Tests
{
    [TestFixture]
    public class StackUnitTest
    {
        ///Setup
        private Stack<string> _stack;
        [SetUp]
        public void Setup()
        {
            _stack = new Stack<string>();
        }

        [Test]
        public void Push_WhenObjectPassedIsNull_ThrowArgumentNullException()
        {
            ///assert
            Assert.That(() => _stack.Push(null), Throws.Exception.TypeOf<ArgumentNullException>());
        }


        [Test]
        public void Push_WhenObjectPassed_AddObjectToStack()
        {
            
            ///act
            _stack.Push("TestA");
            
            ///assert
            Assert.That(_stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            ///assert
            Assert.That(_stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop_WhenListCountIsZero_ThrowInvalidOperationException()
        {
            ///assert
            Assert.That(() => _stack.Pop(), Throws.Exception.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Pop_WhenCalled_RemoveTheObjectOnTopOfTheStackAndReturnTheObjectRemoved()
        {
            ///arange
            _stack.Push("A");
            _stack.Push("B");
            _stack.Push("C");

            ///act
            var result = _stack.Pop();
            ///assert
            Assert.That(result, Is.EqualTo("C"));
        }

        [Test]
        public void Pop_WhenCalled_CountStackIsAccurate()
        {
            ///arange
            _stack.Push("A");
            _stack.Push("B");
            _stack.Push("C");

            ///act
            _stack.Pop();
            ///assert
            Assert.That(_stack.Count, Is.EqualTo(2));
        }


        [Test]        
        public void Peek_WhenListCountIsZero_ThrowInvalidOperationException()
        {
            ///assert
            Assert.That(() => _stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_WhenCalled_ReturnTheObjectOnTopOfTheStack ()
        {
            ///arange
            _stack.Push("A");
            _stack.Push("B");

            ///act
            var result = _stack.Peek();

            ///assert
            Assert.That(result, Is.EqualTo("B"));
        }



    }
}
