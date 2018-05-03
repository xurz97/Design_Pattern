//桥接模式:将抽象部分与实现部分分离,使它们都可以独立地变化
using System;
abstract class Implementor
{
	public abstract void Operation();
}
class ConcreteImplementorA : Implementor
{
	public override void Operation()
	{
		Console.WriteLine("ConcreteImplementorA");
	}
}
class ConcreteImplementorB : Implementor
{
	public override void Operation()
	{
		Console.WriteLine("ConcreteImplementorB");
	}
}
abstract class Abstraction
{
	protected Implementor implementor;
	public void SetImplementor(Implementor implementor)
	{
		this.implementor = implementor;
	}
	public abstract void Operation();
}
class RefinedAbstraction : Abstraction
{
	public override void Operation()
	{
		implementor.Operation();
	}
}
class Program
{
	static void Main()
	{
		Abstraction ab = new RefinedAbstraction();
		ab.SetImplementor(new ConcreteImplementorA());
		ab.Operation();
		ab.SetImplementor(new ConcreteImplementorB());
		ab.Operation();
		Console.ReadKey();
	}
}