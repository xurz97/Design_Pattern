//����ģʽ:��һ�������װ��һ������,�Ӷ�����ʹ�ò�ͬ������ѿͻ��˲�����,�������Ŷӻ��߼�¼������־,�����ṩ����ĳ����ͻָ�����
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