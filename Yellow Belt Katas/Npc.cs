using Yellow_Belt_Katas.Interfaces;

namespace Yellow_Belt_Katas;

public class Npc: InteractableBase
{
    public Npc(string _name, string _dialogue)
    {
        name = _name;
        dialogue = _dialogue;
    }

    public override void Interact()
    {
        Console.WriteLine($"You encounter a {name}");
        base.Interact();
    }
}