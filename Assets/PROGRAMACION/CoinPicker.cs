using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CoinPicker : MonoBehaviour
{
    public TextMeshProUGUI TMP;
    public int coin = 0;

    public AudioSource Calabera;
    public AudioSource CalaberaKills;

    private void OnTriggerEnter(Collider other)
    {
        if ( other.tag == "Coin")
        {
            Destroy(other.gameObject);
            Calabera.Play();
            coin += 1;
            TMP.text = coin.ToString("0");
        }

        if (other.tag == "CoinKill")
        {
            Destroy(other.gameObject);
            CalaberaKills.Play();
            coin += 1;
            TMP.text = coin.ToString("0");
        }

    }


}
