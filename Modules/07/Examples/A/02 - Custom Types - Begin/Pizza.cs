﻿using System.Text;

record class Pizza
{
    private readonly List<Topping> _toppings = [];

    public Pizza(params IEnumerable<Topping> toppings)
    {
        _toppings = toppings.ToList();
    }

    public void Add(Topping kind)
    {
        _toppings.Add(kind);
    }

    public override string ToString()
    {
        StringBuilder sb = new();
        sb.AppendLine($"Pizza with ");

        foreach (Topping topping in _toppings)
        {
            sb.AppendLine($"\t{topping}");
        }

        sb.AppendLine("with oregano on top");

        return sb.ToString();
    }
}