// using System.Text.Json;

var names = new[] { "Nick", "John", "Mike", "Peter" };

var serialized = JsonSerializer.Serialize(names);

Console.WriteLine(serialized);