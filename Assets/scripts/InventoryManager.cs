using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class InventoryManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameText,rarityText,priceText;
    [SerializeField] private Button buyButton, sellButton;
    [SerializeField] private GameObject itemDescription;
    [SerializeField] private List<ItemDisplay> items;
    [SerializeField] private GameObject itemPrefab;
    [SerializeField] private Transform itemParent;
    [SerializeField] private ItemSo _itemSo;


    private void Start()
    {
        itemDescription.SetActive(false);
        GetItem(_itemSo,5);
    }
    private void OnEnable()
    {
        Actions.OnitemSelected += OnItemPressed;
        
    }
    private void OnDisable()
    {
        Actions.OnitemSelected -= OnItemPressed;
    }

    private void OnItemPressed(ItemDisplay itemDisplay)
    {
        Debug.Log(itemDisplay);
        itemDescription.SetActive(true);
        nameText.text = itemDisplay.itemSo.name;
        rarityText.text = itemDisplay.itemSo.itemRarity.ToString();
        priceText.text = itemDisplay.itemSo.price.ToString();

    }
    private void GetItem(ItemSo _itemSo,int count)
    {
        bool isItemalreadyinList=false;
        foreach(ItemDisplay itemDisplay in items)
        {
            if (itemDisplay.itemSo == _itemSo)
            {
                isItemalreadyinList = true;
               
            }
          

        }
        if(isItemalreadyinList)
        {

        }
        else
        {
           GameObject newItem= Instantiate(itemPrefab, itemParent);
            newItem.gameObject.GetComponent<ItemDisplay>().UpdateItem(_itemSo, count);
            items.Add(newItem.GetComponent<ItemDisplay>());
        }
    }
}
