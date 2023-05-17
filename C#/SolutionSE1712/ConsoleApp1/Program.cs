// See https://aka.ms/new-console-template for more information
//var myInt = 0;
//var myBool = true;
//var myString = "Hello World!";
//var myDouble = 0.5;

/*
Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
Console.WriteLine("myString is a: {0}", myString.GetType().Name);
Console.WriteLine("myDouble is a: {0}",myDouble.GetType().Name);
*/

//double salary = 200.234;
//string name = "Soren";
//string str1 = string.Format("Name{0,6}, Salary{1,7:N2}", name, salary);
//Console.WriteLine(str1);
//string str2 = $"Name{name,7}, Salary{salary,8:N2}";
//Console.WriteLine(str2);
//Console.ReadLine();

//void MyMethod(int a, ref int b, out int c)
//{
//    a = 3;
//    b = 4;
//    c = 5;
//}

//int x=1, y=2,z;
//MyMethod(x,ref y,out z);
//Console.WriteLine($"x:{x},y:{y}, z:{z}");
//Console.ReadLine();

//void SumArray(out int s,params int[] list)
//{
//    int i;
//    s = 0;
//    for(i=0;i < list.Length; i++)
//    {
//        s += list[i];
//    }
//}

//int s;
//SumArray(out s, 1, 2, 3, 4);
//Console.WriteLine($"s={s}");
//int[] myIntArray = {5,6,7,8,9};
//SumArray(out s, myIntArray);
//Console.WriteLine($"s={s}");
//SumArray(out s);
//Console.WriteLine($"s={s}");
//Console.ReadLine();

//int[] numbers = {1,2,3,4,5};

//ref int FindNumber(int target)
//{
//    bool flag = true;
//    ref int value = ref numbers[0];
//    for(int i =0;i < numbers.Length && flag == true; i++)
//    {
//        if (numbers[i] == target)
//        {
//            value = ref numbers[i];
//            flag = false;
//        }
//    }
//    return ref value;
//}

//Console.Write("Original sequence:");
//Console.WriteLine(string.Join(",",numbers));
//ref int value = ref FindNumber(3);
//value *= 2;
//Console.Write("New sequence:     ");
//Console.WriteLine(string.Join(" ", numbers));
//Console.ReadLine();

//(string MyString, int MyNumber) MyValues = ("Hello World !", 2050);
//Console.WriteLine($"MyString : {MyValues.MyString}");
//Console.WriteLine($"MyNumbers : {MyValues.MyNumber}");
//Console.ReadLine();

//(int sum, int count) MyMethod(int[] values)
//{
//    var r = (sum: 0, count: 0);
//    for(int i =0;i < values.Length; i++)
//    {
//        if (IsEvenNumber(values[i]))
//        {
//            r.sum += values[i];
//            r.count++;
//        }
//    }
//    return r;
//    Boolean IsEvenNumber(int n)
//    {
//        return n%2== 0;
//    }
//}

//int[] numbers = { 2, 1, 5, 6, 3, 4, 7, 8, 10, 9 };  
//var (sum,count) = MyMethod(numbers);
//Console.WriteLine($"Sum:{sum}, Count: {count}");
//Console.ReadLine();

// null-condition operator
//int[] array1 = null;
//Console.WriteLine($"{array1 ?.Length.ToString() ?? "Array is empty."}");
//array1 = new int[] { 2, 1, 3 };
//dynamic[] array2 = { array1, null };
//var s = array2?[0]?.Length ?? "Array is empty.";
//Console.WriteLine($"{s}");
//s = array2?[1]?.Length ?? "Array is empty";
//Console.WriteLine($"{s}");



//using ConsoleApp1;

//Customer obj = new Customer();
//obj.CustomerID = 1000;
//Console.WriteLine($"ID:{obj.CustomerID}, Name:{obj.CustomerName}");
//obj.CustomerName = "Jack";
//obj.CustomerID = 2000;
//obj.Print();
//Console.ReadLine();

using ConsoleApp1;

Manager jack = new Manager(1500,"Jack dom dom","Jackdomdom@gmail.com");
Console.WriteLine(jack);
Console.ReadLine();