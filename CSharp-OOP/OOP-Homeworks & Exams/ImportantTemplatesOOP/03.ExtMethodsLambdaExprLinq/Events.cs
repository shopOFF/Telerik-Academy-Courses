namespace _03.ExtMethodsLambdaExprLinq
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Events
    {
        // Идеята на ивента е да ви се съобщи, ще нещо някъде се е случило.
        // Тоест искам да ми се хвърли някакво съобщение, когато някое пропърти или др нещо на даден 
        // метод се промени. Когато даден клас се промени. Можете да се събскрайбнете към дадено нещо
        // и когато това нещо се случи да стартирате даден метод да се случи.
        // Publisher-казва, че нещо някъде се е случило
        // Subscribers-Този, който очаква нещото да се случи и казва какво да се случи след това.
        // Even-тите се дефинират с ключовата дума event
        // Пример:

        // Test the ListWithChangedEvent class.
        //public static void Main()
        //{
        //    // Create a new list.
        //    ListWithChangedEvent list = new ListWithChangedEvent();

        //    // Add and remove items from the list.
        //    Console.WriteLine("----- Adding item 1");
        //    list.Add("item 1");
        //    list.Clear();

        //    // Attach method as a listener
        //    // list.Changed += new ChangedEventHandler(ListOnChanged);
        //    list.Changed += ListOnChanged;

        //    // Attach delegate as a listener
        //    list.Changed += delegate (object sender, EventArgs args)
        //    {
        //        Console.WriteLine("degate(object sender, EventArgs args)");
        //    };

        //    // Attach anonymous type as a listener
        //    list.Changed += (sender, args) => Console.WriteLine("(sender, args) =>");

        //    Console.WriteLine("----- Adding item 2");
        //    list.Add("item 2");

        //    list.Changed -= ListOnChanged;

        //    Console.WriteLine("----- Adding item 3");
        //    list.Add("item 3");
        //}

        //private static void ListOnChanged(object sender, EventArgs eventArgs)
        //{
        //    Console.WriteLine("ListOnChanged(object sender, EventArgs eventArgs)");
        //}


        // ПРИМЕР 2: ПО ОПИСАТЕЛЕН
        // A delegate type for hooking up change notifications.
        //public delegate void ChangedEventHandler(object sender, EventArgs e);

        // A class that works just like ArrayList, but sends event
        // notifications whenever the list changes.
        //public class ListWithChangedEvent : ArrayList
        //{
        //    // An event that clients can use to be notified whenever the
        //    // elements of the list change.
        //    public event ChangedEventHandler Changed; // EventHandler

        //    // Override some of the methods that can change the list;
        //    // invoke event after each
        //    public override int Add(object value)
        //    {
        //        int i = base.Add(value);
        //        this.OnChanged();
        //        return i;
        //    }

        //    public override void Clear()
        //    {
        //        base.Clear();
        //        this.OnChanged();
        //    }

        //    public override object this[int index]
        //    {
        //        set
        //        {
        //            base[index] = value;
        //            this.OnChanged();
        //        }
        //    }

        //    // Invoke the Changed event; called whenever list changes
        //    private void OnChanged()
        //    {
        //        if (this.Changed != null)
        //        {
        //            this.Changed(this, EventArgs.Empty);
        //        }
        //    }
        //}
    }
}
