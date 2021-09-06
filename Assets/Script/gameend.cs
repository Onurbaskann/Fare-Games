using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameend : MonoBehaviour
{
    public void playagain()
    {
        SceneManager.LoadScene("Fare Oynu111");
    }
    public void mainmenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
