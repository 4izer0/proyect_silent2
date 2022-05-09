using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetYin : MonoBehaviour
{
    public TextMeshProUGUI TMP;
    public  coinYIN CoinYinn;
    public float yin;
    void Start()
    {
        yin = CoinYinn.Yin;
        TMP.text = yin.ToString("0");
    }
}
