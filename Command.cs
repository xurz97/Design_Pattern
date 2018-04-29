//命令模式:将一个请求封装成一个对象,从而让你使用不同的请求把客户端参数化,对请求排队或者记录请求日志,可以提供命令的撤销和恢复功能
using System;
class Receiver
{
	public void Action()
	{
		Console.WriteLine("Action()");
	}
}
abstract class Command
{
	protected Receiver receiver;
	public Command(Receiver receiver)
	{
		this.receiver = receiver;
	}
	abstract public void Execute();
}
class ConcreteCommand : Command
{
	public ConcreteCommand(Receiver receiver) : base(receiver) { }
	public override void Execute()
	{
		receiver.Action();
	}
}
class Invoker
{
	private Command command;
	public void SetCommand(Command command)
	{
		this.command = command;
	}
	public void ExecuteCommand()
	{
		command.Execute();
	}
}
class Program
{
	static void Main()
	{
		Receiver r = new Receiver();
		Command c = new ConcreteCommand(r);
		Invoker i = new Invoker();
		i.SetCommand(c);
		i.ExecuteCommand();
		Console.ReadKey();
	}
}