//备忘录模式:在不破坏封装的前提下,捕获一个对象的内部状态,并在该对象之外保存这个状态,这样可以在以后将对象恢复到原先保存的状态
using System;
class Originator
{
	private string state;
	public string State
	{
		get { return state; }
		set { state = value; }
	}
	public Memento CreateMemento()
	{
		return new Memento(state);
	}
	public void RecoveryMemento(Memento memento)
	{
		state = memento.State;
	}
	public void display()
	{
		Console.WriteLine("State:" + state);
	}
}
class Memento
{
	private string state;
	public Memento(string state)
	{
		this.state = state;
	}
	public string State
	{
		get { return state; }
	}
}
class CareTaker
{
	private Memento memento;
	public Memento Memento
	{
		get { return memento; }
		set { memento = value; }
	}
}
class Program
{
	static void Main()
	{
		Originator o = new Originator();
		o.State = "ON";
		o.display();
		CareTaker c = new CareTaker();
		c.Memento = o.CreateMemento();
		o.State = "OFF";
		o.display();
		o.RecoveryMemento(c.Memento);
		o.display();
		Console.ReadKey();
	}
}
