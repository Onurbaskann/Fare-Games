using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class multiplayerend : NetworkBehaviour
{
    public GameObject peynir; 

    public Text timer;
    public float zaman;
    bool isbool = true;
    private string score;

    void Update()
    {
        if (isbool)
        {
            zaman += Time.deltaTime;
            timer.text = zaman.ToString("f0");
            score = zaman.ToString();

        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "mouse_8")
        {
            //Debug.Log("Kazandın");
            isbool = false;
            PlayerPrefs.SetString("point", score);
            SceneManager.LoadScene("Gameend");
        }


    }
}
