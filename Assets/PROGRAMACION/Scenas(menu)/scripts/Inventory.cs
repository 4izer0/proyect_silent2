using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    private bool inventoryEnabled;

    public GameObject inventary;

    private int allSlots;

    private int enableadSlots;

    private GameObject[] slot;

    public GameObject slotHolder;





    // Start is called before the first frame update
    void Start()
    {
        allSlots = slotHolder.transform.childCount;

        slot = new GameObject[allSlots];

        for (int i = 0; i <allSlots; i++)
        {
            slot[i] = slotHolder.transform.GetChild(i).gameObject;
            if (slot[i].GetComponent<Slot>().item==null)
            { 
                    slot[i].GetComponent<Slot>().empty = true;
                
            }

        }




    }

    // Update is called once per frame
    void Update()
    {
     
        if ( Input.GetKeyDown(KeyCode.I)) { inventoryEnabled = !inventoryEnabled; }

        if (inventoryEnabled == true)  {inventary.SetActive(true); }
        else { inventary.SetActive(false); }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="items")
        {
            GameObject itemPickeUp = other.gameObject;

            items item = itemPickeUp.GetComponent<items>();

            Additems(itemPickeUp,item.ID,item.type,item.descripcion,item.incon);

        }
    }
    public void Additems(GameObject itemObject,int itemID,string itemType, string itemDescripcion, Sprite itemIcon)
    {
        for (int i = 0; i < allSlots; i++)
        {

            if (slot[i].GetComponent<Slot>().empty)
            {
                itemObject.GetComponent<items>().pickedUp = true;

                slot[i].GetComponent<Slot>().item = itemObject;
                slot[i].GetComponent<Slot>().ID = itemID;

                slot[i].GetComponent<Slot>().type = itemType;
                slot[i].GetComponent<Slot>().descripcion = itemDescripcion;
                slot[i].GetComponent<Slot>().icon = itemIcon;

                itemObject.transform.parent = slot[i].transform;
                itemObject.SetActive(false);

                slot[i].GetComponent<Slot>().UpdateSlot();


                slot[i].GetComponent<Slot>().empty = false;

                return;
            }
            
        }

    }


}
