using DataStructuresAlgorithms;
using Xunit;

public class StackTest
{
    [Fact]
    public void PushPopTest()
    {
        var stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        Assert.Equal(2, stack.Pop());
        Assert.Equal(1, stack.Pop());
    }
}