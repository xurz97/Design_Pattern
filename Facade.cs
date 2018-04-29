//外观模式:为子系统中的一组接口提供一个一致的界面,定义一个高层接口,这个接口使得这一子系统更加容易使用
using System;
class SubSystemA
{
	public void MethodA()
	{
		Console.WriteLine("SubSystemA");
	}
}
class SubSystemB
{
	public void MethodB()
	{
		Console.WriteLine("SubSystemB");
	}
}
class Facade
{
	SubSystemA subSystemA;
	SubSystemB subSystemB;
	public Facade()
	{
		subSystemA = new SubSystemA();
		subSystemB = new SubSystemB();
	}
	public void Method()
	{
		Console.WriteLine("Method:");
		subSystemA.MethodA();
		subSystemB.MethodB();
	}
}
class Program
{
	static void Main()
	{
		Facade facade = new Facade();
		facade.Method();
		Console.ReadKey();
	}
}
