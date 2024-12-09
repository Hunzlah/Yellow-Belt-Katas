using Yellow_Belt_Katas.Interfaces;

namespace Yellow_Belt_Katas;

public class Merchant : InteractableBase
{
    private List<string> inventoryItems;

    public Merchant(string _name, string _dialogue, List<string> _inventoryItems)
    {
        name = _name;
        dialogue = _dialogue;
        inventoryItems = _inventoryItems;
    }

    private void Trade()
    {
        foreach (var item in inventoryItems)
        {
            Console.WriteLine($"{item}");
        }
    }
    

    public override void Interact()
    {
        Console.WriteLine($"You meet a {name}!");
        base.Interact();
        Trade();
    }
}