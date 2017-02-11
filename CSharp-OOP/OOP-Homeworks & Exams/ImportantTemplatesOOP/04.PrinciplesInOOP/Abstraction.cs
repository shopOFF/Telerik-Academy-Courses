namespace _04.PrinciplesInOOP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Abstraction
    {
        // АБСТРАКЦИЯТА- ОПИТВАТЕ СЕ ПО НЯКАКЪВ НАЧИН ДА НАПРАВИТЕ ДАДЕН ОБЕКТ ДОСТИЖИМ И ДО ДРУГИ ОБЕКТ И ДА БЪДЕ НЕ ТОЛКОВА КОНКРЕТЕН.
        // ДА ВЗИМА ОБЩИТЕ НЕЩА МЕЖДУ ОБЕКТИ. ОСНОВНИТЕ НЕЩА, КОЙТО СА НИ НУЖНИ ЗА ДАДЕНАТА ПРОГРАМА(ЦЕЛ,КЛАС).
        // КОЛКО СА ПО АБСТРАКТНИ КЛАСОВЕТЕ И ИНТЕРФЕЙСИТЕ ТОЛКОВА ПО-ЛЕСНО ТЕ СЕ ПРЕИЗПОЛЗВАТ!!!
        // Abstraction means ignoring irrelevant features, properties, or functions and emphasizing the relevant ones...
        //... relevant to the given project
        //With an eye to future reuse in similar projects
        //Abstraction helps managing complexity
        //!!!
        //        Abstraction is something we do every day
        //Looking at an object, we see those things about it that have meaning to us
        //We abstract the properties of the object, and keep only what we need
        //E.g.students get "name" but not "color of eyes"
        //Allows us to represent a complex reality in terms of a simplified model
        //Abstraction highlights the properties of an entity that we need and hides the others
        //        In.NET object-oriented programming abstraction is achieved in several ways:
        //Abstract classes
        //Interfaces
        //Inheritance

        #region INTERFACES !!!


        //        An interface defines a set of operations(methods) that given object should perform
        //Also called "contract" for providing a set of operations
        //Defines abstract behavior
        //Interfaces provide abstractions
        //You invoke the abstract actions
        //Without worrying how it is internally implemented
        //        Interfaces describe a prototype of group of methods(operations), properties and events
        //Can be implemented by a given class or structure
        //Define only the prototypes of the operations
        //No concrete implementation is provided
        //Can be used to define abstract data types
        //Can be inherited(extended) by other interfaces
        //Can not be instantiated

        // пример:
        //public interface IShape
        //{
        //    void SetPosition(int x, int y);
        //    int CalculateSurface();
        //}
        //public interface IMovable
        //{
        //    void Move(int deltaX, int deltaY);
        //}
        //public interface IResizable
        //{
        //    void Resize(int weight);
        //    void Resize(int weightX, int weightY);
        //    void ResizeByX(int weightX);
        //    void ResizeByY(int weightY);
        //}

        //public interface IPerson
        //{
        //    DateTime DateOfBirth  // Property DateOfBirth
        //    {
        //        get;
        //        set;
        //    }

        //    int Age  // Property Age (read-only)
        //    {
        //        get;
        //    }

        //    void Print(); // Method for printing
        //}
        //Interface Implementation!!!!
        //        Classes and structures can implement(support) one or several interfaces
        // class Rectangle : IShape
        //        {
        //            public void SetPosition(int x, int y) { … }
        //            public int CalculateSurface() { … }
        //        }
        //        Implementer classes must implement all interface methods
        //Or should be declared abstract
        //        Interface Implementation
        //class Rectangle : IShape, IMovable
        //        {
        //            private int x, y, width, height;
        //            public void SetPosition(int x, int y) // IShape
        //            {
        //                this.x = x;
        //                this.y = y;
        //            }
        //            public int CalculateSurface() // IShape
        //            {
        //                return this.width * this.height;
        //            }
        //            public void Move(int deltaX, int deltaY) // IMovable
        //            {
        //                this.x += deltaX;
        //                this.y += deltaY;
        //            }
        //        }
        #endregion

        #region Abstract CLASSES


        // АБСТРАКТНИ КЛАСОВЕ: ТЕ СА КОМБИНАЦИЯ МЕЖДУ ИНТЕРФЕЙС И КЛАС: ТОЙ МОЖЕ ДА ИМПЛЕМЕНТИРА НАКОИ НЕЩА И НЯКОИ ДА ОСТАВИ, НАСЛЕДНИЦИТЕ 
        // МУ ДА ИМПЛЕМЕНТИРАТ. МОЖЕ ДА ИМПЛЕМЕНТИРА ВСИЧКО, НО МОЖЕ И ДА НЕ ИМПЛЕМЕНТИРА НИЩО!!!
        //        Abstract classes are special classes defined with the keyword abstract
        //Mix between class and interface
        //Partially implemented or fully unimplemented
        //Not implemented methods are declared abstract and are left empty
        //Cannot be instantiated directly
        //Child classes should implement all abstract methods or be declared as abstract too

        //        Abstract methods are empty methods without implementation
        //The implementation is intentionally left for the descendent classes
        //When a class contains at least one abstract method, it is called abstract class
        //Abstract classes model abstract concepts
        //E.g.person, object, item, movable object

        // Пример:
        //abstract class MovableShape : IShape, IMovable
        //{
        //    private int x, y;
        //    public void Move(int deltaX, int deltaY)
        //    {
        //        this.x += deltaX;
        //        this.y += deltaY;
        //    }
        //    public void SetPosition(int x, int y)
        //    {
        //        this.x = x;
        //        this.y = y;
        //    }
        //    public abstract int CalculateSurface();
        //}
        // друг пример:
        //public abstract class Animal : IComparable<Animal>
        //{
        //    // Abstract methods
        //    public abstract string GetName();
        //    public abstract int Speed { get; }
        //    // Non-abstract method
        //    public override string ToString()
        //    {
        //        return "I am " + this.GetName();
        //    }
        //    // Interface method
        //    public int CompareTo(Animal other)
        //    {
        //        return this.Speed.CompareTo(other.Speed);
        //    }
        //}
        //public class Turtle : Animal
        //{
        //    public override int Speed { get { return 1; } }

        //    public override string GetName()
        //    { return "turtle"; }
        //}

        //public class Cheetah : Animal
        //{
        //    public override int Speed { get { return 100; } }

        //    public override string GetName()
        //    { return "cheetah"; }
        //}

        // РАЗЛИКАТА МЕЖДУ ИНТЕРФЕЙСИТЕ И АБСТРАКТНИТЕ КЛАСОВЕ:
        //        Interfaces vs.Abstract Classes
        //C# interfaces are like abstract classes, but in contrast interfaces:
        //Can not contain methods with implementation
        //All interface methods are abstract
        //Members do not have scope modifiers
        //Their scope is assumed public
        //But this is not specified explicitly
        //Can not define fields, constants, inner types and constructors!!! НЕ МОЖЕ ДА СЕ ДЕФИНИРАТ В ИНТЕРФЕЙСИТЕ- ПОЛЕТА,КОНСТАТНТИ , КОНСТРУКТОРИ 
        #endregion
    }
}
