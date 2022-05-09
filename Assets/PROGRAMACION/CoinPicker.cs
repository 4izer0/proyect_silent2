using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CoinPicker : MonoBehaviour
{
    public TextMeshProUGUI TMP;
    public int coin = 0;

    private void OnTriggerEnter(Collider other)
    {
        if ( other.tag == "Coin")
        {
            Destroy(other.gameObject);
            coin += 1;
            TMP.text = coin.ToString("0");
        }


    }


}
