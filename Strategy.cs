//策略模式:定义一系列的算法,把每一个算法封装起来,并且使它们可相互替换,本模式使得算法可独立于使用它的客户而变化
using System;
abstract class Strategy
{
	public abstract void AlgorithmInterface();
}
class ConcreteStrategyA : Strategy
{
	public override void AlgorithmInterface()
	{
		Console.WriteLine("ConcreteStrategyA");
	}
}
class ConcreteStrategyB : Strategy
{
	public override void AlgorithmInterface()
	{
		Console.WriteLine("ConcreteStrategyB");
	}
}
class ConcreteStrategyC : Strategy
{
	public override void AlgorithmInterface()
	{
		Console.WriteLine("ConcreteStrategyC");
	}
}
class Context
{
	Strategy strategy;
	public Context(Strategy strategy)
	{
		this.strategy = strategy;
	}
	public void ContextInterface()
	{
		strategy.AlgorithmInterface();
	}
}
class Program
{
	static void Main()
	{
		Context context;
		context = new Context(new ConcreteStrategyA());
		context.ContextInterface();
		context = new Context(new ConcreteStrategyB());
		context.ContextInterface();
		context = new Context(new ConcreteStrategyC());
		context.ContextInterface();
		Console.ReadKey();
	}
}
