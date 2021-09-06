using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class finishAI : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public Text sure;
    private float Startime;
    private bool finish = false;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>()    ;
        Startime = Time.time;
        
    }
    void Update()
    {
        if (finish)
        {
            return;

            float t = Time.time - Startime;
            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f");
            sure.text = minutes + "t" + seconds;
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "mouse_8")
        {
           
            SceneManager.LoadScene("Gameend");
        }


    }
}
