using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class OncekiLevelYukle : MonoBehaviour
{
    public void OncekiLeveliYukle()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void anaMenuyeDon()
    {
        SceneManager.LoadScene("Açılış");
    }
}
