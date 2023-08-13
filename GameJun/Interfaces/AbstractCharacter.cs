namespace GameJun.Interfaces;

public abstract class AbstractCharacter
{
    protected int health;
    protected int defense;
    protected int damage;
    protected string name;
    public int Health { get { return health; } }

    // Атаковать другого игрока
    public abstract void Attack(AbstractCharacter other);
    // Получить количество урона (учитывая параметр защиты)
    public abstract void Damage(int amount);
    public abstract string Name();
    public abstract bool IsAlive();
}