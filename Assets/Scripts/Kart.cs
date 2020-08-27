using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class Kart
{
    public int id;
    public string kelime;
    public string yasak;
    public string yasak1;
    public string yasak2;
    public string yasak3;
    public string yasak4;

    public Kart()
    {
    }
    public Kart(int id, string kelime, string yasak, string yasak1, string yasak2, string yasak3, string yasak4)
    {
        this.id = id;
        this.kelime = kelime;
        this.yasak = yasak;
        this.yasak1 = yasak1;
        this.yasak2 = yasak2;
        this.yasak3 = yasak3;
        this.yasak4 = yasak4;
    }
}
