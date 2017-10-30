# KD.Linq
---

Added LINQ methods
--


Replace At:
```csharp
IEnumerable<int> list = new List<int>() { 1, 2, 3, 4 };
list.ToList().ForEach(model => Console.Write(model + ", "));

Console.WriteLine();

// Replace value at index 1 to 9
var list2 = list.ReplaceAt(1, 9).ToList();
list2.ToList().ForEach(model => Console.Write(model + ", "));

Console.WriteLine();

// Replace value at index 2 to 567
var list3 = list2.ReplaceAt(2, 567).ToList();
list3.ToList().ForEach(model => Console.Write(model + ", "));
```
![](https://raw.githubusercontent.com/Sejoslaw/KD.Linq/master/img/ReplaceAt.PNG)
