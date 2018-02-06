using Xunit;

namespace CCLibrary.Tests
{
    public class StackTest
    {
        [Fact]
        public void Stack_One_Item_Is_Pushed()
        {
            var stack = new Stack();

            stack.Push("Item");

            Assert.Equal(stack.Count(), 1);
        }

        [Fact]
        public void TwoItemIsPushed()
        {
            var stack = new Stack();

            stack.Push("Item");
            stack.Push(1);

            Assert.Equal(stack.Count(), 2);
        }

        [Fact]
        public void EmpyStackThrowsException()
        {
            var stack = new Stack();

            Assert.Throws(typeof(System.Exception),stack.Pop);
        }

        [Fact]
        public void Stack_One_item_is_popped()
        {
            var stack = new Stack();
            stack.Push(1);

            stack.Pop();

            Assert.Equal(stack.Count(), 0);
        }

        [Fact]
        public void Stack_Two_items_are_popped()
        {
            var stack = new Stack();
            stack.Push("item1");
            stack.Push(2);

            stack.Pop();
            stack.Pop();

            Assert.Equal(stack.Count(), 0);
        }

        [Fact]
        public void Stack_Same_item_is_pushed_and_popped()
        {
            var stack = new Stack();
            var expectedItem = "item1";
            stack.Push(expectedItem);
            var actualItem = stack.Pop();

            Assert.Equal(expectedItem, actualItem);
        }

        [Fact]
        public void Stack_check_item_order()
        {
            var stack = new Stack();
            var expectedItem1 = "item1";
            var expectedItem2 = 2;

            stack.Push(expectedItem1);
            stack.Push(expectedItem2);

            Assert.Equal(expectedItem2, stack.Pop());
            Assert.Equal(expectedItem1, stack.Pop());
        }

    }
}
