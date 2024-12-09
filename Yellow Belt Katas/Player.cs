using Yellow_Belt_Katas.Interfaces;

namespace Yellow_Belt_Katas;

public class Player : CombatBase
{
    public Player(string pName, int pHealth, int pLevel, int pXp, int pDamage)
    {
        name = pName;
        health = pHealth;
        level = pLevel;
        xp = pXp;
        damage = pDamage;
    }

    private int level;
    private int xp;
    
    public int Level { get => level; set => level = value < 0 ? 0 : value; }
    public int Xp { get => xp; set => xp = value < 0 ? 0 : value; }


    public void Heal(int amount)
    {
        health += amount;
        Console.WriteLine($"{name} gains {amount} health. Health: {health}");
    }
    public void GainXp(int amount)
    {
        xp += amount;
        if(xp >= 100) LevelUp();
        Console.WriteLine($"{name} gains {amount} experience points.");
    }
    private void LevelUp()
    {
        while (xp >= 100)
        {
            level += 1;
            xp -= 100;
        }
        Console.WriteLine($"Congratulations! You leveled up to Level {level}.");
    }
}