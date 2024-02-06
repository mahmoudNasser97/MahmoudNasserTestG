using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<ShoppingItem> shop1Items;
    public GameObject itemPrefab;
    public Transform itemPrefabParent;
    void Start()
    {
        DisplayInventory1();
    }  
    public void DisplayInventory1()
    {
        for (int i = 0; i < shop1Items.Count; i++)
        {
            Instantiate(itemPrefab, itemPrefabParent);
        }
    }

    //public void DisplayInventory1()
    //{
    //    for (int i = 0; i < playerInventory.Count; i++)
    //    {
    //        Instantiate(playerObjects, itemPrefabParent);
    //    }
    //    //SetData();
    //}
    ////public void SetData()
    ////{
    ////    for (int i = 0; i < playerInventory.Count; i++)
    ////    {
    ////        playerObjects.itemPrice.text = playerInventory[i].cost.ToString();
    ////        playerObjects.itemImage.sprite = playerInventory[i].icon;
    ////    }
    ////}
}
