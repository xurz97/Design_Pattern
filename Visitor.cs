//访问者模式:表示一个作用于某对象结构中的各元素的操作,它使你可以在不改变各元素类的前提下定义作用于这些元素的新操作
using System;
using System.Collections.Generic;
abstract class Visitor
{
    public abstract void VisitConcreteElementA(ConcreteElementA concreteElementA);
    public abstract void VisitConcreteElementB(ConcreteElementB concreteElementB);
}
class ConcreteVisitor1 : Visitor
{
    public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
    {
        Console.WriteLine("{0} visit {1}", this.GetType().Name, concreteElementA.GetType().Name);
    }
    public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
    {
        Console.WriteLine("{0} visit {1}", this.GetType().Name, concreteElementB.GetType().Name);
    }
}
class ConcreteVisitor2 : Visitor
{
    public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
    {
        Console.WriteLine("{0} visit {1}", this.GetType().Name, concreteElementA.GetType().Name);
    }
    public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
    {
        Console.WriteLine("{0} visit {1}", this.GetType().Name, concreteElementB.GetType().Name);
    }
}
abstract class Element
{
    public abstract void Accept(Visitor visitor);
}
class ConcreteElementA : Element
{
    public override void Accept(Visitor visitor)
    {
        visitor.VisitConcreteElementA(this);
    }
    public void OperationA() { }
}
class ConcreteElementB : Element
{
    public override void Accept(Visitor visitor)
    {
        visitor.VisitConcreteElementB(this);
    }
    public void OperationB() { }
}
class ObjectStructure
{
    private IList<Element> elements = new List<Element>();
    public void Attach(Element element)
    {
        elements.Add(element);
    }
    public void Detach(Element element)
    {
        elements.Remove(element);
    }
    public void Accept(Visitor visitor)
    {
        foreach (Element e in elements)
        {
            e.Accept(visitor);
        }
    }
}
class Program
{
    static void Main()
    {
        ObjectStructure o = new ObjectStructure();
        o.Attach(new ConcreteElementA());
        o.Attach(new ConcreteElementB());
        ConcreteVisitor1 v1 = new ConcreteVisitor1();
        ConcreteVisitor2 v2 = new ConcreteVisitor2();
        o.Accept(v1);
        o.Accept(v2);
        Console.ReadKey();
    }
}