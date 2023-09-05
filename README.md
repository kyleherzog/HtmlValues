# WebIdentifiers.Html
Provides constant definitions for identifiers used in HTML including tags and attributes.

![Nuget](https://img.shields.io/nuget/v/WebIdentifiers.Html)

[![Build Status](https://dev.azure.com/kyleherzog/WebIdentifiers/_apis/build/status%2FWebIdentifiers.Html?branchName=main)](https://dev.azure.com/kyleherzog/WebIdentifiers/_build/latest?definitionId=25&branchName=main)

## Overview
This package provides the string values for various HTML identifiers.

### HtmlTags
The `HtmlTags` static class provides constant values for HTML tag names. 

```csharp
var tag = $"<{HtmlTags.Div}>";
Console.WriteLine(tag); // output: <div>
```

### HtmlAttributes
The `HtmlAttributes' static class provides access to individual HtmlAttribute objects.

```csharp
var idAttribute = $"{HtmlAttributes.Id()}='1234'";
Console.WriteLine(idAttribute); // output: id="1234"
```

Optionally a value can be provided to the attribute. The value will be escaped as needed.

```csharp
var idAttribute = HtmlAttributes.Id("1234")";
Console.WriteLine(idAttribute); // output: id="1234"
```
```

Attributes that are known to be valid for various HTML tags also made available 
though static read only "For" members.

```csharp
var attribute = HtmlAttributes.ForImg.Alt("dog")";
Console.WriteLine(attribute); // output: alt="dog"
```

### HtmlAttributeValues
Predefined HTML attribute values can be accessed via the `HtmlAttributeValues` static class.

```csharp
var attribute = $"method='{HtmlAttributeValues.Post}'";
Console.WriteLine(attribute); // output: method='post'
```

"For" static members also are made available on the `HtmlAttributeValues` class.  These members provide known predefined values for a specific attribute.
```csharp
var attribute = $"method='{HtmlAttributeValues.ForMethod.Post}";
Console.WriteLine(attribute); // output: method='post'
```