using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public GameObject ItemToEquip;

    public GameObject DeactiveItem1;

    public GameObject DeactiveItem2;

    public GameObject DeactiveItem3;

    public GameObject DeactiveItem4;

    //Equips the selected item
    public void onClick()
    {
        ItemToEquip.SetActive(true);
        DeactiveItem1.SetActive(false);
        DeactiveItem2.SetActive(false);
        DeactiveItem3.SetActive(false);
        DeactiveItem4.SetActive(false);
    }
}
