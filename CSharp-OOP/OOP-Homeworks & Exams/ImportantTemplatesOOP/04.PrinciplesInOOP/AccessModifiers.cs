namespace _04.PrinciplesInOOP
{
    public class AccessModifiers
    {
        // Желателно е да показваме възможно най-малко!!!

        //        Access modifiers in C#
        //public – access is not restricted
        //private – access is restricted to the containing type
        //protected – access is limited to the containing type and types derived from it // само от наследниците е достъпно
        //internal – access is limited to the current assembly
        //protected internal – access is limited to the current assembly or types derived from the containing class
    }
    //class Creature
    //{
    //    protected string Name { get; private set; }
    //    protected void Walk()
    //    {
    //        Console.WriteLine("Walking ...");
    //    }
    //    private void Talk()
    //    {
    //        Console.WriteLine("I am creature ...");
    //    }

    //}
    //class Mammal : Creature
    //{
    //    // base.Walk() can be invoked here
    //    // base.Talk() cannot be invoked here
    //    // this.Name can be read but cannot be modified here
    //}

    // втори пример :
    //class Dog : Mammal
    //{
    //    public string Breed { get; private set; }
    //    // base.Talk() cannot be invoked here (it is private)
    //}

    //class InheritanceAndAccessibility
    //{
    //    static void Main()
    //    {
    //        Dog joe = new Dog(6, "Labrador");
    //        Console.WriteLine(joe.Breed);
    //        // joe.Walk() is protected and can not be invoked
    //        // joe.Talk() is private and can not be invoked
    //        // joe.Name = "Rex"; // Name cannot be accessed here
    //        // joe.Breed = "Shih Tzu"; // Can't modify Breed
    //    }
    //}
}
