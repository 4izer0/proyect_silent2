using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo1 : MonoBehaviour
{
    public float damage;


    private void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject.tag=="Player")
        {
            Debug.Log(damage + "DE DAÑO AL ENEMIGO");
            gameObject.GetComponent<AudioSource>().Play();
            gameObject.GetComponent<CapsuleCollider>().enabled = false;

        }
    }


}
