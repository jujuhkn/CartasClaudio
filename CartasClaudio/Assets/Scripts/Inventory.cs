using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;

    public Image[] slots;
    public Sprite emptySprite;

    void Awake()
    {
        instance = this;
    }

    public void AddItem(Sprite item)
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].sprite == emptySprite)
            {
                slots[i].sprite = item;
                return;
            }
        }
    }
}