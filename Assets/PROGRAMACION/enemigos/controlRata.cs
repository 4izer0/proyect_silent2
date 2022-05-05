using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class controlRata : MonoBehaviour
{
    public GameObject Player;


    // Update is called once per frame
    void Update()
    {
        this.GetComponent<NavMeshAgent>().SetDestination(Player.transform.position);
    }
}
