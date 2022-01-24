namespace CollectionsDemo;

public class Cat
{
    public string Name { get; set; }
    public int Height { get; }
    public int Weight { get; }

    public Cat(string name, int height, int weight)
    {
        Name = name;
        Height = height;
        Weight = weight;
    }

    public override string ToString() => $"Name: {Name}\nHeight:{Height}\nWeight: {Weight}\n";

}