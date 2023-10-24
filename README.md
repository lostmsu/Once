[![NuGet](https://img.shields.io/nuget/v/Once.svg)](https://www.nuget.org/packages/Once/)

A simple struct, that tracks if an event has occurred in a thread-safe manner.

```csharp
var once = new Once();

...

if (!once.TryMarkOccurred())
{
    return "Event already occurred";
}

DoAnOperationThatMustOnlyHappenOnce();

return "Event occurred";
```
