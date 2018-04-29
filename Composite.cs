//组合模式:将对象组合成树形结构以表示"部分-整体"的层次结构,组合模式使得用户对单个对象和组合对象的使用具有一致性
using System;
using System.Collections.Generic;
abstract class Component
{
	protected string name;
	public Component(string name) { this.name = name; }
	public abstract void Add(Component c);
	public abstract void Remove(Component c);
	public abstract void Display(int depth);
}
class Leaf : Component
{
	public Leaf(string name) : base(name) { }
	public override void Add(Component c)
	{
		Console.WriteLine("Cannot add to a leaf.");
	}
	public override void Remove(Component c)
	{
		Console.WriteLine("Cannot remove from a leaf.");
	}
	public override void Display(int depth)
	{
		Console.WriteLine(new String('-', depth) + name);
	}
}
class Composite : Component
{
	private List<Component> children = new List<Component>();
	public Composite(string name) : base(name) { }
	public override void Add(Component c)
	{
		children.Add(c);
	}
	public override void Remove(Component c)
	{
		children.Remove(c);
	}
	public override void Display(int depth)
	{
		Console.WriteLine(new String('-', depth) + name);
		foreach (Component component in children)
		{
			component.Display(depth + 1);
		}
	}
}
class Program
{
	static void Main()
	{
		Component root = new Composite("root");
		root.Add(new Leaf("Leaf A"));
		root.Add(new Leaf("Leaf B"));
		Composite comp = new Composite("Comp C");
		comp.Add(new Leaf("Leaf CA"));
		comp.Add(new Leaf("Leaf CB"));
		root.Add(comp);
		root.Display(1);
		Console.ReadKey();
	}
}