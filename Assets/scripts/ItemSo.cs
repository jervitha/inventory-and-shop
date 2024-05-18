using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "item", menuName = "scriptableObjects/item")]
public class ItemSo : ScriptableObject
{
    public Sprite sprite;
    public string itemName;
    public int maxStackSize;
    public ItemRarity itemRarity;
    public float price;
    
}


public enum ItemRarity
{
    low,
    rare,
    epic,
    legendary


}