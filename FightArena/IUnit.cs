public interface IUnit
{
    string Name { get; }
    int Health { get; }
    void Attack(IUnit target);
}