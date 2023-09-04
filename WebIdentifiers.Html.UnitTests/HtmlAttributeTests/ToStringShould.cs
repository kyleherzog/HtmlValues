namespace WebIdentifiers.Html.UnitTests.HtmlAttributeTests;

[TestClass]
public class ToStringShould
{
    [TestMethod]
    public void ReturnNameAndEncodedValueGivenValueContainsDoubleQuote()
    {
        var attribute = new HtmlAttribute("type", "\"button\"");

        var result = attribute.ToString();

        Assert.AreEqual("type=\"&quot;button&quot;\"", result);
    }

    [TestMethod]
    public void ReturnNameAndValueGivenValueIsNotNull()
    {
        var attribute = new HtmlAttribute("type", "button");

        var result = attribute.ToString();

        Assert.AreEqual("type=\"button\"", result);
    }

    [TestMethod]
    public void ReturnNameGivenValueIsEmpty()
    {
        var attribute = new HtmlAttribute("type", string.Empty);

        var result = attribute.ToString();

        Assert.AreEqual("type", result);
    }

    [TestMethod]
    public void ReturnNameGivenValueIsNull()
    {
        var attribute = new HtmlAttribute("type");

        var result = attribute.ToString();

        Assert.AreEqual("type", result);
    }

    [TestMethod]
    public void ThrowArgumentExceptionGivenNameIsEmpty()
    {
        Assert.ThrowsException<ArgumentException>(() => new HtmlAttribute(string.Empty));
    }

    [TestMethod]
    public void ThrowArgumentExceptionGivenNameIsWhiteSpace()
    {
        Assert.ThrowsException<ArgumentException>(() => new HtmlAttribute(" "));
    }

    [TestMethod]
    public void ThrowArgumentNullExceptionGivenNameIsNull()
    {
        Assert.ThrowsException<ArgumentNullException>(() => new HtmlAttribute(null!));
    }

    [TestMethod]
    public void ThrowArgumentNullExceptionGivenNameIsNullAndValueIsNotNull()
    {
        Assert.ThrowsException<ArgumentNullException>(() => new HtmlAttribute(null!, "button"));
    }

    [TestMethod]
    public void ThrowArgumentNullExceptionGivenNameIsNullAndValueIsNull()
    {
        Assert.ThrowsException<ArgumentNullException>(() => new HtmlAttribute(null!, null!));
    }

    [TestMethod]
    public void ThrowArgumentNullExceptionGivenNameIsNullAndValueIsWhiteSpace()
    {
        Assert.ThrowsException<ArgumentNullException>(() => new HtmlAttribute(null!, " "));
    }
}