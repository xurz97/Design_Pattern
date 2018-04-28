//中介者模式:用一个中介对象封装一系列的对象交互,中介者使各对象不需要显示地相互作用,从而使其耦合松散,而且可以独立的改变它们之间的交互
using System;
abstract class Mediator
{
	public abstract void Send(string name, Colleague colleague);
}
abstract class Colleague
{
	protected Mediator mediator;
	public Colleague(Mediator mediator) { this.mediator = mediator; }
}
class ConcreteMediator : Mediator
{
	private ConcreteColleague1 colleague1;
	private ConcreteColleague2 colleague2;
	public ConcreteColleague1 Colleague1
	{
		set { colleague1 = value; }
	}
	public ConcreteColleague2 Colleague2
	{
		set { colleague2 = value; }
	}
	public override void Send(string message, Colleague colleague)
	{
		if (colleague == colleague1) colleague2.Notify(message);
		else colleague1.Notify(message);
	}
}
class ConcreteColleague1 : Colleague
{
	public ConcreteColleague1(Mediator mediator) : base(mediator) { }
	public void Send(string message) { mediator.Send(message, this); }
	public void Notify(string message) { Console.WriteLine("Colleague1:" + message); }
}
class ConcreteColleague2 : Colleague
{
	public ConcreteColleague2(Mediator mediator) : base(mediator) { }
	public void Send(string message) { mediator.Send(message, this); }
	public void Notify(string message) { Console.WriteLine("Colleague2:" + message); }
}
class Program
{
	static void Main()
	{
		ConcreteMediator m = new ConcreteMediator();
		ConcreteColleague1 c1 = new ConcreteColleague1(m);
		ConcreteColleague2 c2 = new ConcreteColleague2(m);
		m.Colleague1 = c1;
		m.Colleague2 = c2;
		c1.Send("How are you?");
		c2.Send("I'm good.");
		Console.ReadKey();
	}
}
