# KD.Linq
---

Added LINQ methods
--


Replace At:
```csharp
var list = new List<int>() { 1, 2, 3, 4 };
list.ForEach(model => Console.Write(model + ", "));

Console.WriteLine();

// Replace value at index 1 to 9
var list2 = list.ReplaceAt(1, 9).ToList();
list2.ForEach(model => Console.Write(model + ", "));

Console.WriteLine();

// Replace value at index 2 to 567
var list3 = list2.ReplaceAt(2, 567).ToList();
list3.ForEach(model => Console.Write(model + ", "));
```
![](https://raw.githubusercontent.com/Sejoslaw/KD.Linq/master/img/ReplaceAt.PNG)


Replace Multiple:
```csharp
var list = new List<int>() { 1, 2, 1, 3, 1, 4 };
list.ForEach(value => Console.Write(value + ", "));

Console.WriteLine();

// Replace value at each index where value equals 1 to new value which is 9
var list2 = list.ReplaceMultiple(9, value => value == 1).ToList();
list2.ForEach(value => Console.Write(value + ", "));

Console.WriteLine();

// Replace value at each index where value equals 2 to new value which is 8
var list3 = list2.ReplaceMultiple(8, value => value == 2).ToList();
list3.ForEach(value => Console.Write(value + ", "));
```
![](https://raw.githubusercontent.com/Sejoslaw/KD.Linq/master/img/ReplaceMultiple.PNG)
