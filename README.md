# KD.Linq
---

Added LINQ methods
--


Replace At:
```csharp
var list = new List<int>() { 1, 2, 1, 3, 1, 4 };
Console.WriteLine(string.Join(", ", list));

// Replace value at index 1 to 9
var list2 = list.ReplaceAt(1, 9).ToList();
Console.WriteLine(string.Join(", ", list2));

// Replace value at index 2 to 567
var list3 = list2.ReplaceAt(2, 7).ToList();
Console.WriteLine(string.Join(", ", list3));
```
![](https://raw.githubusercontent.com/Sejoslaw/KD.Linq/master/img/ReplaceAt.PNG)


Replace Multiple:
```csharp
var list = new List<int>() { 1, 2, 1, 3, 1, 4 };
Console.WriteLine(string.Join(", ", list));

// Replace value at each index where value equals 1 to new value which is 9
var list2 = list.ReplaceMultiple(9, value => value == 1).ToList();
Console.WriteLine(string.Join(", ", list2));

// Replace value at each index where value equals 2 to new value which is 8
var list3 = list2.ReplaceMultiple(8, value => value == 2).ToList();
Console.WriteLine(string.Join(", ", list3));
```
![](https://raw.githubusercontent.com/Sejoslaw/KD.Linq/master/img/ReplaceMultiple.PNG)



For Each (generic):
```csharp
List<int> list = new List<int>() { 1, 2, 1, 3, 1, 4 };
// Standard ForEach which is include in List class
Console.WriteLine(string.Join(", ", list));

IEnumerable<int> enumerable = new int[] { 1, 2, 1, 3, 1, 4 };
// Generic ForEach made for any Enumerable
Console.WriteLine(string.Join(", ", enumerable));
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


Find:
```csharp
IEnumerable<int> list = new List<int>() { 1, 2, 3, 1, 2, 3, 1, 1 };
Console.WriteLine(string.Join(", ", list));

// Find all elements which are equal to 1
var ones = list.Find(1);
Console.Write(string.Join(", ", ones));
```
![](https://raw.githubusercontent.com/Sejoslaw/KD.Linq/master/img/Find.PNG)
