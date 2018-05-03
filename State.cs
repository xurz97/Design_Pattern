//状态模式:允许对象在内部状态发生改变时改变它的行为,对象看起来好像修改了它的类
using System;
abstract class State
{
	public abstract void Handle(Context context);
}
class ConcreteStateA : State
{
	public override void Handle(Context context)
	{
		context.State = new ConcreteStateB();
	}
}
class ConcreteStateB : State
{
	public override void Handle(Context context)
	{
		context.State = new ConcreteStateA();
	}
}
class Context
{
	private State state;
	public Context(State state)
	{
		this.state = state;
	}
	public State State
	{
		get { return state; }
		set
		{
			state = value;
			Console.WriteLine("Current state:" + state.GetType().Name);
		}
	}
	public void Request()
	{
		state.Handle(this);
	}
}
class Program
{
	static void Main()
	{
		Context c = new Context(new ConcreteStateA());
		c.Request();
		c.Request();
		c.Request();
		c.Request();
		Console.ReadKey();
	}
}