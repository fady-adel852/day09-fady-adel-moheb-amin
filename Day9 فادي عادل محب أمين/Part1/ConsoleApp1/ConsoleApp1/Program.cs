//Question 1 Start:
using System;

enum Weekdays
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday
}

class Program
{
    static void Main()
    {
        foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
        {
            Console.WriteLine($"{day} = {(int)day}");
        }
    }
}

/*Why is it recommended to explicitly assign values to enum members in some cases?
Because of:
Interoperability: When working with external systems or APIs that expect
specific values, explicitly assigning values ensures compatibility.

Versioning: Explicit values help maintain consistency across different
versions of the code, preventing unexpected changes if new members are added.

Clarity: It makes the code more readable and understandable, as the assigned
values provide clear context.
*/
//Question 1 End:






//Question 2 Start:
using System;

enum Grades : short
{
    A = 1,
    B = 2,
    C = 3,
    D = 4,
    F = -1
}

class Program
{
    static void Main()
    {
        foreach (Grades grade in Enum.GetValues(typeof(Grades)))
        {
            Console.WriteLine($"{grade} = {(short)grade}");
        }
    }
}

/*What happens if you assign a value to an enum member that exceeds the underlying 
type's range? 
if you assign a value to an enum member that exceeds the underlying type's
range, it will cause a compilation error. For example, if you try to
assign a value greater than 32767 or less than -32768 to an enum with
short as its underlying type, the compiler will throw an error because
these values are outside the range of the short data type.
*/

//Question 2 End:








//Question 3 Start:
using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; } // Added Department property

    public void PrintDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Department: {Department}");
    }
}

class Program
{
    static void Main()
    {
        Person person1 = new Person { Name = "Alice", Age = 30, Department = "HR" };
        Person person2 = new Person { Name = "Bob", Age = 25, Department = "IT" };

        person1.PrintDetails();
        person2.PrintDetails();
    }
}

/*What is the purpose of the virtual keyword when used with properties?
the virtual keyword is used with properties to allow derived classes to
override them. This is useful when you want to provide a base implementation
in a base class but allow derived classes to provide their own specific
implementation.
*/

//Question 3 End:





//Question 4 Start:

using System;

class Parent
{
    public virtual int Salary { get; set; }
}

class Child : Parent
{
    public sealed override int Salary { get; set; }

    public void DisplaySalary()
    {
        Console.WriteLine($"Salary: {Salary}");
    }
}

class Program
{
    static void Main()
    {
        Child child = new Child { Salary = 5000 };
        child.DisplaySalary();
    }
}


/*Why can’t you override a sealed property or method? 
I can't override a sealed property or method because the sealed keyword is
used to prevent further overriding. When a property or method is marked as
sealed, it means that no derived class can override it again. This is useful
when you want to ensure that the implementation provided in the current class
remains unchanged and is not altered by any further derived classes.
*/

//Question 4 End:







//Question 5 Start:

using System;

class Utility
{
    public static double CalculatePerimeter(double length, double width)
    {
        return 2 * (length + width);
    }
}

class Program
{
    static void Main()
    {
        double length = 5.0;
        double width = 3.0;
        double perimeter = Utility.CalculatePerimeter(length, width);
        Console.WriteLine($"Perimeter of the rectangle: {perimeter}");
    }
}

/*What is the key difference between static and object members? 
the key difference between static and object members is:

Static Members: These belong to the class itself rather than any specific
instance. They are shared across all instances of the class. You can access
static members using the class name without creating an instance of the class.

Object Members: These belong to a specific instance of the class.
Each instance of the class has its own copy of these members.
You need to create an instance of the class to access object members.
*/

//Question 5 End:










//Question 6 Start:
using System;

class ComplexNumber
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
    {
        double realPart = c1.Real * c2.Real - c1.Imaginary * c2.Imaginary;
        double imaginaryPart = c1.Real * c2.Imaginary + c1.Imaginary * c2.Real;
        return new ComplexNumber(realPart, imaginaryPart);
    }

    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}

class Program
{
    static void Main()
    {
        ComplexNumber c1 = new ComplexNumber(2, 3);
        ComplexNumber c2 = new ComplexNumber(4, 5);
        ComplexNumber result = c1 * c2;

        Console.WriteLine($"({c1}) * ({c2}) = {result}");
    }
}


/*Can you overload all operators in C#? Explain why or why not.
you cannot overload all operators in C#. Some operators,
like the assignment operator (=), the conditional
logical operators (&& and ||), and the member access operators (. and ->),
cannot be overloaded. This is because overloading these operators could
lead to ambiguous or unintended behavior, making the code harder to
understand and maintain.
*/

//Question 6 End:















//Question 7 Start:
using System;

enum Gender : byte
{
    Male = 1,
    Female = 2,
    Other = 3
}

enum DefaultGender
{
    Male = 1,
    Female = 2,
    Other = 3
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Memory usage of Gender enum with byte as underlying type:");
        Console.WriteLine($"Size of Gender.Male: {sizeof(Gender)} bytes");

        Console.WriteLine("Memory usage of DefaultGender enum with int as underlying type:");
        Console.WriteLine($"Size of DefaultGender.Male: {sizeof(DefaultGender)} bytes");
    }
}

/*When should you consider changing the underlying type of an enum?
Memory Efficiency: If you have a large number of enum values and memory
usage is a concern, using a smaller underlying type like byte can save memory.

Interoperability: When working with external systems or APIs that expect
specific underlying types, matching the expected type ensures compatibility.

Performance: In some cases, using a smaller underlying type can improve
performance, especially in memory-constrained environments.
*/

//Question 7 End:








//Question 8 Start:
using System;

class Utility
{
    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}

class Program
{
    static void Main()
    {
        double celsius = 25.0;
        double fahrenheit = 77.0;

        Console.WriteLine($"{celsius}°C is {Utility.CelsiusToFahrenheit(celsius)}°F");
        Console.WriteLine($"{fahrenheit}°F is {Utility.FahrenheitToCelsius(fahrenheit)}°C");
    }
}

/*Why can't a static class have instance constructors? 
a static class cannot have instance constructors because static
classes are not meant to be instantiated. Static classes are designed
to hold static members (methods, properties, fields) that belong to the
class itself rather than any specific instance. Since you cannot create an
instance of a static class, having an instance constructor would be meaningless.
*/

//Question 8 End:





//Question 9 Start:
using System;

enum Grades
{
    A = 1,
    B = 2,
    C = 3,
    D = 4,
    F = 5
}

class Program
{
    static void Main()
    {
        string input = "B";
        if (Enum.TryParse(input, out Grades grade))
        {
            Console.WriteLine($"Parsed grade: {grade}");
        }
        else
        {
            Console.WriteLine("Invalid grade input.");
        }

        input = "Z";
        if (Enum.TryParse(input, out grade))
        {
            Console.WriteLine($"Parsed grade: {grade}");
        }
        else
        {
            Console.WriteLine("Invalid grade input.");
        }
    }
}

/*What are the advantages of using Enum.TryParse over direct parsing with int.Parse? 

Graceful Handling of Invalid Inputs: Enum.TryParse returns a boolean
indicating whether the parsing was successful, allowing you to handle
invalid inputs without throwing exceptions.

Type Safety: Enum.TryParse ensures that the parsed value is a valid
enum member, providing better type safety compared to int.Parse, which
only converts strings to integers.

Readability and Maintainability: Using Enum.TryParse makes the code more
readable and maintainable, as it clearly indicates the intention to parse
a string to an enum value.
*/

//Question 9 End:










//Question 10 Start:
using System;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Employee other = (Employee)obj;
        return Id == other.Id && Name == other.Name;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name);
    }
}

class Helper2<T>
{
    public static int SearchArray(T[] array, T value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Equals(value))
            {
                return i;
            }
        }
        return -1;
    }
}

class Program
{
    static void Main()
    {
        Employee[] employees = new Employee[]
        {
            new Employee { Id = 1, Name = "Alice" },
            new Employee { Id = 2, Name = "Bob" },
            new Employee { Id = 3, Name = "Charlie" }
        };

        Employee searchEmployee = new Employee { Id = 2, Name = "Bob" };
        int index = Helper2<Employee>.SearchArray(employees, searchEmployee);

        if (index != -1)
        {
            Console.WriteLine($"Employee found at index {index}: {employees[index].Name}");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }
}

/*What is the difference between overriding Equals and == for object comparison in C# struct and 
class ? 
Equals Method: The Equals method is used to compare the contents of two
objects. When you override Equals, you provide a custom implementation
to determine equality based on the object's properties. This method
is used for value-based comparison.

== Operator: The == operator is used to compare the references of two objects
by default. For classes, it checks if both references point to the same
object in memory. For structs, it checks if the values of the structs
are the same. You can overload the == operator to provide custom comparison
logic, similar to Equals.





Why is overriding ToString beneficial when working with custom classes?

Overriding the ToString method in custom classes is beneficial for several reasons:

Readability: It provides a human-readable string representation
of the object, making it easier to understand the object's state
when printed or logged.

Debugging: It simplifies debugging by allowing you to quickly
see the values of an object's properties without needing to inspect each
property individually.

Logging: It enhances logging by providing meaningful information about
the object, which can be useful for tracking the flow of a program and
diagnosing issues.

*/

//Question 10 End:










//Question 11 Start:
using System;

class Helper
{
    public static T Max<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b) > 0 ? a : b;
    }
}

class Program
{
    static void Main()
    {
        int int1 = 5, int2 = 10;
        double double1 = 5.5, double2 = 10.5;
        string string1 = "apple", string2 = "orange";

        Console.WriteLine($"Max of {int1} and {int2} is {Helper.Max(int1, int2)}");
        Console.WriteLine($"Max of {double1} and {double2} is {Helper.Max(double1, double2)}");
        Console.WriteLine($"Max of {string1} and {string2} is {Helper.Max(string1, string2)}");
    }
}


/*Can generics be constrained to specific types in C#? Provide an example.
yes, generics can be constrained to specific types in C#.
You can use constraints to specify that a type parameter must implement
a particular interface, inherit from a specific class, or have a
parameterless constructor. the example:



using System;

class Example<T> where T : IComparable<T>
{
    public T Max(T a, T b)
    {
        return a.CompareTo(b) > 0 ? a : b;
    }
}

class Program
{
    static void Main()
    {
        Example<int> example = new Example<int>();
        int result = example.Max(5, 10);
        Console.WriteLine($"Max of 5 and 10 is {result}");
    }
}



*/


//Question 11 End:











//Question 12 Start:
using System;

class Helper2<T>
{
    public static void ReplaceArray(T[] array, T oldValue, T newValue)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Equals(oldValue))
            {
                array[i] = newValue;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        int[] intArray = { 1, 2, 3, 2, 4, 2 };
        string[] stringArray = { "apple", "banana", "apple", "cherry" };

        Console.WriteLine("Original integer array: " + string.Join(", ", intArray));
        Helper2<int>.ReplaceArray(intArray, 2, 5);
        Console.WriteLine("Modified integer array: " + string.Join(", ", intArray));

        Console.WriteLine("Original string array: " + string.Join(", ", stringArray));
        Helper2<string>.ReplaceArray(stringArray, "apple", "orange");
        Console.WriteLine("Modified string array: " + string.Join(", ", stringArray));
    }
}


/*What are the key differences between generic methods and generic classes? 
Scope: Generic methods are defined within a class (generic or non-generic) and provide type flexibility for that specific method. Generic classes, on the other hand, provide type flexibility for all their members (methods, properties, etc.).

Type Parameters: Generic methods have their own type parameters, which are independent of the class's type parameters. Generic classes have type parameters that apply to all members of the class.

Usage: Generic methods are useful when you need type flexibility for a single method within a class. Generic classes are useful when you need type flexibility for multiple members within a class.
*/


//Question 12 End:










//Question 13 Start:
using System;

struct Rectangle
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public void Swap(ref Rectangle other)
    {
        Rectangle temp = this;
        this = other;
        other = temp;
    }

    public override string ToString()
    {
        return $"Length: {Length}, Width: {Width}";
    }
}

class Program
{
    static void Main()
    {
        Rectangle rect1 = new Rectangle(5.0, 3.0);
        Rectangle rect2 = new Rectangle(10.0, 6.0);

        Console.WriteLine("Before swap:");
        Console.WriteLine($"rect1: {rect1}");
        Console.WriteLine($"rect2: {rect2}");

        rect1.Swap(ref rect2);

        Console.WriteLine("After swap:");
        Console.WriteLine($"rect1: {rect1}");
        Console.WriteLine($"rect2: {rect2}");
    }
}


/*Why might using a generic swap method be preferable to implementing custom methods for 
each type? 
Reusability: A generic swap method can be used with any type, reducing the need to write and maintain multiple swap methods for different types.

Type Safety: Generics provide type safety at compile time, ensuring that the swap method works correctly with the specified types.

Code Reduction: It reduces code duplication, making the codebase cleaner and easier to maintain.
*/

//Question 13 End:




//Question 14 Start:
using System;

class Department
{
    public string Name { get; set; }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Department other = (Department)obj;
        return Name == other.Name;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Department Department { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Department: {Department.Name}";
    }
}

class Helper2<T>
{
    public static int SearchArray(T[] array, T value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Equals(value))
            {
                return i;
            }
        }
        return -1;
    }
}

class Program
{
    static void Main()
    {
        Department hr = new Department { Name = "HR" };
        Department it = new Department { Name = "IT" };

        Employee[] employees = new Employee[]
        {
            new Employee { Id = 1, Name = "Alice", Department = hr },
            new Employee { Id = 2, Name = "Bob", Department = it },
            new Employee { Id = 3, Name = "Charlie", Department = hr }
        };

        Department searchDepartment = new Department { Name = "IT" };
        int index = Helper2<Employee>.SearchArray(employees, new Employee { Department = searchDepartment });

        if (index != -1)
        {
            Console.WriteLine($"Employee found at index {index}: {employees[index]}");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }
}


/*How can overriding Equals for the Department class improve the accuracy
of searches? 
overriding Equals for the Department class improves the accuracy of
searches by ensuring that comparisons are based on the actual content
of the Department objects (i.e., the Name property) rather than their
references. This allows for meaningful comparisons and accurate search
results, especially when dealing with collections of objects.
*/

//Question 14 End:









//Questio 15 Start:
//Struct Implementation

using System;

struct CircleStruct
{
    public double Radius { get; set; }
    public string Color { get; set; }

    public CircleStruct(double radius, string color)
    {
        Radius = radius;
        Color = color;
    }

    public override bool Equals(object obj)
    {
        if (obj is CircleStruct)
        {
            CircleStruct other = (CircleStruct)obj;
            return Radius == other.Radius && Color == other.Color;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Radius, Color);
    }

    public static bool operator ==(CircleStruct c1, CircleStruct c2)
    {
        return c1.Equals(c2);
    }

    public static bool operator !=(CircleStruct c1, CircleStruct c2)
    {
        return !c1.Equals(c2);
    }
}

class Program
{
    static void Main()
    {
        CircleStruct circle1 = new CircleStruct(5.0, "Red");
        CircleStruct circle2 = new CircleStruct(5.0, "Red");
        CircleStruct circle3 = new CircleStruct(7.0, "Blue");

        Console.WriteLine($"circle1 == circle2: {circle1 == circle2}");
        Console.WriteLine($"circle1.Equals(circle2): {circle1.Equals(circle2)}");
        Console.WriteLine($"circle1 == circle3: {circle1 == circle3}");
        Console.WriteLine($"circle1.Equals(circle3): {circle1.Equals(circle3)}");
    }
}

//Class Implementation

//using System;

//class CircleClass
//{
//    public double Radius { get; set; }
//    public string Color { get; set; }

//    public CircleClass(double radius, string color)
//    {
//        Radius = radius;
//        Color = color;
//    }

//    public override bool Equals(object obj)
//    {
//        if (obj is CircleClass)
//        {
//            CircleClass other = (CircleClass)obj;
//            return Radius == other.Radius && Color == other.Color;
//        }
//        return false;
//    }

//    public override int GetHashCode()
//    {
//        return HashCode.Combine(Radius, Color);
//    }

//    public static bool operator ==(CircleClass c1, CircleClass c2)
//    {
//        if (ReferenceEquals(c1, c2))
//        {
//            return true;
//        }
//        if (ReferenceEquals(c1, null) || ReferenceEquals(c2, null))
//        {
//            return false;
//        }
//        return c1.Equals(c2);
//    }

//    public static bool operator !=(CircleClass c1, CircleClass c2)
//    {
//        return !(c1 == c2);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        CircleClass circle1 = new CircleClass(5.0, "Red");
//        CircleClass circle2 = new CircleClass(5.0, "Red");
//        CircleClass circle3 = new CircleClass(7.0, "Blue");

//        Console.WriteLine($"circle1 == circle2: {circle1 == circle2}");
//        Console.WriteLine($"circle1.Equals(circle2): {circle1.Equals(circle2)}");
//        Console.WriteLine($"circle1 == circle3: {circle1 == circle3}");
//        Console.WriteLine($"circle1.Equals(circle3): {circle1.Equals(circle3)}");
//    }
//}




/*Why is == not implemented by default for structs? 
Structs: By default, the == operator is not implemented
for structs because structs are value types, and the default
behavior of == for value types is to compare their references,
which is not meaningful for value types. Implementing == for structs
allows for meaningful value comparisons.

Classes: For classes, the == operator compares references by
default. Overriding == and Equals allows for meaningful comparisons
based on the content of the objects rather than their references.
*/

//Question 15 End: