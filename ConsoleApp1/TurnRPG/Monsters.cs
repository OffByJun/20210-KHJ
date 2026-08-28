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
            Random rnd = new Random();

            float atk = rnd.Next(0, 100);
            target.hp -= atk;

            return new interactionResult(target, atk);
        }

        public override interactionResult Regenerate(Entity target)
        {
            Random rnd = new Random();

            float hp = rnd.Next(0, 100);
            target.hp += hp;

            return new interactionResult(target, hp);
        }
    }

    public class Zombie : Entity
    {
        public override interactionResult Attack(Entity target)
        {
            Random rnd = new Random();

            float atk = rnd.Next(0, 100);
            target.hp -= atk;

            return new interactionResult(target, atk);
        }

        public override interactionResult Regenerate(Entity target)
        {
            Random rnd = new Random();

            float hp = rnd.Next(0, 100);
            target.hp += hp;

            return new interactionResult(target, hp);
        }
    }
}
