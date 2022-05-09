using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GetCoins : MonoBehaviour
{
    public TextMeshProUGUI TMP;
    public CoinPicker coinpicker;
    public float coins;
    void Start()
    {
        coins = coinpicker.coin;
        TMP.text = coins.ToString("0");
    }


}
