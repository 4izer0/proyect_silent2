using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class items : MonoBehaviour
{
    public int ID;
    public string type;
    public string descripcion;
    public Sprite incon;

    [HideInInspector]
    public bool pickedUp;

    [HideInInspector]
    public bool equipeed;

    [HideInInspector]
    public GameObject WeaponManager;

    [HideInInspector]
    public GameObject weapon;

    public bool playersWeapon;

    private void Start()
    {
        WeaponManager = GameObject.FindWithTag("items");
        
        if (!playersWeapon)
        {
            int allwepons = WeaponManager.transform.childCount;

            for (int i = 0; i < allwepons; i++)
            {
                if (WeaponManager.transform.GetChild(i).gameObject.GetComponent<items>().ID==ID)
                {
                    weapon = WeaponManager.transform.GetChild(i).gameObject;
                }
            }
        }
    }

    private void Update()
    {
        if (equipeed)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                equipeed = false;
            }
            if (equipeed==false)
            {
                gameObject.SetActive(false);
            }

        }



    }

    public void itemsUsage()
    {
        if (type=="weapon")
        {
            weapon.SetActive(true);

            weapon.GetComponent<items>().equipeed = true;
        }
    }

}
