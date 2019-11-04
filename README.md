[![NuGet](https://img.shields.io/nuget/v/RG.Curry.svg)](https://www.nuget.org/packages/RG.Curry/)

# Currying in C#

```cs
Func<int, int, int, int> func = (a, b, c) => a * b + c;
var curried = func.Curry(1);

var result1 = func(1, 2, 3);
var result2 = curried(2, 3);
var result3 = func.Curry(1, 2)(3);
var result4 = func.Curry(1).Curry(2).Curry(3)();

// result1, result2, result3, and result4 all have the same value.
```

## Works on Action too

```cs
Action<string, object> writeLine = Console.WriteLine;
var writeHello = writeLine.Curry("Hello {0}");
writeHello("World");
```
