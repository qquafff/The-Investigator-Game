using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class OpenInventory : MonoBehaviour
{
    public static bool InventoryOpen = false;

    public GameObject InventoryUI;
    public cameraController camCtrl;
    public characterController charCtrl;


    private void Update()
    {
        //Opens/Closes the inventory
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (InventoryOpen)
            {
                Close();
            } else
            {
                Open();
            }
     
        }
    }
    //Open/Close functions
    public void Close()
    {
        InventoryUI.SetActive(false);
        //Time.timeScale = 1f;
        InventoryOpen = false;
        Cursor.lockState = CursorLockMode.Locked;
        camCtrl.sensitivity = 5f;
        charCtrl.speed = 10f;
    }

    void Open()
    {
        InventoryUI.SetActive(true);
        //Time.timeScale = 0f;
        InventoryOpen = true;
        Cursor.lockState = CursorLockMode.None;
        camCtrl.sensitivity = 0f;
        charCtrl.speed = 0f;
    }
}
