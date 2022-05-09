using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fx : MonoBehaviour
{

    public AudioSource golpe;

    public AudioSource Calabera;

    public AudioSource Coinyin;

   

    public void Golpe()
    {
        golpe.Play();
    }

    public void calabera()
    {
        Calabera.Play();

    }

    public void CoinyIn()
    {
        Coinyin.Play();
    }


}
