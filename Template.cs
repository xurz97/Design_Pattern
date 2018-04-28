//模板方法模式:在一个方法中定义一个算法的框架,然后将该方法中的一些步骤延迟到子类中,使得再不改变算法的前提下,重新定义自己的算法
using System;
abstract class AbstractClass
{
	public abstract void PrimitiveOperation1();
	public abstract void PrimitiveOperation2();
	public void TemplateMethod()
	{
		PrimitiveOperation1();
		PrimitiveOperation2();
	}
}
class ConcreteClassA : AbstractClass
{
	public override void PrimitiveOperation1()
	{
		Console.WriteLine("A 1");
	}
	public override void PrimitiveOperation2()
	{
		Console.WriteLine("A 2");
	}
}
class ConcreteClassB : AbstractClass
{
	public override void PrimitiveOperation1()
	{
		Console.WriteLine("B 1");
	}
	public override void PrimitiveOperation2()
	{
		Console.WriteLine("B 2");
	}
}
class Program
{
	static void Main()
	{
		AbstractClass c;
		c = new ConcreteClassA();
		c.TemplateMethod();
		c = new ConcreteClassB();
		c.TemplateMethod();
		Console.ReadKey();
	}
}