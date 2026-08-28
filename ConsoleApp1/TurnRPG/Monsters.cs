namespace Monsters
{
    public abstract class Entity
    {
        public float hp = 100.0f;
        public float def = 20.0f;
        
        public interactionResult Attack(Entity target)
        {
            bool critical = mathUtil.critical();
            float atk = mathUtil.RandomInt(0, 50) * (critical ? 1 : 2);
            target.GetDmg(atk);
            

            return new interactionResult(target, atk, actingType.Attack);
        }

        public interactionResult Regenerate(Entity target)
        {
            float hp = mathUtil.RandomInt(0, 50);
            target.hp += hp;

            return new interactionResult(target, hp, actingType.Regenerate);
        }

        public void GetDmg(float dmg)
            => this.hp -= mathUtil.ApplyDef(def, dmg);
        
        
        public bool isDead() => this.hp <= 0;
    }

    public class Skeleton : Entity
    {

    }

    public class Zombie : Entity
    {
        
    }
}
