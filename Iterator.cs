//迭代器模式:提供一种方法顺序访问一个聚合对象中的各种元素,而又不暴露该对象的内部表示
using System;
using System.Collections.Generic;
abstract class Iterator
{
	public abstract object First();
	public abstract object Next();
	public abstract bool IsDone();
	public abstract object CurrentItem();
}
abstract class Aggregate
{
	public abstract Iterator CreateIterator();
}
class ConcretIterator : Iterator
{
	private ConcretAggregate aggregate;
	private int current = 0;
	public ConcretIterator(ConcretAggregate aggregate)
	{
		this.aggregate = aggregate;
	}
	public override object First()
	{
		return aggregate[0];
	}
	public override object Next()
	{
		object ret = null;
		current++;
		if (current < aggregate.Count)
		{
			ret = aggregate[current];
		}
		return ret;
	}
	public override bool IsDone()
	{
		return current >= aggregate.Count ? true : false;
	}
	public override object CurrentItem()
	{
		return aggregate[current];
	}
}
class ConcretAggregate : Aggregate
{
	private IList<object> items = new List<object>();
	public override Iterator CreateIterator()
	{
		return new ConcretIterator(this);
	}
	public int Count
	{
		get { return items.Count; }
	}
	public object this[int index]
	{
		get { return items[index]; }
		set { items.Insert(index, value); }
	}
}
class Program
{
	static void Main()
	{
		ConcretAggregate a = new ConcretAggregate();
		a[0] = 1;
		a[1] = "2";
		Iterator i = new ConcretIterator(a);
		object item = i.First();
		while (!i.IsDone())
		{
			Console.WriteLine(i.CurrentItem());
			i.Next();
		}
		Console.ReadKey();
	}
}
