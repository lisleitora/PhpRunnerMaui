# PhpRunnerMaui
Needs to consume PhpRunner service.

Inspired by:
https://github.com/pabloprogramador/phprunnerservice

## How to use
```csharp
// Users = name of table
// get user id = 1
Users user = await service.Get<Users>(1);
Console.WriteLine(user.Name);
```

## More options
```csharp
service.Get
service.List
service.Search
service.Delete
service.Insert
service.Update
```

## How to set
```csharp
PhpRunnerService.Settings.ServerApi = "http://[YOUR SERVER PHPRUNNER]/api";

PhpRunnerService service = new PhpRunnerService();
```

## How to model

Example:
```csharp
using System.Text.Json.Serialization;
using static PhpRunnerService.Converters.JsonCustomConverters;

public class Users
{
    [JsonConverter(typeof(IntConverter))]
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}
```
