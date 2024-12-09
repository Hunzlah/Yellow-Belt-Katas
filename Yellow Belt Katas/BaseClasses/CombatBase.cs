using Yellow_Belt_Katas.Interfaces;

namespace Yellow_Belt_Katas;

public class CombatBase : ICombatInterface
{
    protected string name;
    protected int damage;
    protected int health;
    
    public string Name { get => name;}
    public int Health { get => health;}
    public int Damage { get => damage;}
    
    public void TakeDamage(int amount)
    {
        health = health - amount < 0 ? 0 : health - amount;
        Console.WriteLine($"{name} takes {amount} damage. Health: {health}");
        if(health == 0)
            Console.WriteLine($"{name} is defeated");
    }

    public void Attack(CombatBase defender)
    {
        Console.WriteLine($"{name} attacks {defender.name} and deals {damage} damage.");
        defender.TakeDamage(damage);
    }
    public bool IsDead()
    {
        return health <= 0;
    }
}