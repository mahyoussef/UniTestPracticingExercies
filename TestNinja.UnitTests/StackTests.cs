using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{   
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void PushMethod_ArgumentIsNull_ThrowsArgumentNullException()
        {
            var stack = new Fundamentals.Stack<string>();

            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }
        [Test]
        public void PushMethod_ValidArgument_AddTheObjectToTheStack()
        {
            var stack = new Fundamentals.Stack<string>();

            stack.Push("a");

            Assert.That(stack.Count, Is.EqualTo(1));
        }
        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            var stack = new Fundamentals.Stack<string>();

            Assert.That(stack.Count, Is.EqualTo(0));
        }
        [Test]
        public void PopMethod_EmptyStack_ThrowsInvalidOperationException()
        {
            var stack = new Fundamentals.Stack<string>();

            Assert.That(() => stack.Pop(), Throws.Exception.TypeOf<InvalidOperationException>());
        }
        [Test]
        public void PopMethod_FewObjects_ReturnTheObjectOnTop()
        {
            var stack = new Fundamentals.Stack<string>();

            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var result = stack.Pop();

            Assert.That(result, Is.EqualTo("c"));
        }
        [Test]
        public void PopMethod_FewObjects_RemoveThisObjectFromTop()
        {
            var stack = new Fundamentals.Stack<string>();

            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var result = stack.Pop();

            Assert.That(stack.Count, Is.EqualTo(2));
        }
        [Test]
        public void PeekMethod_EmptyStack_ThrowsInvalidOperationException()
        {
            var stack = new Fundamentals.Stack<string>();

            Assert.That(() => stack.Peek(), Throws.Exception.TypeOf<InvalidOperationException>());
        }
        [Test]
        public void PeekMethod_WhenCalled_ReturnLastElementInStack()
        {
            var stack = new Fundamentals.Stack<string>();

            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var result = stack.Peek();

            Assert.That(result, Is.EqualTo("c"));
        }
        [Test]
        public void PeekMethod_WhenCalled_DoesNotRemoveTheObject()
        {
            var stack = new Fundamentals.Stack<string>();

            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var result = stack.Peek();

            Assert.That(stack.Count, Is.EqualTo(3));
        }
    }
}
