# Object orientated principle
abstraction - cell phone/car: interact with few buttons but stuff under hood is hiden from u.  
encapsulation - privacy: dont want boss to know gone on holiday. But simple as bank balance. ETP: Client is basically one big encapsulation of data so interact through ui. Imagine anyone just writing to db  
inheritance - Parent. Children inherit it  
polymorphism - https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/polymorphism. virtual methods. subclass implements in own way.  

Overriding vs overloading

# Solid:
https://en.wikipedia.org/wiki/SOLID  
S  - Single responsiblity principle  
O  - Open/Close principle  
L  - Listov principle  
I  - Interface segregation  
D  - Dependency Inversion  



# Datatypes
- List  
- Array  
- Dict  
- String  


				
Array/Array List
Linked List


# Basics

# Fundamentals - data structures (list, array, dicts)
Today we will cover the core of every programing language: Data types, control statements and looping. This is common to most programming languages

## Basics
1. OO language - basically means everything must be an object
2. Strongly typed 



## Data types
### 'Primtives'
- String
- int, double, decimal, This explains why decimal is more accurate [here](https://betterprogramming.pub/why-is-0-1-0-2-not-equal-to-0-3-in-most-programming-languages-99432310d476)
- boolean
```cs
string str = "string";
int value = 10; // integer/whole numbers
bool test = true; // false
double number = 0.1; // decimal points. Can add a d at end (1.1d) but not necessary. 64 bits
float floatingPointNo = 0.1f; // notice f at end- 32 bits smaller
decimal theDecimal = 0.1m; // notice m at end. Base 10 system so more accurate for financials
```

### Data structures
- Array: Collection of objects. Must be all same type. Cant change size once created
```cs
var arr = new string[3];
arr[0] = "a";
arr[1] = "b";
arr[2] = "c";
arr[0] = "replace a with b";
//arr[3] = "This throws an error because of the size";


// this is the shorthand
var items = new string[] {"Hello", "World", "People"};
```
- List: Array but can add more items
```cs
var myList = new List<string>();
myList.Add("Hello");
myList.Add("World");
myList.Add("People");
// Equivalent to 
var myOtherList = new List<string>() { "Hello", "World", "People" };
```

```cs
// set value for list/array 
myList[0] = "Replace Hello with this";
// get value 
myList[0];
```
- Dictionary - Key to value mapping
```cs
var dictionary = new Dictionary<string, string>();
dictionary.Add("David", "Nigeria");
dictionary.Add("Tom", "England");
dictionary.Add("Jin", "China");
Console.WriteLine(dictionary["David"]); // Nigeria
```

Dictionaries are a generic collection. Like lists, they are dynamic and resize accordingly.
Unlike lists though, data can be retieved using a key:value pair so you don't need to remember or find an index.

### How dictionary works
It achieves this through the process of hashing the key (behind the scenes this the return value of the .[GetHashCode](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-6.0) method). 
This means that each key is stored as a unique integer, and when called using it's key value, for example the string "David", it's able to fetch that value directly utilising it's key - as opposed to searching each entry for a match, like it would when using a List.

In the occurance of two hash results being the same, called a collision, the C# Dictionary will take care of this itself behind the scenes.

![Hash Example](https://upload.wikimedia.org/wikipedia/commons/thumb/7/7d/Hash_table_3_1_1_0_1_0_0_SP.svg/1920px-Hash_table_3_1_1_0_1_0_0_SP.svg.png)

## Control statements
### If statement
```cs
  var shouldPrint = false;
  var myList = new List<string>() { "Hello", "World", "People" };
  if (shouldPrint)
  {
      Console.WriteLine("We should print");
  }
  else if (myList.Count == 3)
  {
      Console.WriteLine("The count of myList is 3");
  }
  else
  {
      Console.WriteLine("This gets called if the other 2 statements are false");
  }
```

### For loops
```cs
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("We are on count " + i);
}
```

### Foreach
```cs
var items = new string[] {"Hello", "World", "People"};
foreach (var item in items)
{
    Console.WriteLine(item);
}
```


# Homework: Fizz Buzz
### The Task:
Create a console application that counts from 1 to a number the user specifies.  
For each number output "This is X out of Y", where X is the current number, and Y is the number the user specified above.   
Any number divisible by three should be replaced by the word "fizz" instead.  
Any number divisible by five should be replaced by the word "buzz" instead.   
Numbers divisible by 3 and 5 should be replaced by the word "fizz buzz".  

The modulus (remainder) operator in c# is this
```cs
10 % 5
```

### Sample output:
> This is 1 out of 100  
> This is 2 out of 100  
> Fizz  
> This is 4 out of 100  
> Buzz  
> Fizz  
> This is 7 out of 100  
> ...  


# Homework 2: Custom Dictionary
### The Task:
Create your own dictionary from scratch, including a simple hashing algorithm. The dictionary should map a string key to a string value.

*Note you will never have to create your own dictionary. You will always use the C# dictionary. This excerise is just to teach you what is happening behind the scenes. You will use dictionaries so much it is useful to understand this, and it sometimes is asked in interviews.*

(see section on how dictionaries work)
1. A dictionary is an array under the cover
2. You will need to hash a key (convert it from a string to a number that is less than your array size). 
3. You store the data at the index you get by hashing the key


You can use one of these 2 algorithms to hash your key:
- The length of the key
- The first character in the key converted to an int

You should be able to store and retrieve Key:Value pairs.

You should include methods to Add new entry and Get an entry. Bonus points for adding a method to remove an entry.

```cs
var dict = new MyDictionary(); // DavidDictionary is the dictionary class you a
dict.Add("Month", "Feb");
dict.Add("Colour", "Red");
dict.Get("Month"); // expect to return "Feb";
dict.Get("Colour"); // expect to return "Red";
dict.Add("Month", "Jan"); // override "Feb"
dict.Get("Month"); // expect to return "Jan";
```



