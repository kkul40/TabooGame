using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BuKart : MonoBehaviour
{
    public List<Kart> buKart = new List<Kart>();
    public static int bukartId;

    public int id;
    public string kelime;
    public string yasak;
    public string yasak1;
    public string yasak2;
    public string yasak3;
    public string yasak4;

    public Text kelimeT;
    public Text yasakT;
    public Text yasak1T;
    public Text yasak2T;
    public Text yasak3T;
    public Text yasak4T;

    void Update()
    {
        kelime = buKart[0].kelime;
        yasak = buKart[0].yasak;
        yasak1 = buKart[0].yasak1;
        yasak2 = buKart[0].yasak2;
        yasak3 = buKart[0].yasak3;
        yasak4 = buKart[0].yasak4;

        kelimeT.text = kelime;
        yasakT.text = yasak;
        yasak1T.text = yasak1;
        yasak2T.text = yasak2;
        yasak3T.text = yasak3;
        yasak4T.text = yasak4;
    }
    private void FixedUpdate()
    {
        buKart[0] = Kartlar.kelimeKartları[bukartId];
    }



}
