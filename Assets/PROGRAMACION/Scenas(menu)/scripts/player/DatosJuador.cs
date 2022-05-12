using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class DatosJuador : MonoBehaviour
{
    public FirstPersonController bPM;
    public Attack Bpm;
        
    public int vidaPlayer;
    public Slider vidaVisual;




    private void Update()
    {
        vidaVisual.GetComponent<Slider>().value = vidaPlayer;

        if (vidaPlayer <=0)
        {
            Debug.Log("game over");
            Destroy(bPM);
            Destroy(Bpm);
        }
    }
}
