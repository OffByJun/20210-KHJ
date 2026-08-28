namespace Monsters;

public readonly struct interactionResult
{
    public readonly Entity target;
    public readonly float value;
    public readonly actingType actingType;
    
    
    public interactionResult(Entity target, float value, actingType acType)
    {
        this.target = target;
        this.value = value;
        this.actingType = acType;
    }
}