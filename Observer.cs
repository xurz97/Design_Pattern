//观察者模式:定义对象间的一种一对多的依赖关系,当一个对象的状态发生改变时,所有依赖于它的对象都得到通知并被自动更新
using System;
using System.Collections.Generic;
abstract class Subject
{
	private IList<Observer> observers = new List<Observer>();
	public void Attach(Observer observer)
	{
		observers.Add(observer);
	}
	public void Detach(Observer observer)
	{
		observers.Remove(observer);
	}
	public void Notify()
	{
		foreach (Observer o in observers)
		{
			o.Update();
		}
	}
}
abstract class Observer
{
	public abstract void Update();
}
class ConcreteSubject : Subject
{
	private string subjectState;
	public string SubjectState
	{
		get { return subjectState; }
		set { subjectState = value; }
	}
}
class ConcreteObserver : Observer
{
	private string name;
	private string observerState;
	private ConcreteSubject subject;
	public ConcreteObserver(ConcreteSubject subject, string name)
	{
		this.subject = subject;
		this.name = name;
	}
	public override void Update()
	{
		observerState = subject.SubjectState;
		Console.WriteLine("Observer {0}'s state is {1}", name, observerState);
	}
}
class Program
{
	static void Main()
	{
		ConcreteSubject s = new ConcreteSubject();
		s.Attach(new ConcreteObserver(s, "X"));
		s.Attach(new ConcreteObserver(s, "Y"));
		s.Attach(new ConcreteObserver(s, "Z"));
		s.SubjectState = "ABC";
		s.Notify();
		Console.ReadKey();
	}
}