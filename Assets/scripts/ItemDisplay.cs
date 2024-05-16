using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemDisplay : MonoBehaviour
{
    public ItemSo itemSo;
    [SerializeField] private Image itemImage;
    [SerializeField] private TextMeshProUGUI itemName;

    public void UpdateItem(ItemSo _itemSo)
    {
        itemSo = _itemSo;
        itemImage.sprite = itemSo.sprite;
        itemImage.color = new Color(0, 1, 1);

    }
}
