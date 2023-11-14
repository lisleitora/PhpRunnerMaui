<img src="mauiphp.png" height="200">



# PhpRunnerMaui
Needs to consume PhpRunner service.

Inspired by:

https://github.com/pabloprogramador/phprunnerservice

Thanks daddy!


Here is my NuGet:

[![NuGet](https://img.shields.io/nuget/v/PhpRunnerMaui.svg?label=PhpRunnerMaui)](https://www.nuget.org/packages/PhpRunnerMaui/)


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
PhpRunnerMaui.Settings.ServerApi = "http://[YOUR SERVER PHPRUNNER]/api";

PhpRunnerMaui service = new PhpRunnerMaui();
```

## How to model

Example:
```csharp
using System.Text.Json.Serialization;
using static PhpRunnerMaui.Converters.JsonCustomConverters;

public class Users
{
    [JsonConverter(typeof(IntConverter))]
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}
```
