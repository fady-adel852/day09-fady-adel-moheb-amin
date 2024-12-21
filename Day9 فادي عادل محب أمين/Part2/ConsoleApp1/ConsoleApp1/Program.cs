////Problem one Start:
//using System;

//public class ArrayHelper
//{
//    public static T[] ReverseArray<T>(T[] array)
//    {
//        T[] reversedArray = new T[array.Length];
//        for (int i = 0; i < array.Length; i++)
//        {
//            reversedArray[i] = array[array.Length - 1 - i];
//        }
//        return reversedArray;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int[] intArray = { 1, 2, 3, 4, 5 };
//        string[] stringArray = { "apple", "banana", "cherry" };

//        int[] reversedIntArray = ArrayHelper.ReverseArray(intArray);
//        string[] reversedStringArray = ArrayHelper.ReverseArray(stringArray);

//        Console.WriteLine("Reversed int array: " + string.Join(", ", reversedIntArray));
//        Console.WriteLine("Reversed string array: " + string.Join(", ", reversedStringArray));
//    }
//}
////Problem one End:









//=================================================================













////Problem two Start:
//using System;
//using System.Collections.Generic;

//public class Stack<T>
//{
//    private List<T> elements = new List<T>();

//    public void Push(T item)
//    {
//        elements.Add(item);
//    }

//    public T Pop()
//    {
//        if (elements.Count == 0)
//        {
//            throw new InvalidOperationException("The stack is empty.");
//        }
//        T item = elements[elements.Count - 1];
//        elements.RemoveAt(elements.Count - 1);
//        return item;
//    }

//    public T Peek()
//    {
//        if (elements.Count == 0)
//        {
//            throw new InvalidOperationException("The stack is empty.");
//        }
//        return elements[elements.Count - 1];
//    }

//    public int Count
//    {
//        get { return elements.Count; }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Stack<int> intStack = new Stack<int>();
//        intStack.Push(1);
//        intStack.Push(2);
//        intStack.Push(3);

//        Console.WriteLine("Top element: " + intStack.Peek());
//        Console.WriteLine("Popped element: " + intStack.Pop());
//        Console.WriteLine("Top element after pop: " + intStack.Peek());

//        Stack<string> stringStack = new Stack<string>();
//        stringStack.Push("apple");
//        stringStack.Push("banana");
//        stringStack.Push("cherry");

//        Console.WriteLine("Top element: " + stringStack.Peek());
//        Console.WriteLine("Popped element: " + stringStack.Pop());
//        Console.WriteLine("Top element after pop: " + stringStack.Peek());
//    }
//}
////Problem two End:






//=======================================================================




////Problem three Start:
//using System;

//public class ArrayHelper
//{
//    public static void SwapElements<T>(T[] array, int index1, int index2)
//    {
//        if (index1 < 0 || index1 >= array.Length || index2 < 0 || index2 >= array.Length)
//        {
//            throw new ArgumentOutOfRangeException("Indices are out of range.");
//        }

//        T temp = array[index1];
//        array[index1] = array[index2];
//        array[index2] = temp;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int[] intArray = { 1, 2, 3, 4, 5 };
//        string[] stringArray = { "apple", "banana", "cherry" };

//        ArrayHelper.SwapElements(intArray, 1, 3);
//        ArrayHelper.SwapElements(stringArray, 0, 2);

//        Console.WriteLine("Swapped int array: " + string.Join(", ", intArray));
//        Console.WriteLine("Swapped string array: " + string.Join(", ", stringArray));
//    }
//}

////Problem three End:



//===========================================================================



////Problem four Start:

//using System;

//public class ArrayHelper
//{
//    public static T FindMax<T>(T[] array) where T : IComparable<T>
//    {
//        if (array == null || array.Length == 0)
//        {
//            throw new ArgumentException("Array is null or empty.");
//        }

//        T maxElement = array[0];
//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i].CompareTo(maxElement) > 0)
//            {
//                maxElement = array[i];
//            }
//        }
//        return maxElement;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int[] intArray = { 1, 2, 3, 4, 5 };
//        string[] stringArray = { "apple", "banana", "cherry" };

//        int maxInt = ArrayHelper.FindMax(intArray);
//        string maxString = ArrayHelper.FindMax(stringArray);

//        Console.WriteLine("Maximum int: " + maxInt);
//        Console.WriteLine("Maximum string: " + maxString);
//    }
//}
////Problem four End: