using _001_Scripts.Enum;
using _001_Scripts.ETC;
using _001_Scripts.Utils;
using UnityEngine;

namespace _001_Scripts.Entity
{
    public abstract class EntityBase : MonoBehaviour
    {
        [SerializeField] public float hp;
        [SerializeField] public float def;

        public bool isDead() => this.hp <= 0f;

        public void TakeDamage(float dmg)
            => this.hp -= MathUtil.ApplyDef(this.def, dmg);

        public virtual interactionResult Attack(EntityBase target)
        {
            bool critical = MathUtil.Critical();
            float atk = MathUtil.RandomInt(0, 50) * (critical ? 1 : 2);
            target.TakeDamage(atk);

            return new interactionResult(target, atk, ActingType.Atk);
        }

        public virtual interactionResult Regenerate(EntityBase target)
        {
            float hp = MathUtil.RandomInt(0, 50);
            target.hp += hp;

            return new interactionResult(target, hp, ActingType.Regen);
        }
    }
}