namespace Yellow_Belt_Katas.Interfaces;

public interface ICombatInterface
{
    public void Attack(CombatBase defender);
    public void TakeDamage(int amount);
    public bool IsDead();
}