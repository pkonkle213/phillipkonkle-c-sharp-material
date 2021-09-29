namespace TechElevator.Enums
{
    public class Goblin : GameEnemy
    {
        public override string Name
        {
            get
            {
                return "Goblin";
            }
        }

        public override void Attack(int baseDamage, DamageType damageType)
        {
            if (damageType == DamageType.Stab)
            {
                // Goblins are vulnerable to stabbing
                HitPoints -= baseDamage * 2;
            }
            else if (damageType == DamageType.ExistentialDread)
            {
                // Goblins immediately die when impacted by existential dread. Teaching them OOP would be fatal.
                HitPoints = 0;
            }
            else
            {
                HitPoints -= baseDamage;
            }
        }
    }
}
