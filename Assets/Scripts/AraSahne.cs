using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Collections;
using System.Collections.Generic;

public class AraSahne : MonoBehaviour
{
    public Text takim1T;
    public Text takim2T;
    public Text RaundT;

    public GameObject uyarıMenusu;

    public static string takım1;
    public static string takım2;
    public static int raund;

    private void Start()
    {
        raund = 5; // varsayılan raund
    }
    void Update()
    {
        takım1 = takim1T.text;
        takım2 = takim2T.text;
        raund = Int32.Parse(RaundT.text);
    }

    public void devamButonu()
    {
        
        if (takım1 != "" && takım2 != "")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            uyarıMenusu.SetActive(true);
        }
    }
    public void uyarıMenuKapat()
    {
        uyarıMenusu.SetActive(false);
    }
}
