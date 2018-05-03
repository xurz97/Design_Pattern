//享元模式:运用共享技术有效地支持大量细粒度的对象
using System;
using System.Collections;
abstract class Flyweight
{
	public abstract void Operation(int extrinsicstate);
}
class ConcreteFlyweight : Flyweight
{
	public override void Operation(int extrinsicstate)
	{
		Console.WriteLine("ConcreteFlyweight:" + extrinsicstate);
	}
}
class UnshareConcreteFlyweight : Flyweight
{
	public override void Operation(int extrinsicstate)
	{
		Console.WriteLine("UnshareConcreteFlyweight:" + extrinsicstate);
	}
}
class FlyweightFactory
{
	private Hashtable flyweights = new Hashtable();
	public FlyweightFactory()
	{
		flyweights.Add("X", new ConcreteFlyweight());
		flyweights.Add("Y", new ConcreteFlyweight());
		flyweights.Add("Z", new ConcreteFlyweight());
	}
	public Flyweight GetFlyweight(string key)
	{
		return (Flyweight)flyweights[key];
	}
}
class Program
{
	static void Main()
	{
		int extrinsicstate = 22;
		FlyweightFactory f = new FlyweightFactory();
		Flyweight fx = f.GetFlyweight("X");
		fx.Operation(--extrinsicstate);
		Flyweight uf = new UnshareConcreteFlyweight();
		uf.Operation(--extrinsicstate);
		Console.ReadKey();
	}
}