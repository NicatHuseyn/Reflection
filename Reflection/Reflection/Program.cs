

//Assembly assembly = Assembly.GetExecutingAssembly();
//var types = assembly.GetTypes();
//Console.WriteLine();


#region Load function

//Assembly assembly = Assembly.Load("classLibrary1");

//Assembly assembly = Assembly.GetExecutingAssembly();
//var modules = assembly.GetModules();

#endregion


#region GetType Function

//Assembly assembly = Assembly.GetExecutingAssembly();
//var type = assembly.GetType(nameof(MyClass));

#endregion


#region Access members with Reflection
//Type type = typeof(MyClass); // class-ın reflection-a girdi.

//MemberInfo[] nameMemberinfo = type.GetMember(nameof(MyClass.Name)); // bütün member-ları gətirəcək.
//MethodInfo methodInfo = type.GetMethod(nameof(MyClass.Test)); // sadəcə metodları gətirir.
//PropertyInfo[] propertyInfos = type.GetProperties(); // bütün property-ləri gətirəcək.
//FieldInfo[] fieldInfos = type.GetFields();  // bütün field-ları gətirəcək.
//FieldInfo info = type.GetField(nameof(MyClass.a)); // bəyan edilən filed-ı gətirəcək.
#endregion


#region Property value get and set

//MyClass myClass = new MyClass();

//Type type = myClass.GetType();

//PropertyInfo propertyInfo = type.GetProperty(nameof(MyClass.Name));
//propertyInfo.SetValue(myClass, "Nicat");

//var value = propertyInfo.GetValue(myClass);

//Console.WriteLine(value); // Result: Nicat

#endregion


#region Method working

//MyClass myClass = new MyClass();
//Type type = myClass.GetType();
//MethodInfo methodInfo = type.GetMethod(nameof(myClass.Test2));
//methodInfo.Invoke(myClass, new object[] { 5 });

#endregion

#region Accessing Private memblers with Reflection

using System.Reflection;

var type = typeof(MyClass);

// private method call
var method = type.GetMethod("PrivateMethod", BindingFlags.NonPublic | BindingFlags.Instance);
method.Invoke(new MyClass(),null);

#endregion

class MyClass
{
    private void PrivateMethod()
    {
        Console.WriteLine("Private Method Invoke with Reflection");
    }


    
    int PrivateProperty { get; set; } = 10;

    private int x = 10;
    private int y;
    private int z;
    

    public void Test()
    {
        Console.WriteLine("Method Invoke with Reflection");
    }

    public void Test2(int a)
    {
        Console.WriteLine($"Test2 method calisdir | parametr:{a}");
    }

    public string Name { get; set; }
    public int a;


   

   
}



interface IMyClass { }
record MyRecord { }
struct MyStruct { }
enum MyEnum { }
delegate void MyHandler();