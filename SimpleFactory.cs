//简单工厂模式:用一个单独的类来创造实例
using System;
public class ClassBase { }
class ClassA : ClassBase { }
class ClassB : ClassBase { }
public class ClassFactory
{
	public static ClassBase CreateClass(string operation)
	{
		ClassBase ret = null;
		if (operation == "A") ret = new ClassA();
		if (operation == "B") ret = new ClassB();
		return ret;
	}
}
class Program
{
	static void Main()
	{
		ClassBase classA = ClassFactory.CreateClass("A");
		ClassBase classB = ClassFactory.CreateClass("B");
	}
}
