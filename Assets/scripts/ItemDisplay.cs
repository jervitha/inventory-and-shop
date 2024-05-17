using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemDisplay : MonoBehaviour
{
    public ItemSo itemSo;
    [SerializeField] private Image itemImage;
    [SerializeField] private TextMeshProUGUI itemCountText;
    public int itemCurrentCount;


    public void Start()
    {
        UpdateItem(itemSo);
    }

    public void UpdateItem(ItemSo _itemSo)
    {
        itemSo = _itemSo;
        itemImage.sprite = itemSo.sprite;
        itemCountText.text = itemCurrentCount.ToString();

        

    }
    public void itemPress()
    {
        Actions.OnitemSelected(this);
    }
}
