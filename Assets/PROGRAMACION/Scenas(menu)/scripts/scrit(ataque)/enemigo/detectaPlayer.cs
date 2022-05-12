using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectaPlayer : MonoBehaviour
{
    public Transform enemigo;
    public Transform player;
    public float velocidad;

    private bool activo;
    private Vector3 playerPosicion;


    private void Update()
    {
        playerPosicion = new Vector3(player.position.x, enemigo.position.y, player.position.z);

        if (activo == true)
        {
            enemigo.transform.position = Vector3.MoveTowards(transform.position, playerPosicion, velocidad * Time.deltaTime);
            enemigo.transform.LookAt(playerPosicion);

        }


    }


    private void OnTriggerEnter(Collider other)
    {
       if(other.tag=="Player")
        {
            activo = true;
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            activo = false;
        }

    }



}
