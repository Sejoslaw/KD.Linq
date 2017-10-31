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



For Each (generic):
```csharp
List<int> list = new List<int>() { 1, 2, 1, 3, 1, 4 };
// Standard ForEach which is include in List class
list.ForEach(value => Console.Write(value + ", "));

Console.WriteLine();

IEnumerable<int> enumerable = new int[] { 1, 2, 1, 3, 1, 4 };
// Generic ForEach made for any Enumerable
enumerable.ForEach(value => Console.Write(value + ", ")).ToList();
```
![](https://raw.githubusercontent.com/Sejoslaw/KD.Linq/master/img/ForEach.PNG)



Index Of:
```csharp
var el1 = new Element() { Value = 1 };
var el2 = new Element() { Value = 2 };
var el3 = new Element() { Value = 3 };
var el4 = new Element() { Value = 4 };

IEnumerable<Element> list = new List<Element>() { el1, el2, el3, el4 };
// Get index of el3 object in current Enumerable
var index = list.IndexOf(el3);

Console.WriteLine("Index = " + index);
```
![](https://raw.githubusercontent.com/Sejoslaw/KD.Linq/master/img/IndexOf.PNG)
