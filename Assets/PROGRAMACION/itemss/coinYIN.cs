using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coinYIN : MonoBehaviour
{

    public TextMeshProUGUI TMP;
    public int Yin = 0;

    public AudioSource Coinyin;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CoinYin")
        {
            Destroy(other.gameObject);
            Coinyin.Play();
            Yin += 1;
            TMP.text = Yin.ToString("0");
        }


    }
}
