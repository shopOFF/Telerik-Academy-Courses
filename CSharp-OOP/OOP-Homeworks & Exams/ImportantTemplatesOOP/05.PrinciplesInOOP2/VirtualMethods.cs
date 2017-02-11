namespace _05.PrinciplesInOOP2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class VirtualMethods
    {
        // ПРИМЕР МНОГО ДОБЪР: VirtualMethodsExample
        // ВИРТУАЛНИТЕ МЕТОДИ : ТЕ МОГЪТ ДА СЕ ПРЕЗАПИСВАТ(ПРОМЕНЯТ), ОТ НАСЛЕДЯВАЩИТЕ ГИ КЛАСОВЕ И ТЕХНИТЕ МЕТОДИ!

        //        Virtual method is
        //Defined in a base class and can be changed(overridden) in the descendant classes
        //Can be called through the base class' interface
        //Virtual methods are declared through the keyword virtual
        // public virtual void Draw()
        //        { … }
        //        Methods declared as virtual in a base class can be overridden using the keyword override
        //         public override void Draw()
        //    { … }

        //        More about Virtual Methods
        //Abstract methods are purely virtual
        //If a method is abstract → it is virtual as well
        //Abstract methods are designed to be changed(overridden) later
        //Interface members are also purely virtual
        //They have no default implementation and are designed to be overridden in a descendent class
        //Virtual methods can be hidden through the new keyword:
        // public new double CalculateSurface() { return … }

        //        The override Modifier
        //Using override we can modify a method or property
        //An override method provides a replacement implementation of an inherited member
        //You cannot override a non-virtual or static method
        //The overridden base method must be virtual, abstract, or override

        //        How it works?
        //Polymorphism ensures that the appropriate method of the subclass is called through its base class' interface
        //Polymorphism is implemented using a technique called late method binding
        //The exact method to be called is determined at runtime, just before performing the call
        //Applied for all abstract/virtual methods
        //Note: Late binding is a bit slower than normal(early) binding

        //public abstract class Figure
        //{
        //public abstract double CalcSurface();
        //}
        //public class Square : Figure
        //{
        //    public override double CalcSurface() { return … }
        //}
        //public class Circle : Figure
        //{
        //    public override double CalcSurface() { return … }
        //}
        //Figure f1 = new Square(...);
        //Figure f2 = new Circle(...);
        //// This will call Square.CalcSurface()
        //int surface = f1.CalcSurface();
        //// This will call Circle.CalcSurface()
        //int surface = f2.CalcSurface();


        // ПРИМЕР МНОГО ДОБЪР: VirtualMethodsExample
    }
}
