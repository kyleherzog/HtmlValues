namespace WebIdentifiers.Html.UnitTests.HtmlAttributeTests;

[TestClass]
public class ToStringShould
{
    [TestMethod]
    public void ReturnNameAndEncodedValueGivenValueContainsDoubleQuote()
    {
        var attribute = new MarkupAttribute("type", "\"button\"");

        var result = attribute.ToString();

        Assert.AreEqual("type=\"&quot;button&quot;\"", result);
    }

    [TestMethod]
    public void ReturnNameAndValueGivenValueIsNotNull()
    {
        var attribute = new MarkupAttribute("type", "button");

        var result = attribute.ToString();

        Assert.AreEqual("type=\"button\"", result);
    }

    [TestMethod]
    public void ReturnNameGivenValueIsEmpty()
    {
        var attribute = new MarkupAttribute("type", string.Empty);

        var result = attribute.ToString();

        Assert.AreEqual("type", result);
    }

    [TestMethod]
    public void ReturnNameGivenValueIsNull()
    {
        var attribute = new MarkupAttribute("type");

        var result = attribute.ToString();

        Assert.AreEqual("type", result);
    }

    [TestMethod]
    public void ThrowArgumentExceptionGivenNameIsEmpty()
    {
        Assert.ThrowsException<ArgumentException>(() => new MarkupAttribute(string.Empty));
    }

    [TestMethod]
    public void ThrowArgumentExceptionGivenNameIsWhiteSpace()
    {
        Assert.ThrowsException<ArgumentException>(() => new MarkupAttribute(" "));
    }

    [TestMethod]
    public void ThrowArgumentNullExceptionGivenNameIsNull()
    {
        Assert.ThrowsException<ArgumentNullException>(() => new MarkupAttribute(null!));
    }

    [TestMethod]
    public void ThrowArgumentNullExceptionGivenNameIsNullAndValueIsNotNull()
    {
        Assert.ThrowsException<ArgumentNullException>(() => new MarkupAttribute(null!, "button"));
    }

    [TestMethod]
    public void ThrowArgumentNullExceptionGivenNameIsNullAndValueIsNull()
    {
        Assert.ThrowsException<ArgumentNullException>(() => new MarkupAttribute(null!, null!));
    }

    [TestMethod]
    public void ThrowArgumentNullExceptionGivenNameIsNullAndValueIsWhiteSpace()
    {
        Assert.ThrowsException<ArgumentNullException>(() => new MarkupAttribute(null!, " "));
    }
}