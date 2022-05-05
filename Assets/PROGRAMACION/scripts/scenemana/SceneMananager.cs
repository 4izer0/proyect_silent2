using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMananager : MonoBehaviour
{
    public DatosJuador vidaPlayer;
    public GameObject gOS;
    public float hp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hp = vidaPlayer.vidaPlayer;
        
        if (vidaPlayer.vidaPlayer < 1)
        {
            print("Print");
            Invoke("ActivateGameOVerScreen", 2f);
        }

    }

    public void ActivateGameOVerScreen()
    {
        gOS.SetActive(true);
    }








}
