# Uri/Url Helper

This is a helper library for dealing with Urls and Query Strings, as both are common place when working with the web.

Builder methods over using properties:

```csharp
new UrlBuilder()
    .WithScheme(Uri.UriSchemeHttps)
    .WithHost("github.com")
    .WithPath("GStefanowich", "url-extensions")
    .WithQuery(new Dictionary<string, string> {
        ["test"] = DateTimeOffset.UtcNow.ToString()
    });
```
