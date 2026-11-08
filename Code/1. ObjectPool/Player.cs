namespace ObjectPool.Model;

public class Player(int id, string name, int hp, int mp)
{
    public int Id { get; private set; } = id;
    public string Name { get; private set; } = name;
    public int HP { get; private set; } = hp;
    public int MP { get; private set; } = mp;

    public Player SetName(string name)
    {
        Name = name;
        return this;
    }
    public Player SetHP(int hp)
    {
        if(hp >= 0) HP = hp;
        return this;
    }
    public Player SetMP(int mp)
    {
        if(mp >= 0) MP = mp;
        return this;
    }
}