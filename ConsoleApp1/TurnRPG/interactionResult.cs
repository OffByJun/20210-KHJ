namespace Monsters;

public readonly struct interactionResult
{
    public readonly Entity target;
    public readonly float value;
    
    
    public interactionResult(Entity target, float value)
    {
        this.target = target;
        this.value = value;
    }
}