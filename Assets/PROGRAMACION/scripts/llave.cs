using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class llave : MonoBehaviour
{
    public Transform door;

    public bool isUnLocked = true;
    public float doorspeed = 1f;

    public Transform openTranForm;
    public Transform closedTransfor;

    Vector3 targetPosition;
    Animator anim;

    float time;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = closedTransfor.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isUnLocked && door.position != targetPosition)
        {
            door.transform.position = Vector3.Lerp(door.transform.position, targetPosition, time);
            time += Time.deltaTime * doorspeed;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            targetPosition = openTranForm.position;
            anim = GetComponent<Animator>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            targetPosition = closedTransfor.position;
            anim = GetComponent<Animator>();
        }
    }



}
