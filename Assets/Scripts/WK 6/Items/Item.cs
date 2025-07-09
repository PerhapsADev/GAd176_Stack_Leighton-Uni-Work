using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Item Generic Weapon", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public int itemID;
    public Sprite ItemIncon;
    [SerializeField] private Item[] items;
    [SerializeField] private Item[] item = new Item[8];

    public void AnnounceNameInConsole()
    {
        Debug.Log("items in the the slot is " + item[0].itemName);
    }
}
