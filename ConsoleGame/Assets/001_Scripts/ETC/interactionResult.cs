using _001_Scripts.Entity;
using _001_Scripts.Enum;

namespace _001_Scripts.ETC
{
    public readonly struct interactionResult
    {
        public readonly EntityBase target;
        public readonly float value;
        public readonly ActingType actingType;


        public interactionResult(EntityBase target, float value, ActingType acType)
        {
            this.target = target;
            this.value = value;
            this.actingType = acType;
        }
    }
}