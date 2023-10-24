namespace Lost.Threading;

using System;

using Xunit;

public class OnceTests {
    [Fact]
    public void Initial_NotOccurred() {
        var once = new Once();
        Assert.False(once.HasOccurred);
    }

    [Fact]
    public void MarkOccurred_Occurred() {
        var once = new Once();
        once.MarkOccurred();
        Assert.True(once.HasOccurred);
    }

    [Fact]
    public void MarkOccurred_Twice() {
        var once = new Once();
        once.MarkOccurred();
        Assert.Throws<InvalidOperationException>(() => once.MarkOccurred());
        Assert.True(once.HasOccurred);
    }

    [Fact]
    public void TryMarkOccurred_Occurred() {
        var once = new Once();
        Assert.True(once.TryMarkOccurred());
        Assert.True(once.HasOccurred);
    }

    [Fact]
    public void TryMarkOccurred_Twice() {
        var once = new Once();
        Assert.True(once.TryMarkOccurred());
        Assert.False(once.TryMarkOccurred());
        Assert.True(once.HasOccurred);
    }
}
