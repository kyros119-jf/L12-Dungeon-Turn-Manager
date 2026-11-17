
public class Hero
{
    public string Name { get; set; }
    public string Class { get; set; }
    public int Health { get; set; }

    public Hero(string name, string heroClass, int health)
    {
        Name = name;
        Class = heroClass;
        Health = health;
    }
}
