using Yellow_Belt_Katas.Interfaces;

namespace Yellow_Belt_Katas;

public class Enemy : CombatBase, IInteractableInterface
{
    public Enemy(string eName, int eHealth, int eDamage)
    {
        name = eName;
        health = eHealth;
        damage = eDamage;
    }

    public void Interact()
    {
        Console.WriteLine($"A wild {name} appears with {health} health and {damage} damage!");
    }
}