namespace Yellow_Belt_Katas;

public class InteractableBase
{
    protected string name;
    protected string dialogue;
    
    public virtual void Interact()
    {
        Console.WriteLine($"{name} says: {dialogue}");
    }
}