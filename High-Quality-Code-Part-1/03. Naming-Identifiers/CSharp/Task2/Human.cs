public class Human
{
    public GenderType Gender { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }

    public static void Main()
    {
    }

    public void CreateHuman(int age)
    {
        Human human = new Human();
        human.Age = age;

        if (age % 2 == 0)
        {
            human.Name = "John";
            human.Gender = GenderType.Male;
        }
        else
        {
            human.Name = "Jenny";
            human.Gender = GenderType.Female;
        }
    }
}