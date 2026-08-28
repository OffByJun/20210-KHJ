namespace Monsters
{
    public abstract class Entity
    {
        public float hp = 100.0f;
        

        public abstract interactionResult Attack(Entity target);
        public abstract interactionResult Regenerate(Entity target);
        
        public bool isDead() => this.hp <= 0;
    }

    public class Skeleton : Entity
    {
        public override interactionResult Attack(Entity target)
        {
            bool critical = mathUtil.critical();
            float atk = mathUtil.RandomInt(0, 50) * (critical ? 1 : 2);
            target.hp -= atk;
            

            return new interactionResult(target, atk, actingType.Attack);
        }

        public override interactionResult Regenerate(Entity target)
        {
            float hp = mathUtil.RandomInt(0, 50);
            target.hp += hp;

            return new interactionResult(target, hp, actingType.Regenerate);
        }
    }

    public class Zombie : Entity
    {
        public override interactionResult Attack(Entity target)
        {
            bool critical = mathUtil.critical();
            float atk = mathUtil.RandomInt(0, 50) * (critical ? 1 : 2);
            target.hp -= atk;

            return new interactionResult(target, atk, actingType.Attack);
        }

        public override interactionResult Regenerate(Entity target)
        {

            float hp = mathUtil.RandomInt(0, 100);
            target.hp += hp;

            return new interactionResult(target, hp, actingType.Regenerate);
        }
    }
}
