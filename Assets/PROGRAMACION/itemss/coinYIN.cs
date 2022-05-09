using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coinYIN : MonoBehaviour
{

    public TextMeshProUGUI TMP;
    public int Yin = 0;

    public AudioSource Coinyin;

    public AudioSource CoinyinRisas;

    public AudioSource nocorras;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CoinYin")
        {
            Destroy(other.gameObject);
            Coinyin.Play();
            Yin += 1;
            TMP.text = Yin.ToString("0");
        }
        if (other.tag == "CoinYinRisas")
        {
            Destroy(other.gameObject);
            CoinyinRisas.Play();
            Yin += 1;
            TMP.text = Yin.ToString("0");
        }
        if (other.tag == "noCorras")
        {
            Destroy(other.gameObject);
            nocorras.Play();
            Yin += 1;
            TMP.text = Yin.ToString("0");

        }
    }
}
