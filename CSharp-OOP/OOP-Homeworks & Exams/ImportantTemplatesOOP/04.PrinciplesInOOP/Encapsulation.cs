namespace _04.PrinciplesInOOP
{
    public class Encapsulation
    {
        //        Encapsulation
        //Encapsulation hides the implementation details
        //Class announces some operations(methods) available for its clients – its public interface
        //All data members(fields) of a class should be hidden
        //Accessed via properties(read-only and read-write)
        //No interface members should be hidden

        //        Encapsulation – Example
        //Data fields are private
        //Constructors and accessors are defined(getters and setters)

        //        Fields are always declared private
        //Accessed through properties in read-only or read-write mode
        //Constructors are almost always declared public
        //Interface methods are always public
        //Not explicitly declared with public
        //Non-interface methods are declared
        //private / protected

        //        Encapsulation – Benefits
        //Ensures that structural changes remain local:
        //Changing the class internals does not affect any code outside of the class
        //Changing methods' implementation does not reflect the clients using them
        //Encapsulation allows adding some logic when accessing client's data
        //E.g.validation on modifying a property value
        //Hiding implementation details reduces complexity → easier maintenance

    }
}
