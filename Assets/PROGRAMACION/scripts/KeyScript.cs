using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public llave doorloOpen;



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            doorloOpen.isUnLocked = true;

        }

        Destroy(gameObject);
    }
}

