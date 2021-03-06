using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerClickHandler
{

    public GameObject item;
    public int ID;
    public string type;
    public string descripcion;

    public bool empty;
    public Sprite icon;

    public Transform slotIconGameObject;

    private void Start()
    {
        slotIconGameObject = transform.GetChild(0);
    }

    public void UpdateSlot()
    {
        slotIconGameObject.GetComponent<Image>().sprite = icon;
    }

    public void Useitems()
    {
        item.GetComponent<items>().itemsUsage();
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        Useitems();
    }
    
}
