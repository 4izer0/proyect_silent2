using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PanelManagerr : MonoBehaviour
{
    public GameObject[] panel;
    GameObject curentPanel;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (curentPanel == null) return;
            curentPanel.SetActive(false);
        }
    }

    public void EnablePanel(int index)
    {
        
        curentPanel = panel[index];
        curentPanel.SetActive(true);
    }



}
