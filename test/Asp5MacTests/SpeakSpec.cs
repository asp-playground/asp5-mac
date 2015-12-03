using Asp5Mac.Controllers;
using Xunit;

public class SpeakSpec {

    [Fact]
    public void ShouldSayHello() {
            var speak = new SpeakController();
            var message = speak.Hello();
            Assert.True(message == "Hello, world!");
    }
}