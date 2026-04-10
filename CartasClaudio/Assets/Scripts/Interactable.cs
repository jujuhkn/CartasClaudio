using UnityEngine;

public class Interactable : MonoBehaviour
{
    [TextArea]
    public string hintText; // dica ao passar o mouse

    public bool isCollectable;
    public Sprite itemIcon;

    private void OnMouseEnter()
    {
        UIManager.instance.ShowHint(hintText);
    }

    private void OnMouseExit()
    {
        UIManager.instance.HideHint();
    }

    private void OnMouseDown()
    {
        if (isCollectable)
        {
            Inventory.instance.AddItem(itemIcon);
            Destroy(gameObject);
        }
        else
        {
            UIManager.instance.ShowHint(hintText);
        }
    }
}