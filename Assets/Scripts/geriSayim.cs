using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class geriSayim : MonoBehaviour
{
    public float anliksure = -1;
    public float baslangicsuresi = 120;
    public float oyununTekrarBaslamaSuresi = 1;
    public int skorSayac = 0;
    public bool siradaki = false;

    public Text geriSayimText;
    public CanvasSettings cs;

    public bool oyun = true;

    public GameObject dogruButonu;
    public GameObject yanlisButonu;
    public GameObject passButonu;
    public GameObject kalanHak;

    public GameObject Kart;

    void Start()
    {
        cs.siradakiTakim.gameObject.SetActive(false);
        siradaki = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (oyun)
        {
            anliksure -= 1 * Time.deltaTime;
        }
        
        if (anliksure <= 0)
        {
            dogruButonu.SetActive(false);
            yanlisButonu.SetActive(false);
            Kart.SetActive(false);
            kalanHak.SetActive(false);
            passButonu.SetActive(true);

            if (cs.takim == 1)
            {
                cs.siradakiTakim.gameObject.SetActive(true);
                cs.siradakiTakim.color = Color.blue;
                cs.siradakiTakim.text = "Sırada " + AraSahne.takım1;
                cs.kalanHak = 3;
            }else if ( cs.takim == 2)
            {
                cs.siradakiTakim.gameObject.SetActive(true);
                cs.siradakiTakim.color = Color.red;
                cs.siradakiTakim.text = "Sırada " + AraSahne.takım2;
                cs.kalanHak = 3;
            }

            if (siradaki)
            {
                dogruButonu.SetActive(true);
                yanlisButonu.SetActive(true);
                Kart.SetActive(true);
                kalanHak.SetActive(true);
                cs.siradakiTakim.gameObject.SetActive(false);
                passButonu.SetActive(false);

                if (cs.takim == 1)
                {
                    cs.takim = 2;
                    skorSayac++;
                }
                else if (cs.takim == 2)
                {
                    cs.takim = 1;
                }

                siradaki = false;
                anliksure = baslangicsuresi;
            }
        }
        else if(anliksure <= 30)
        {
            geriSayimText.color = Color.red;
            geriSayimText.text = anliksure.ToString("0");

        }
        else if (anliksure <= 60)
        {
            geriSayimText.color = Color.blue;
            geriSayimText.text = anliksure.ToString("0");
        }
        else if (anliksure <= 120)
        {
            geriSayimText.color = Color.green;
            geriSayimText.text = anliksure.ToString("0");
        }
    }

    public void oyunDondur()
    {
        oyun = false;
    }
    public void oyunaDevam()
    {
        oyun = true;
    }
    
}
