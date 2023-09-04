namespace WebIdentifiers.Html.UnitTests.HtmlAttributeTests;

[TestClass]
public class EqualsShould
{
    [TestMethod]
    public void ReturnFalseGivenOtherIsNotHtmlAttribute()
    {
        var attribute = new HtmlAttribute("type");

        var result = attribute.Equals(1);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void ReturnFalseGivenOtherIsNull()
    {
        var attribute = new HtmlAttribute("type");

        var result = attribute.Equals(null);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void ReturnFalseGivenOtherNameIsNotEqual()
    {
        var attribute = new HtmlAttribute("type");
        var other = new HtmlAttribute("name");

        var result = attribute.Equals(other);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void ReturnFalseGivenOtherValueIsNotEqual()
    {
        var attribute = new HtmlAttribute("type", "button");
        var other = new HtmlAttribute("type", "submit");

        var result = attribute.Equals(other);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void ReturnTrueGivenOtherIsStringWithMatchingName()
    {
        var attribute = new HtmlAttribute("type");

        var result = attribute.Equals("type");

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void ReturnTrueGivenOtherIsStringWithMatchingNameAndValue()
    {
        var attribute = new HtmlAttribute("type", "button");

        var result = attribute.Equals("type=\"button\"");

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void ReturnTrueGivenOtherNameAndValueAreEqual()
    {
        var attribute = new HtmlAttribute("type", "button");
        var other = new HtmlAttribute("type", "button");

        var result = attribute.Equals(other);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void ReturnTrueGivenOtherNameIsEqualAndValueIsNull()
    {
        var attribute = new HtmlAttribute("type");
        var other = new HtmlAttribute("type");

        var result = attribute.Equals(other);

        Assert.IsTrue(result);
    }
}