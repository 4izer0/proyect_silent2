using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INVENTARIO : MonoBehaviour
{
    [SerializeField] private GameObject canvas;

   


    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (canvas.activeSelf)
            {
                canvas.SetActive(false);
            }
            else
            {
                canvas.SetActive(true);
            }


        }
    }
}