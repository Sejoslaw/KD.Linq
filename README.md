# KD.Linq
---

Added LINQ methods
--


Find:
```csharp
IEnumerable<int> list = new List<int>() { 1, 2, 3, 1, 2, 3, 1, 1 };
Console.WriteLine(string.Join(", ", list));

// Find all elements which are equal to 1
List<int> ones = list.Find(1);
Console.Write(string.Join(", ", ones));
```
![](https://raw.githubusercontent.com/Sejoslaw/KD.Linq/master/img/Find.PNG)


For Each (generic):
```csharp
List<int> list = new List<int>() { 1, 2, 1, 3, 1, 4 };
// Standard ForEach which is include in List class
list.ForEach(value => Console.Write(value + ", "));

Console.WriteLine();

// Generic ForEach made for any Enumerable - Action Version
IEnumerable<int> enumerable = new int[] { 1, 2, 1, 3, 1, 4 };
enumerable.ForEach(value => Console.Write(value + ", ")).ToList();

Console.WriteLine();

// Generic ForEach made for any Enumerable - Function Version
IEnumerable<int> enumerable2 = enumerable.ForEach(value => { return value + 1; }).ToList();
enumerable2.ForEach(value => Console.Write(value + ", ")).ToList();
```
![](https://raw.githubusercontent.com/Sejoslaw/KD.Linq/master/img/ForEach2.PNG)


Index Of:
```csharp
Element el1 = new Element() { Value = 1 };
Element el2 = new Element() { Value = 2 };
Element el3 = new Element() { Value = 3 };
Element el4 = new Element() { Value = 4 };

IEnumerable<Element> list = new List<Element>() { el1, el2, el3, el4 };
// Get index of el3 object in current Enumerable
int index = list.IndexOf(el3);

Console.WriteLine("Index = " + index);
```
![](https://raw.githubusercontent.com/Sejoslaw/KD.Linq/master/img/IndexOf.PNG)


IsEmpty:
```csharp
IEnumerable<int> list1 = new List<int> { 1, 2, 3 };
Console.WriteLine($"List1 is empty: { list1.IsEmpty() }");

IEnumerable<int> list2 = new List<int> { };
Console.WriteLine($"List2 is empty: { list2.IsEmpty() }");
```
![](https://raw.githubusercontent.com/Sejoslaw/KD.Linq/master/img/IsEmpty.PNG)


Replace At:
```csharp
List<int> list = new List<int>() { 1, 2, 1, 3, 1, 4 };
Console.WriteLine(string.Join(", ", list));

// Replace value at index 1 to 9
List<int> list2 = list.ReplaceAt(1, 9).ToList();
Console.WriteLine(string.Join(", ", list2));

// Replace value at index 2 to 567
List<int> list3 = list2.ReplaceAt(2, 567).ToList();
Console.WriteLine(string.Join(", ", list3));
```
![](https://raw.githubusercontent.com/Sejoslaw/KD.Linq/master/img/ReplaceAt.PNG)


Replace Multiple:
```csharp
List<int> list = new List<int>() { 1, 2, 1, 3, 1, 4 };
Console.WriteLine(string.Join(", ", list));

// Replace value at each index where value equals 1 to new value which is 9
List<int> list2 = list.ReplaceMultiple(9, value => value == 1).ToList();
Console.WriteLine(string.Join(", ", list2));

// Replace value at each index where value equals 2 to new value which is 8
List<int> list3 = list2.ReplaceMultiple(8, value => value == 2).ToList();
Console.WriteLine(string.Join(", ", list3));
```
![](https://raw.githubusercontent.com/Sejoslaw/KD.Linq/master/img/ReplaceMultiple.PNG)
