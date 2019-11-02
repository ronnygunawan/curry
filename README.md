[![NuGet](https://img.shields.io/nuget/v/RG.Curry.svg)](https://www.nuget.org/packages/RG.Curry/)

# Currying in C#

```cs
var func = Curry.From((int a, int b, int c) => a * b + c);
var curried = func[1];

var result1 = func[1, 2, 3];
var result2 = curried[2, 3];

Assert.AreEqual(result1, result2); // both are the same.
```
