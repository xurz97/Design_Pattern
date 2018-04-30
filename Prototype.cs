//原型模式:用原型实例指定创建对象的种类,并且通过拷贝这些原型创建新的对象
using System;
abstract class Prototype
{
	private string id;
	public Prototype(string id) { this.id = id; }
	public string Id { get { return id; } set { id = value; } }
	public abstract Prototype Clone();
}
class ConcretePrototype : Prototype
{
	public ConcretePrototype(string id) : base(id) { }
	public override Prototype Clone()
	{
		return (Prototype)this.MemberwiseClone();
	}
}
class Program
{
	static void Main()
	{
		ConcretePrototype p1 = new ConcretePrototype("p1");
		ConcretePrototype c1 = (ConcretePrototype)p1.Clone();
		Console.WriteLine("Cloned: {0}", c1.Id);
		Console.ReadKey();
	}
}