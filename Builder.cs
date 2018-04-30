//建造者模式:将一个复杂对象的构建与它的表示分离,使得同样的构建过程可以创建不同的表示
using System;
using System.Collections.Generic;
class Product
{
	IList<string> parts = new List<string>();
	public void Add(string part)
	{
		parts.Add(part);
	}
	public void Show()
	{
		Console.WriteLine("Product:");
		foreach (string part in parts)
		{
			Console.WriteLine(part);
		}
	}
}
abstract class Builder
{
	public abstract void BuildPartA();
	public abstract void BuildPartB();
	public abstract Product GetResult();
}
class ConcreteBuilder1 : Builder
{
	private Product product = new Product();
	public override void BuildPartA()
	{
		product.Add("Part 1A");
	}
	public override void BuildPartB()
	{
		product.Add("Part 1B");
	}
	public override Product GetResult()
	{
		return product;
	}
}
class ConcreteBuilder2 : Builder
{
	private Product product = new Product();
	public override void BuildPartA()
	{
		product.Add("Part 2A");
	}
	public override void BuildPartB()
	{
		product.Add("Part 2B");
	}
	public override Product GetResult()
	{
		return product;
	}
}
class Director
{
	public void Construct(Builder builder)
	{
		builder.BuildPartA();
		builder.BuildPartB();
	}
}
class Program
{
	static void Main()
	{
		Director director = new Director();
		Builder b1 = new ConcreteBuilder1();
		Builder b2 = new ConcreteBuilder2();
		director.Construct(b1);
		Product p1 = b1.GetResult();
		p1.Show();
		director.Construct(b2);
		Product p2 = b2.GetResult();
		p2.Show();
	}
}