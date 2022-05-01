using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daño : MonoBehaviour
{
    [SerializeField]
    private int daño;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "enemigo")
        {
            other.GetComponent<datosdelenemy>().vida -= daño;

        }
    }







}


