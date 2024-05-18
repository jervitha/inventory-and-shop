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


    private void Start()
    {
        itemDescription.SetActive(false);
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
}
