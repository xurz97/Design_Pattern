//适配器模式:将一个类的接口转换成客户希望的另外一个接口,Adapter模式使得原本由于接口不兼容而不能一起工作的那些类可以一起工作
using System;
class Target
{
	public virtual void Request()
	{
		Console.WriteLine("Request");
	}
}
class Adaptee
{
	public void SpecificRequest()
	{
		Console.WriteLine("SpecificRequest");
	}
}
class Adapter : Target
{
	private Adaptee adaptee = new Adaptee();
	public override void Request()
	{
		adaptee.SpecificRequest();
	}
}
class Program
{
	static void Main()
	{
		Target target = new Adapter();
		target.Request();
		Console.ReadKey();
	}
}
