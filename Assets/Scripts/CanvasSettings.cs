using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CanvasSettings : MonoBehaviour
{
    public geriSayim gs;
    public GameObject kart;
    public GameObject kartlarTukendi;
    public List<int> kullanilmiş = new List<int>();

    // 1 kırmızı 2 mavi 0 kimse
    public int takim = 2;

    public int maviskor = 0;
    public int kirmiziskor = 0;
    public int kactabitsion = 5;
    public int kalanHak = 3;

    public Text Maviskor;
    public Text Kirmiziskor;
    public Text siradakiTakim;
    public Text oyunSonuT;
    public Text kalanHakT;

    public Image oyunSonuI;

    public GameObject oyunSonu;
    public GameObject menu;
    public GameObject kalanHakGO;
    public GameObject siradakiTakimGO;

    public void Start()
    {
        //Debug.Log(Kartlar.kelimeKartları.Count);
        //Debug.Log(AraSahne.raund);
    }

    public void Update()
    {
        if (AraSahne.takım1 == "null")
        {
            Maviskor.text = "Mavi\n" + maviskor;
        }
        else
        {
            Maviskor.text = AraSahne.takım1 + "\n" + maviskor;
        }
        if (AraSahne.takım2 == "null")
        {
            Kirmiziskor.text = "Kırmızı\n" + kirmiziskor;
        }
        else
        {
            Kirmiziskor.text = AraSahne.takım2 + "\n" + kirmiziskor;
        }

        kalanHakT.text = "" + kalanHak;

        if (kalanHak <= 0)
        {
            kartDegis();
            kalanHak = 3;
            gs.anliksure = 0;
        }

        /*if (gs.skorSayac == kactabitsion)
        {
            gameOver();
        }*/
    }
    public void dogruButonu()
    {
        if (takim == 1)
        {
            kirmiziskor += 1;
        }
        else if (takim == 2)
        {
            maviskor += 1;
        }

        kartDegis();
    }
    public void passButonu()
    {
        gs.oyunaDevam();
        gs.siradaki = true;
    }
    public void yanlisButonu()
    {
        kalanHak -= 1;
        kartDegis();
    }
    public void kartDegis()
    {
        int number;
        number = Random.Range(0, Kartlar.kelimeKartları.Count);

        while (kullanilmiş.Contains(number))
        {
            number = Random.Range(0, Kartlar.kelimeKartları.Count);
            if (kullanilmiş.Count >= Kartlar.kelimeKartları.Count)
            {
                break;
            }
        }
        kullanilmiş.Add(number);
        BuKart.bukartId = number;

    }
    public void menuyeDon()
    {
        gs.oyunDondur();
        menu.SetActive(true);

        gs.dogruButonu.SetActive(false);
        gs.yanlisButonu.SetActive(false);
        gs.Kart.SetActive(false);
        kalanHakGO.SetActive(false);
    }
    public void oyunaDon()
    {
        menu.SetActive(false);
        gs.oyunaDevam();

        gs.dogruButonu.SetActive(true);
        gs.yanlisButonu.SetActive(true);
        gs.Kart.SetActive(true);
        kalanHakGO.SetActive(false);
    }
    public void gameOver()
    {
        oyunSonu.SetActive(true);
        if (maviskor == kirmiziskor)
        {
            oyunSonuT.text = "BERABERE!!!";

            int a = 0;
            while (true)
            {
                if (a % 2 == 0)
                {
                    oyunSonuI.color = Color.red;
                }
                else
                    oyunSonuI.color = Color.blue;

                if (a == 50)
                {
                    break;
                }

                a++;
            }
        }
        else if (maviskor > kirmiziskor)
        {
            oyunSonuI.color = Color.blue;
            oyunSonuT.text = "Mavi Takım Kazandı!!!";
        }
        else if (maviskor < kirmiziskor)
        {
            oyunSonuI.color = Color.red;
            oyunSonuT.text = "Kırmızı Takım Kazandı!!!";
        }
    }
}
