# Class code
```cs
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var myGeneric = new MyGenericClass<string, int>("tttta");

        }
    }

    class MyGenericClass<T1, TField>
    {
        private readonly T1 _variable;

        public MyGenericClass(T1 variable)
        {
            _variable = variable;
        }

        public TField Field { get; set; }
    }


    class MyGenericMethods
    {
        private string ToString<T>(T it)
        {
            return it.ToString();
        }

        public static T SafeGetAt<T>(List<T> list, int index)
        {
            return index < list.Count ? list[index] : default(T);
        }
    }
```

## Homework
### Make Dictionary Generic
### Phonebook

Phonebook part I:  
You've been tasked to design the phone book on a phone. 
The only problem is it on one of those old Nokia brick phones. So there is **some** limitations on the storage.


You should create a command line phone book application that must:
1. Have an option to add a name and an *11* digit number. The number may begin with a 0.
```
STORE david 07900001234
OK
STORE work 02080000110
OK
STORE peter 12345678901
OK
```
2. Have an option to retrieve a number given a name
```
GET peter
OK 12345678901
```
3. Have an option to delete/remove a name. It must return the number of the deleted person to confirm the deletion was successful
```
DEL peter
OK 12345678901
```
4. Have an option to Update the number for a person. Returns the previous number to confirm the update was successful  
```
UPDATE david 07700000000
OK last no was - 07900001234
```

5. You are only allowed to store the telephone number as a long as a string would be too big  

These restrictions might cause a name/number pair to accidentally override another but this is acceptable  
