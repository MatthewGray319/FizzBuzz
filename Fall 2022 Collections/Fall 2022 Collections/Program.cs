// Collections

// Arrays
// fixed size, and of a particular type
// indexed at 0

var students = new string[13]; //creates an empty array with 13 slots to fill
var instructors = new string[] { "Davis" , "Gavin", "El", "Rickie", "Cliff" };
// because there are 5 things listed, the array's length is 5

// variable = new type [] {comma separated values;
// In C# an array's length and type cannot change.

// Change the value at a slot in an array
// name = value;
// array[index] = value;
students[7] = "Ashley";
// student at index seven is updated to say "Ashley"
// student at index seven is the 8th student
// first thing in the list is arrray[0]
//last thing is the list --> array[length - 1]
Console.WriteLine(students.Length);

// Lists
// Dynamic size, still must be of one type
// indexed at zero

var groceries = new List<string>(); // sets up our new list, starting with no values, its count is 0
groceries.Add("Pizza"); // our list contains 1 item, index = 0
groceries.Add("Bananas"); // our list contains 2 items (banana has an index of 1)'
groceries.Add("Grapes");
groceries.Add("Potatoes");

// Remove items from an array
// list.Remove(item to remove);
groceries.Remove("Bananas");
Console.WriteLine(groceries.Count);
Console.WriteLine(groceries[1]);

// Remove at --> gives index to remove
groceries.RemoveAt(1);

groceries.Insert(1, "Bananas");  // shift items after this index up by 1, adds bananas to the list
Console.WriteLine(groceries.Count);
Console.WriteLine(groceries[1]);



// How do we print out this list ???

// Foreach Loops
// Loops that run once for each item in a collection
// rather than specifically having an index like previous loops, we have an object that we can look at and engage with
// foreach(type item in collection)
// {
// code to execute
// }
foreach (var grocery in groceries)
{
    Console.WriteLine(grocery);
}

// Sometimes it's nice to have access to the index of a particular item as well as the item itself.
// Use a for loop
// Remember for an array the length is array.Length for a list it's list.count

for (var i = 0; i < instructors.Length; i++)
{
    Console.WriteLine(instructors[i]);
}

// instructors[i] in a for loop is the same as the var instructor in a foreach loop

// Dictionaries
// Collection of key value pairs
// keys - how we access elements
// values - the values we get in return

var weather = new Dictionary<string, float>();
weather["Atlanta"] = 82.3f; // key is Atlanta, value is 82.3f
weather["Cleveland"] = 71f;
Console.WriteLine(weather["Atlanta"]);

Console.WriteLine(weather.Count);


// We have weather.add, weather.remove, and everything else

foreach (var report in weather)
{
    Console.WriteLine(report);
}

foreach (var report in weather)
{
    Console.WriteLine("Temperature = " + report.Value);
    Console.WriteLine("Location = " + report.Key);
}

// report is a key value pair object, meaning we have access to both the keys and values as we go through each item in our weather dictionary