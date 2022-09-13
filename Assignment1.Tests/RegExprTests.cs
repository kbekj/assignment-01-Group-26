namespace Assignment1.Tests;

using Xunit;
using System.Reflection;

public class RegExprTests
{
    [Fact]
    public void SplitLine_splits_by_space_multiple_lines()
    {
        // Arrange
        var lines = new String[3]{"who are you?", "hello there", "i am 9 years old"};

        // Act
        var output = RegExpr.SplitLine(lines);
        // Assert
        Assert.Equal(new String[10]{"who", "are", "you?", "hello", "there", "i", "am", "9", "years", "old"}, output);
    }

    [Fact]
    public void Resolution_returns_1920_1080_given_1920x1080()
    {
        // Arrange
        var resolutions = "1920x1080, 720x420";
        var list = new List<(int,int)>{(1920, 1080), (720, 420)};
        // Act
        var output = RegExpr.Resolution(resolutions); 
        // Assert
        Assert.Equal(list, output);
    }

     [Fact]
    public void InnerText()
    {
        // Arrange
        string innerText = "<div> <p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=\"https://en.wikipedia.org/wiki/Theoretical_computer_science\" title=\"Theoretical computer science\">theoretical computer science</a> and <a href=\"https://en.wikipedia.org/wiki/Formal_language\" title=\"Formal language\">formal language</a> theory, a sequence of <a href=\"https://en.wikipedia.org/wiki/Character_(computing)\" title=\"Character (computing)\">characters</a> that define a <i>search <a href=\"https://en.wikipedia.org/wiki/Pattern_matching\" title=\"Pattern matching\">pattern</a></i>. Usually this pattern is then used by <a href=\"https://en.wikipedia.org/wiki/String_searching_algorithm\" title=\"String searching algorithm\">string searching algorithms</a> for \"find\" or \"find and replace\" operations on <a href=\"https://en.wikipedia.org/wiki/String_(computer_science)\" title=\"String (computer science)\">strings</a>.</p> </div>";
        // Act
        var output = RegExpr.InnerText(innerText, "a"); 
        // Assert
        Assert.Equal(new List<string>{"theoretical computer science", "formal language", "characters", "pattern", "string searching algorithms", "strings"}, output);
    }
}