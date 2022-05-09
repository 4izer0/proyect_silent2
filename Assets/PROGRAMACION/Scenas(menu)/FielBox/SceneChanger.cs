using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public Animator ani;


    // Update is called once per frame
    public void GotoScene(int index)
    {
        ani.SetInteger("State", 1);
        StartCoroutine(WaitForFade(index));
        
    }

    IEnumerator WaitForFade( int index)
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(index);
    }
}
