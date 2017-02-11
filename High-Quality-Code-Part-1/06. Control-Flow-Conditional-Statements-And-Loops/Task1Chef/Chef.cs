using System;

public class Chef
{
    public void Cook()
    {
        Bowl bowl = this.GetBowl();
        Potato potato = this.GetPotato();
        Carrot carrot = this.GetCarrot();

        bowl.Add(carrot);
        bowl.Add(potato);

        this.Peel(potato);
        this.Peel(carrot);
        this.Cut(potato);
        this.Cut(carrot);
    }

    private Bowl GetBowl()
    {
        var result = new Bowl();

        return result;
    }

    private Potato GetPotato()
    {
        var result = new Potato();

        return result;
    }

    private Carrot GetCarrot()
    {
        var result = new Carrot();

        return result;
    }

    private void Peel(Potato potato)
    {
        throw new NotImplementedException();
    }

    private void Peel(Vegetable carrot)
    {
        throw new NotImplementedException();
    }

    private void Cut(Vegetable potato)
    {
        ////...
    }
}