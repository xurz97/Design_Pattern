//装饰模式:在不必改变原类文件和使用继承的情况下,动态地扩展一个对象的功能,它是通过创建一个包装对象,也就是装饰来包裹真实的对象
using System;
abstract class Component
{
	public abstract void Operation();
}
class ConcreteComponent : Component
{
	public override void Operation()
	{
		Console.WriteLine("ConcreteOperation");
	}
}
abstract class Decorator : Component
{
	protected Component component;
	public Decorator(Component c) { component = c; }
	public override void Operation()
	{
		if (component != null)
		{
			component.Operation();
		}
	}
}
class ConcreteDecoratorA : Decorator
{
	public ConcreteDecoratorA(Component c) : base(c) { }
	public override void Operation()
	{
		base.Operation();
		Console.WriteLine("A");
	}
}
class ConcreteDecoratorB : Decorator
{
	public ConcreteDecoratorB(Component c) : base(c) { }
	public override void Operation()
	{
		base.Operation();
		Console.WriteLine("B");
	}
}
class Program
{
	static void Main()
	{
		ConcreteComponent c = new ConcreteComponent();
		ConcreteDecoratorA d1 = new ConcreteDecoratorA(c);
		ConcreteDecoratorB d2 = new ConcreteDecoratorB(d1);
		d2.Operation();
		Console.ReadKey();
	}
}
